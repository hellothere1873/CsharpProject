# Warehouse Inventory Management System

## Overview

This project is a warehouse inventory management application developed in C# and SQL Server. The system allows users to search inventory items, view stock levels, monitor inventory across warehouse locations, and identify products that require replenishment.

The application was designed to simplify inventory tracking and provide quick access to stock information through a user-friendly interface.

## Features

### Item Search

Users can search for an item by:

* Item code
* <img width="798" height="482" alt="image" src="https://github.com/user-attachments/assets/329d5419-b638-4c96-b86f-8461167b7be3" />

* Full item description
* Partial item description

If multiple matching items are found, the results are displayed in a DataGridView, allowing the user to select the desired item.

After selecting an item, the following information can be displayed:

#### Total Inventory

Displays the total quantity available across all warehouse locations.

#### Inventory by Location

Displays stock quantities grouped by warehouse location.

#### Detailed Inventory

Displays stock quantities by:

* Location
* Shelf
* Bin

This allows users to identify the exact storage position of an item.

### General Inventory

Displays a complete inventory list containing:

* Item Code
* Item Description
* Quantity

The quantity shown represents the total stock available across all warehouse locations.

### Reorder Report

Displays all items with stock levels below their Safety Stock Level.

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
