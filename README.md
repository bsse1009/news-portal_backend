Prerequisites
.NET Core SDK 3.0 or later
Visual Studio Code
C# for Visual Studio Code
MongoDB


Configure MongoDB
If using Windows, MongoDB is installed at C:\Program Files\MongoDB by default. Add C:\Program Files\MongoDB\Server\<version_number>\bin to the Path environment variable. This change enables MongoDB access from anywhere on your development machine.

Use the mongo Shell in the following steps to create a database, make collections, and store documents.

Choose a directory on your development machine for storing the data. For example, C:\BooksData on Windows. Create the directory if it doesn't exist. The mongo Shell doesn't create new directories.

Open a command shell. Run the following command to connect to MongoDB on default port 27017. Remember to replace <data_directory_path> with the directory you chose in the previous step.
mongod --dbpath <data_directory_path>

Open another command shell instance. Connect to the default test database by running the following command:
> mongo

Run the following in a command shell:
> use NewsDb

If it doesn't already exist, a database named NewsDb is created. If the database does exist, its connection is opened for transactions.

Create a News collection using following command:
> db.createCollection('Newses')

Create a Users collection using following command:
> db.createCollection('Users')

Insert an admin_user for the Users using the following command:
> db.Users.insert({"name": "Ibrahim Khalil","email": "bsse1009@iit.du.ac.bd","password": "1234","type": "admin"})

View the document in database:
> db.Users.find({}).pretty()


Open Project:
1. open cmd and type
    cd <Project_dir>
    code NewsApi
    A new ASP.NET Core web API project is opened in Visual Studio Code.

2. After the status bar's OmniSharp flame icon turns green, a dialog asks Required assets to build and debug are missing from 'BooksApi'. Add them?. Select Yes.

3. Run the following command to install the .NET driver for MongoDB:

.NET CLI

> dotnet add package MongoDB.Driver --version 2.13.0

4. Install Cors
> Install-Package Microsoft.AspNet.WebApi.Cors


Build And Run:
> dotnet run