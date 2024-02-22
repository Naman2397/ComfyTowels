Subject-Web application Security
Group Name:IOTA
Team Members
Prashant Sapkota
Naman Sharma
Polina Satyanarayana Murthy
Research -We are researching on the product and we thought the competetive company on the market are Statista and Pomp & Sass.

2024-02-17
1430
Creating Project
Started by creating a new ASP.NET Core MVC project named ComfyTowels
we ran the application, Built was successfull
We created a controller named TowelsController.cs
we modified HelloWorldController class to use razor view files
this encapsulates the process of generating HTML responses.
we replaced the index method which calls controllers view method

Adding a view
We added a new view Index.cshtml
we changed the title, footer and link in the layout
Examined the views and changed the title, heading 
now the welcome method in the Controller class takes name and ID and outputs the values to the browser.

2024-02-19
1350

We all gathered at Naman's place to perform the next steps.

Adding Model
defined a Towel class representing the structure of a towel, including properties like Towel type size color price 
Created the homepage (Index.cshtml) where the list of towels is displayed. Used Razor syntax to dynamically render HTML based on the model data.
Created the homepage (Index.cshtml) where the list of towels is displayed. Used Razor syntax to dynamically render HTML based on the model data.
Determined the entities we need to represent in our application
Open the appsettings.json file and add a connection string under the "ConnectionStrings" section.

Scaffolding
we are using scaffolding for CRUD operationns.
we created a new scaffolded item named ComfyTowels.Data.ComfyTowelsContext.
Selected SQL Server as database probvider
initaited migration in the powershell using Add-Migration InitialCreate and Update-Database commands. These commands creates the database schema and updates the database to the latest migration.
Ran the application no errors occured.

Working with database
Examined the Database, seeded the database
added the seed initializer
Controller Methods m
developed a controller to handle HTTP requests related to towels. 
Implemented actions for displaying the list of towels (Index), adding a new towel (Create), updating an existing towel (Edit), and deleting a towel (Delete).
Used route attributes to define the URL paths for each action within the TowelController.
This was done by all the team member .

Observations: 
Provided brief overview of the TowelController and its purpose within the project.
Described the implemented actions of the TowelController, including Index, Create, Edit, and Delete.
Explained the purpose of each action in managing towels, such as displaying a list, adding, updating, and deleting towels.
Discussed how errors and edge cases are handled within the TowelController actions



2024-02-20
1305 
applied model validation attributes to the Towel class properties to enforce data integrity and ensure that valid towel data is submitted.
Conducted manual testing to ensure that the application functions as expected, including adding, editing, and deleting towels, as well as handling any edge cases or error scenarios.

Observations:
Model validation attributes have been applied to the properties of the Towel class
Tested the application demonstrates a commitment to continuous improvement 
including adding, editing, and deleting towels, as well as handling edge cases and error scenarios.


2024-02-21
1205
Updated the README file to provide instructions for setting up and using the application, as well as information on contributing to the project.
We all the team members were just Exploring various deployment options, such as deploying to a local server for testing
or deploying to a cloud hosting provider for production use.

2024-02-22
1300
Added a button for the products named Towels
Added more categories in the page like types.
Updated the database ran the application few errors occured resolved them and application was running
