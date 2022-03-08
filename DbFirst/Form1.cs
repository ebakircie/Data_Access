using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();

        // ToList
        private void btnToList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.ToList();
        }

        // Where
        private void btnWhere_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x => x.ProductID <= 10).ToList();
        }

        // Select
        private void btnSelect_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Select(x => new
            {
                x.ProductID,
                x.ProductName,
                x.Category.CategoryName,
                x.UnitPrice,
                x.UnitsInStock
            }).ToList();
        }

        void OrderByDescending()
        {
            dataGridView1.DataSource = db.Products.OrderByDescending(x => x.UnitPrice).ToList();
        }

        // OrderBy => Ascending
        void OrderBy()
        {
            dataGridView1.DataSource = db.Products.OrderBy(x => x.UnitPrice).ToList();

        }
        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            OrderByDescending();
            //OR
            //OrderBy();
        }

        // GroupBy
        // with Count
        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Orders.GroupBy(x => x.ShipCountry).Select(x => new
            {
                ShipCity = x.Key,
                ShipCountry = x.Count()

            }).ToList();



        }

        //First
        private void btnFirst_Click(object sender, EventArgs e)
        {
            //If data is null, we must handle breaking.
            try
            {
                Category category = db.Categories.First(x => x.CategoryID == 1);
                MessageBox.Show("Category ID: " + category.CategoryID + "\n" + "Category Name: " + category.CategoryName);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Category");
            }

        }

        // FirstOrDefault
        // Works same as First but instead of breaking, it returns null.
        private void btnFirstOrDefault_Click(object sender, EventArgs e)
        {
            Category category = db.Categories.FirstOrDefault(x => x.CategoryID == 1);
            MessageBox.Show(category.CategoryName);
        }

        // Find
        // Mostly preferred when we need to find data by ID number as it's unique identifier.
        private void btnFind_Click(object sender, EventArgs e)
        {
            Category category = db.Categories.Find(1);

            MessageBox.Show("Id: " + category.CategoryID + "\n" + "Name: " + category.CategoryName);
        }

        // Take
        // Works smilar to "TOP" but we can select as many as we want from data. It order's data by Id as default.
        private void btnTake_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Take(50).ToList();
        }
        
        // Skip
        // Skips the data as given value by it's parameter. Must be used with OrderBy/OrderByDescending
        private void btnSkip_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.OrderBy(x => x.ProductID).Skip(5).ToList();
        }

        // Contains
        // Check if data contains a specific character or word
        private void btnContains_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.Where(x => x.FirstName.Contains("o")).ToList();
        }

        // Any
        // Returns boolean depends on condition is met or not.
        private void btnAny_Click(object sender, EventArgs e)
        {
            bool result = db.Categories.Any(x => x.CategoryName == "Beverages");

            if (result == true)
            {
                MessageBox.Show("Category available!");
            }
            else
            {
                MessageBox.Show("Category unavailable!");
            }
        }

        // StartsWith
        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.Where(x => x.FirstName.StartsWith("a")).ToList();
        }

        // EndsWith
        private void btnEndsWith_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.Where(x => x.FirstName.EndsWith("a")).ToList();
        }

        // Count 
        private void btnCount_Click(object sender, EventArgs e)
        {
            int totalEmployee = db.Employees.Count();
            MessageBox.Show("Total Employees: " + totalEmployee);
        }
        // Differences between Count () and Sum ();
        // Count, counts the row numbers. Sum calculates the number inside rows.

        // Sum
        private void btnSum_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.GroupBy(x => x.Category.CategoryName)
                .Select(x => new
                {
                    CategoryName = x.Key,
                    Stock = x.Sum(y => y.UnitsInStock)
                }).OrderByDescending(x => x.Stock).ToList();
        }

        // Min / Max
        private void btnMinMax_Click(object sender, EventArgs e)
        {
            int? minStocked = db.Products.Min(x => x.UnitsInStock);
            int? maxStocked = db.Products.Max(x => x.UnitsInStock);

            MessageBox.Show("Least stocked Product: " + minStocked + "\n" + "Most stocked Product: " + maxStocked);

        }
        // DateDiff
        // SQL Function that calculate difference between start date and end date.
        private void btnDateDiff_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.Select(x => new
            {
                FullName = x.FirstName + " " + x.LastName,
                Age = SqlFunctions.DateDiff("year", x.BirthDate, DateTime.Now)
            }).OrderByDescending(x => x.Age).ToList();

        }
        
        // Distinct
        // Works same as Count but doesnt count same values.
        private void btnDistinct_Click(object sender, EventArgs e)
        {
            int result = db.Employees.Select(x => x.City).Distinct().Count();
            MessageBox.Show("There are " + result + " different cities at Employees Table.");
        }
    }
}
