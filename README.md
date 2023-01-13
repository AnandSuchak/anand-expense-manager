To start this project basic need is microsoft visual studio code 2022 <br>

in their when user open stdio option of clone this project is seen that you need by select by clicking  clone a repository which offen is 1st option. <br>

moving ahead install reqiured package by clicking on tools ->NuGet Package Manager -> Package Manager Console<br>

then enter command line as " NuGet\Install-Package Microsoft.EntityFrameworkCore.SqlServer " for sql server <br>

and then " NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools  " for tools <br>

moving forward to generate datadet use cmd line as "add-migration ExpenseMigration "<br>

in the ExpenseDBContext.cs , there is function name UseSqlServer Change the path of your database from getting it after u create data base .<br>

that path will be found in Server Explorer , clicking right click on name of database table and selecting properties <br>

at right side corner properties will be seen and over their the path that need to copied is in connection string . <br>

that will build connection establishment between databse. <br>

later on "update-databse " so that everything that written in ![Screenshot (2)](https://user-images.githubusercontent.com/102275971/212401765-43028d04-fc99-4ed3-992a-116ba693294c.png)

this shows database after migrating 
their area other functions as well like adding expance which will look alike below 

![Screenshot (3)](https://user-images.githubusercontent.com/102275971/212401950-f9dbfb66-e70c-4820-9be9-84a4b0d3a05f.png)
