# About Repo
This project is for a unit (SWE20001 Managing Software Projects) at university ( Swinburne University of Technology) that is for a made up client known as GoTo Grocery. In simple terms, the aim is to create a digital system for the client ( a membership based grocery store ) that will allow the client to pursue their daily business on a digital platform with a simple and easy to use graphical user interface that enables them to update member details and inventory levels. The application should also be able to export the inventory levels to a ".csv" file so that the client can manually order stock when inventory levels are running low. For a more detailed document outlining the requirements, please see below. 

## Project Objectives and Deliverables
You can find all project details within the project folder of this repo. It details all the customer details, customer needs, project proposal, details, backlog, quality management and more.

# Team
The team behind this project are as follows:
- Duhncan - Studying Engineering (Robotics and Mechatronics) and Computer Science (Software Design)
- Daniel - Studying Engineering (Robotics and Mechatronics) and Computer Science (IoT)
- Ronan - Studying Engineering (Robotics and Mechatronics) and Computer Science (Software Design)
- Aiden - Studying Computer Science (Cybersecurity)

# Usage
To be continued...

# Documentation 
## Member Class

## Inventory Class
The Inventory class only consists of an empty constructor method and a validateProduct method which is used for checking the user input when adding or editing a product. It compares each aspect of the product details (product name, inventory level, product size, shelf quantity, and order amount) against a regex string which matches a valid input pattern for each item. It returns an integer depending on whether or not any fields were invalid and also which field was invalid. This integer is used by the AddItem and EditItem form classes to create a popup message informing the user of which field is invalid, or to add/edit the item if all of the fields pass the regex tests.

## Database Class

## Graphical Interface
