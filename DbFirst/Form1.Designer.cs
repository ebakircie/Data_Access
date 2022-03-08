namespace DbFirst
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnToList = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnStartsWith = new System.Windows.Forms.Button();
            this.btnFirstOrDefault = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnAny = new System.Windows.Forms.Button();
            this.btnEndsWith = new System.Windows.Forms.Button();
            this.btnDateDiff = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnDistinct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnToList
            // 
            this.btnToList.Location = new System.Drawing.Point(17, 50);
            this.btnToList.Name = "btnToList";
            this.btnToList.Size = new System.Drawing.Size(75, 23);
            this.btnToList.TabIndex = 2;
            this.btnToList.Text = "To List";
            this.btnToList.UseVisualStyleBackColor = true;
            this.btnToList.Click += new System.EventHandler(this.btnToList_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(17, 79);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(75, 23);
            this.btnWhere.TabIndex = 3;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(98, 50);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(83, 23);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(17, 108);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Location = new System.Drawing.Point(17, 138);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(75, 23);
            this.btnOrderBy.TabIndex = 5;
            this.btnOrderBy.Text = "OrderBy";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Location = new System.Drawing.Point(17, 167);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(75, 23);
            this.btnGroupBy.TabIndex = 4;
            this.btnGroupBy.Text = "Group By";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnStartsWith
            // 
            this.btnStartsWith.Location = new System.Drawing.Point(187, 108);
            this.btnStartsWith.Name = "btnStartsWith";
            this.btnStartsWith.Size = new System.Drawing.Size(75, 23);
            this.btnStartsWith.TabIndex = 6;
            this.btnStartsWith.Text = "StartsWith";
            this.btnStartsWith.UseVisualStyleBackColor = true;
            this.btnStartsWith.Click += new System.EventHandler(this.btnStartsWith_Click);
            // 
            // btnFirstOrDefault
            // 
            this.btnFirstOrDefault.Location = new System.Drawing.Point(98, 79);
            this.btnFirstOrDefault.Name = "btnFirstOrDefault";
            this.btnFirstOrDefault.Size = new System.Drawing.Size(83, 23);
            this.btnFirstOrDefault.TabIndex = 6;
            this.btnFirstOrDefault.Text = "FirstOrDefault";
            this.btnFirstOrDefault.UseVisualStyleBackColor = true;
            this.btnFirstOrDefault.Click += new System.EventHandler(this.btnFirstOrDefault_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(98, 108);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(83, 23);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(98, 137);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(83, 23);
            this.btnTake.TabIndex = 6;
            this.btnTake.Text = "Take";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(98, 166);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(83, 23);
            this.btnSkip.TabIndex = 6;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(187, 50);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(75, 23);
            this.btnContains.TabIndex = 6;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnAny
            // 
            this.btnAny.Location = new System.Drawing.Point(187, 79);
            this.btnAny.Name = "btnAny";
            this.btnAny.Size = new System.Drawing.Size(75, 23);
            this.btnAny.TabIndex = 6;
            this.btnAny.Text = "Any";
            this.btnAny.UseVisualStyleBackColor = true;
            this.btnAny.Click += new System.EventHandler(this.btnAny_Click);
            // 
            // btnEndsWith
            // 
            this.btnEndsWith.Location = new System.Drawing.Point(187, 138);
            this.btnEndsWith.Name = "btnEndsWith";
            this.btnEndsWith.Size = new System.Drawing.Size(75, 23);
            this.btnEndsWith.TabIndex = 7;
            this.btnEndsWith.Text = "EndsWith";
            this.btnEndsWith.UseVisualStyleBackColor = true;
            this.btnEndsWith.Click += new System.EventHandler(this.btnEndsWith_Click);
            // 
            // btnDateDiff
            // 
            this.btnDateDiff.Location = new System.Drawing.Point(387, 79);
            this.btnDateDiff.Name = "btnDateDiff";
            this.btnDateDiff.Size = new System.Drawing.Size(75, 23);
            this.btnDateDiff.TabIndex = 8;
            this.btnDateDiff.Text = "DateDiff";
            this.btnDateDiff.UseVisualStyleBackColor = true;
            this.btnDateDiff.Click += new System.EventHandler(this.btnDateDiff_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(306, 50);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 8;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(387, 50);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 8;
            this.btnSum.Text = "Sum ";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Location = new System.Drawing.Point(468, 50);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(75, 23);
            this.btnMinMax.TabIndex = 8;
            this.btnMinMax.Text = "Min/Max";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnDistinct
            // 
            this.btnDistinct.Location = new System.Drawing.Point(187, 167);
            this.btnDistinct.Name = "btnDistinct";
            this.btnDistinct.Size = new System.Drawing.Size(75, 23);
            this.btnDistinct.TabIndex = 8;
            this.btnDistinct.Text = "Distinct";
            this.btnDistinct.UseVisualStyleBackColor = true;
            this.btnDistinct.Click += new System.EventHandler(this.btnDistinct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnMinMax);
            this.Controls.Add(this.btnDistinct);
            this.Controls.Add(this.btnDateDiff);
            this.Controls.Add(this.btnEndsWith);
            this.Controls.Add(this.btnFirstOrDefault);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnAny);
            this.Controls.Add(this.btnStartsWith);
            this.Controls.Add(this.btnOrderBy);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnGroupBy);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnToList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnToList;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Button btnStartsWith;
        private System.Windows.Forms.Button btnFirstOrDefault;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnAny;
        private System.Windows.Forms.Button btnEndsWith;
        private System.Windows.Forms.Button btnDateDiff;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button btnDistinct;
    }
}

