## Parks Lookup API
------------------------------
### <u>Table of Contents</u>
* <a href="#🌐-about-the-project">About the Project</a>
    * <a href="#📖-description">Description</a>
    * <a href="#🦠-known-bugs">Known Bugs</a>
    * <a href="#🛠-built-with">Built With</a>
* <a href="#🏁-getting-started">Getting Started</a>
    * <a href="#📋-prerequisites">Prerequisites</a>
    * <a href="#⚙️-setup-and-use">Setup and Use</a>
    * <a href="#🛰️-api-documentation">API Documentation</a>
* <a href="#⚖️-license">License</a>    
------------------------------

## 🌐 About the Project

### 📖 Description
An API that serves as the back-end connector to a database which stores and serves user created entries documenting parks around the USA. 

### 🦠 Known Bugs

* None

### 🛠 Built With
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-5.0)
* [MySQL 8.0.27](https://dev.mysql.com/)
* [Entity Framework Core 5.0.0](https://docs.microsoft.com/en-us/ef/core/)
* [Swagger](https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-5.0)
* [Postman](postman.com)
------------------------------

## 🏁 Getting Started

### 📋 Prerequisites

#### Install .NET Core
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install MySQL Workbench
 [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

  To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

  1) Code Editor Download:
     * Option 1: [VS Code](https://code.visualstudio.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)

### ⚙️ Setup and Use

  #### Cloning

  1) Navigate to the [Parks_Lookup repository here](https://github.com/emmersot/Parks_Lookup).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/emmersot/Parks_Lookup.git`
  5) Run the command `cd ParksLookup` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `code .` to open the project in VisualStudio Code for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### AppSettings

  1) Create a new file in the Parks_Lookup/ParksLookup directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
  ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=Parks_Lookup_API;uid=root;pwd=YourPassword;"
    }
}
  ```
  3) Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

  #### Database
  1) Navigate to Parks_Lookup/ParksLookup directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/Parks_Lookup/ParksLookup`).
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

  #### Launch the API
  1) Navigate to Parks_Lookup/ParksLookup directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/Parks_Lookup/ParksLookup`).
  2) Run the command `dotnet run` to have access to the API in Postman or browser.

------------------------------

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Using Swagger Documentation 
To explore the FreePileFinder API with NSwag, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger`

#### Example Query
```
https://localhost:5000/api/parks/
```

To use default, _don't include_ `limit` and `start` or set them equal to zero.

..........................................................................................

### Endpoints
Base URL: `https://localhost:5000`

#### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Example Query
```
https://localhost:5000/api/parks/3
```

#### Sample JSON Response
```
{
    "parkId": 3,
    "title": "Crater Lake National Park",
    "description": "Crater Lake inspires awe. Native Americans witnessed its formation 7,700 years ago, when a violent eruption triggered the collapse of a tall peak. Scientists marvel at its purity—fed by rain and snow, it’s the deepest lake in the USA and one of the most pristine on Earth. Artists, photographers, and sightseers gaze in wonder at its blue water and stunning setting atop the Cascade Mountain Range.",
    "createdDate": "2022-08-19T14:35:03",
    "city": "Crater Lake",
    "state": "OR",
    "zipcode": "97604",
    "lat": 42.94065854,
    "lng": -122.1338414,
    "parkCode": "crla"
}
```

..........................................................................................

### Piles
Access information on Parks from around the USA.

#### HTTP Request
```
GET /api/parks
POST /api/parks
GET /api/parks/{id}
PUT /api/parks/{id}
DELETE /api/parks/{id}
```
..........................................................................................

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2022 Tyler Emmerson. All Rights Reserved.

```
MIT License

Copyright (c) 2022 Tyler Emmerson.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
------------------------------

<center><a href="#">Return to Top</a></center>