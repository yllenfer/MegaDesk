# MegaDesk
Team project.
Participants:
**Yllen Fernandez**
**Julieta White**

The projecct is a desktop application that determines desk prices quotes for the custom desk order. 
The goal of this project is to digitize and automate the method of taking and storing desk quotes. 
MegaDesk is a fictitious, small company that makes custom desks to order within a given parameter and constraint set. 

## Functional Specifications
#### Required Inputs and Input Constraints:
+ customer full name
+ size of desk in width (minimum 24 inches and maximum 96 inches)
+ size of the desk in depth (minimum 12 inches and maximum of 48 inches)
+ number of drawers ( zero to seven drawers maximum)
+ desktop surface material (laminate, oak, rosewood, veneer, or pine)
+ rush order options of 3, 5, or 7 days. The normal production time is 14 days.
#### Output
+ a single price quote is given with valid input submission
+ a view of all stored price quotes that can be sorted
+ the ability to search for and list specific price quotes based upon desktop material
#### Views
+ main menu with buttons to add a new quote, view all quotes, search quotes, and exit the application
+ add new quote with a confirmation summary of the quote including the total price
+ view all quotes in a list
+ search quotes by desktop material

## Team Requirements MegaDesk 2.0
+ Create a new Team repository. Ensure repo is setup correctly with the permissions and the correct .gitignore file.
+ Upload an initial MegaDesk version 1 project to build upon or you may start from scratch. 
+ Review your naming of objects and members as a team.
+ Use at least one instance of a List<> class in your application
+ Add the ability for the user to SEARCH through the orders by combo-box selected surface material and display the desk quote with the customer name, quote date, desk specs, and overall price quote.
+ Add the ability for the user to click to display all saved quotes using a DataGridView object.
+ Read in the rush order price list from this file: rushOrderPrices.txt.
  - Use these values from the file versus using 'magically' embedded values in the rush order quote amount logic within your DeskQuote class.
  - The order of the prices is obtuse so make sure you match this array or list of values with the specifications chart.
+ Store the desk quotes in an appended JSON file named quotes.json
+ Support a solid UX with proper PARC design on the UI.



