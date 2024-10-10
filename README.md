# Application name

AddressBook

# Important

This is an application which retrieves persons from a database table. The persons are retrieved in a PrimeNG table. Each row contains a button that opens a Modal Dialog with the person's address.

It is made based on ASP.NET Boilerplate, which is an open-source framework that was created by the same team who developed ASP.NET Zero.

- The data is stored in a SQL Server Database. The database is generated based on the Code-First approach, with Model Objects, by using Entity Framework Core.
- The data displayed in the PrimeNG table is retrieved from the database by using LINQ (the implementation can be seen in PersonAppService.cs, that is located at "AddressBookProj\src\AddressBook.Application\Person").
- Additionally, the data is mapped to a DTO Object (PersonDto, which can be found at "AddressBookProj\src\AddressBook.Application\Person\Dtos") by using an ObjectMapper which was created in the DtoMappings.cs file, located at "AddressBookProj\src\AddressBook.Application".
- Angular fetches data from the backend API using Typescript service-proxies (located in AddressBookProj\src\AddressBook.Web.Host\src\shared\service-proxies) that are generated by using NSwag.
- The Address is displayed on a ngx-bootstrap Modal Dialog, containing the person's address and the person's name (I've added the last one for clarity).


# Instructions

1. By using a terminal window, navigate to the folder where you want to install the application.
2. Run the following command: git clone https://github.com/username/repository_name.git
3. Navigate to "AddressBookProj\src\AddressBook.Web.Host"
4. Run npm ci --legacy-peer-deps
5. Run ng serve and leave the window open
6. Open Visual Studio 2022 or 2019 -> Open a project or solution -> select the AddressBook.sln from the AddressBookProj folder
7. In the Debug Toolbar, select the AddressBook.Web.Host target project
8. Run IIS Express
9. Open http://localhost:4200/ in a browser
10. Login with user: admin and password:123qwe

10. Create Database (Optional)
10.1. Make sure the app is closed
10.2. Create and configure the appsettings.json file from AddressBook.Web.Host based on the appsettings.example.json file from the same folder.
10.3. In Package Manager Console, select "src\AddresBook.EntityFrameworkCore" as "Default project" and run "add-migration addressBookInit", the "update-database"
10.4. Add Persons in the newly created Persons table

# For questions/further information you can contact me on bogdan_danila96@yahoo.com or bcdprojects96@gmail.com.
