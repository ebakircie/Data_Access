## - What is ORM?
Object-Relational Mapping ([ORM](https://en.wikipedia.org/wiki/Object–relational_mapping)) is a programming technique which connects programming languages to databases like a bridge. ORM helps us to execute sql querries without typing them directly like exact sql querries. After ORM is  configured, with the help of OOP user can work with the database.

## - Entity Framework
Official Definition: “Entity Framework is an Object-Relational Mapper (ORM) that enables .NET developers to work with a database using .NET objects. It eliminates the need for most of the data-access code that developers usually need to write.”

Some benefits of using Entity Framework are;

- reduced development time and development cost
- easy mapping of Business Objects.
- fast CRUD operations in .NET Applications.

![ef-core-dev-approaces](https://user-images.githubusercontent.com/77506856/157751501-06aab3ef-7179-4167-b638-534ac924a442.png)

1.Database First;

Database First allows you to reverse engineer a model from an existing database and let user use database as a class object.

2.Code First

In this method after creating objects into classes, we migrate them to the database after we detirmine how they will act such as relations between tables, rules or conventions. This enables the developers to get more control through the code.

