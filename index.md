## GotoGrocery Documentation

On this webpage, you will find all the documentation about the GotoGrocery API and Documentation.

### Introduction
This program is written in C#. The team has collaborated on the project in Visual Studio (VS) Community and all VS Solutions are included within the repository for convenience.

### Prerequisites
In order for this application to work, it must be able to contact a MySQL server with all the database information being stored there. For testing purposes, MySQL Workbench was run and simulated in order to design this application. 

### Usage
This section will detail how to use the application.

### Member Class
#### Methods
The methods for this class are as follows:
- Method 1: Something
  - This is to do with this...
- Method 1: Something
  - This is to do with this...
##### Validation
The validation method returns a binary value with each bit representing whether validation has passed or failed for a specific property of the class. The relation of bit to property is as follows:
- Bit 0: NA
- Bit 1: First Name
- Bit 2: Last Name
- Bit 3: Phone Number
- Bit 4: Membership Status
- Bit 5: Membership Start Date
- Bit 6: NA
- Bit 7: NA
If any of the bits are not returned as a "1" or set high, then it is the programmer's job to rectify the issue. 

#### Properties
All properties within the Member Class are able to get and set. No validation occurs when setting and the validation method must be called to check for the respective validity of set variable.
- Property 1: Something
  - This is to do with this...
- Property 1: Something
  - This is to do with this...
### Inventory Class

### Database Class
The Database class is the lowest level class in the program, its purpose is to directly push and pull data from both the inventory and members table within the database. The purpose of this class is to provide other classes with simple definition to connect to the database, this class required to have many methods as only one connection can exist during a single run time.

- DatabaseConnection()
  - Database constructor used to initialize the connection to the database.

- GetMemberList():DataTable
  - Pulls data from the member database which can be used to display the data in a table.

- MembersCollection()
  - Prints out all the data in the members table to the console, used for validation and testing.

- NumberOfMembers(): int
  - Returns the number of members that's in the database.

- HighestMemberId(): int
  - Returns the highest member id.

- AddMember(string, string, string, string, string): bool
  - Adds a member into the members table returns true when successfully added to the table.

- RemoveMemberById(int)
  - Removes a member from the database using the members id.

- GetMemberId(string): int
  - Returns the member ID based on the members email.

- CheckIfMemberExists(string)
  - Checks if the member exists using the members email.

- MembertoString(int): List<string>
  - Returns a row from the members table as a list of strings, using the members ID.
  
- UpdateMember(string, string, string): bool
  - Updates a given value in the member table row based on the column based on the members email. Returns true if the member is updated successfully.
  
- SearchMemberByName(string): DataTable
  - Used to return a datatable of the member based on their email.
  
- GetInventoryList(): DataTable
  - Returns a datatable of all the products in the inventory table.
  
- SearchInventoryByName(string): DataTable
  - Returns a row of a product in the inventory table, as a datatable.
  
- InventoryCollection()
  - Returns all data from the inventory table to the console for debugging purposes.
  
- HighestProductID(): int
  - Returns the highest product id.
 
- NumberOfProducts(): int
  - Returns the number of products inventory table.
  
- AddProduct(string, int, string, int, int): bool
  - Adds a product to the inventory table.
  
- SearchInventoryById(int): List<string>
  - Returns a list of a product row as strings using the product id.
  
- ProductRowToStringint): List<string>
  - Returns a list of a product row as strings using the product name.
  
- CheckIfProductExists(string): bool
  -Use the product name to see if a product is in the inventory table and returns true
  
- UpdateProduct(string, string, string): bool
  - Updates a given value in the inventory table row based on the column based on the products name. Returns true if the member is updated successfully.
 
- ExportInventoryReport()
  - Exports a CSV file of the inventory.
  


### GUI Class - Aiden
Overview

Windows Forms is a UI framework that was used to design and implement this windows desktop application. Windows forms was an efficient way to provide the client a simple and intuitive GUI which would allow a user to perform tasks required to manage Members and Inventory. Within .NET, Windows Forms provides a set of useful libraries which have simplified the overall development. Utilizing the visual designer provided in Visual Studio, forms were created to display pages containing labels, interactive text boxes and buttons and grids to display data from the database.

  Interactivity

  To provide interactivity within the application, controls which are defined by Microsoft as ‘discrete user interface (UI) element (‘s) that displays data or accepts data input’ are used to generate events by performing some action. These events execute some code which are implemented through methods existing within the form class from which the event takes place (methods and classes are detailed below).  Using a Façade design pattern operations on user data are largely performed by the respective Member and Inventory classes including validation and sending queries with the database class.

Classes....


#### Markdown Help (Internal)
This files are written in markdown so if you need any help with syntax: see [Basic writing and formatting syntax](https://docs.github.com/en/github/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
