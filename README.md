# Warehouse Inventory Management System

## Overview

This project is a warehouse inventory management application developed in C# and SQL Server AdventureWorks2022. The system allows users to search inventory items, view stock levels, monitor inventory across warehouse locations, and identify products that require replenishment.

The application was designed to simplify inventory tracking and provide quick access to stock information through a user-friendly interface.

## Features

### Item Search

Users can search for an item by:

* Item code
<p align="center">
  <img src="Screenshots/SearchByItemCodeScreen.png">
</p>

* Full item description
<p align="center">
  <img src="Screenshots/Full_ItemDescriptionScreen.png">
</p>

* Partial item description
<p align="center">
  <img src="Screenshots/Partial_ItemDescriptionScreen.png">
</p>

If multiple matching items are found, the results are displayed in a DataGridView, allowing the user to select the desired item by double-clicking it.

Before double-click 
<p align="center">
  <img src="Screenshots/UnselectedID.png">
</p>

After 
<p align="center">
  <img src="Screenshots/DoubleClickSelectScreen.png">
</p>

After selecting an item, you can choose one of the following functions via the buttons below:
<p align="center">
  <img src="Screenshots/MenuScreenshot.png">
</p>
Depending on the choice the following information can be displayed:

#### Total Inventory(General Stock of chosen product button)

Displays the total quantity available across all warehouse locations.
<p align="center">
  <img src="Screenshots/Total_InventoryScreen.png">
</p>

#### Inventory by Location(Entirety of stock of chosen product separated by warehouses/locations button)

Displays stock quantities grouped by warehouse location.
<p align="center">
  <img src="Screenshots/InventoryByLocationScreen.png">
</p>

#### Detailed Inventory(Stock of chosen product in each location with specific storage details button)

Displays stock quantities by:

* Location
* Shelf
* Bin
<p align="center">
  <img src="Screenshots/DetailedInventoryScreen.png">
</p>
This allows users to identify the exact storage position of an item.

### General Inventory

Displays a complete inventory list containing:

* Item Code
* Item Description
* Quantity
<p align="center">
  <img src="Screenshots/GeneralStockScreen.png">
</p>
The quantity shown represents the total stock available across all warehouse locations.

### Reorder Report

Displays all items with stock levels below their Safety Stock Level.
<p align="center">
  <img src="Screenshots/LowStockProductsScreen.png">
</p>
The report helps identify products that require replenishment before stock shortages occur.

For each item, the following information is displayed:

* Item Code
* Description
* Current Quantity
* Safety Stock Level

## Technologies Used

* C#
* Windows Forms
* SQL Server
* ADO.NET
* DataGridView
* AdventureWorks2022 Database https://learn.microsoft.com/en-us/sql/samples/adventureworks-install-configure?view=sql-server-ver17&tabs=ssms (AdventureWorks2022.bak)
* SQL Server Managment Studio


## Application Structure

The application is divided into separate forms:

### Main Menu

Provides access to all system functions.

### Item Search Form

Allows users to search for items and view inventory information.

### General Inventory Form

Displays all inventory items and stock quantities.

### Reorder Report Form

Displays products that need to be reordered.

## Learning Objectives

This project demonstrates:

* Database connectivity using ADO.NET
* SQL query execution
* Windows Forms development
* DataGridView data presentation
* Inventory management concepts
* User interface design

## Author

Argyris Leakos
