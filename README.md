# lawyerApp
🏛 LawyerApp
LawyerApp is a desktop application built with C# Windows Forms and Microsoft SQL Server, designed to help lawyers efficiently manage legal entities, cases, and related data. It provides a straightforward interface for storing, retrieving, and updating case information in a relational database.

✅ Key Features
Data Management

CRUD functionality for legal cases, clients, and related records.

Secure storage and retrieval using MS SQL Server.

User Interface

Built with C# Windows Forms for a responsive, desktop-native experience.

Intuitive dialogs and forms for seamless data entry and editing.

⚙️ Tech Stack
Frontend/UI: C# · Windows Forms

Backend / Data Layer: ADO.NET integration with

Database: Microsoft SQL Server

🛠 Getting Started
Prerequisites

.NET Framework (version suitable for Windows Forms)

Microsoft SQL Server (local or remote instance)

Setup

Clone the repo:

bash
Kopyala
Düzenle
git clone https://github.com/kadirTPL/lawyerApp.git
cd lawyerApp
Create the database and tables (adjust script as needed):

sql
Kopyala
Düzenle
CREATE DATABASE LawyerAppDB;
/* Run the SQL script from `SQLProject/` to create tables */
Update your connection string in App.config or code to point at LawyerAppDB.

Run the App

Open the solution (*.sln) in Visual Studio.

Build and launch the application.

Explore the menus/forms to add, edit, and delete records in the database.

📈 Current Status
 Basic CRUD operations implemented

 Functional SQL database integration

 Future improvements:

Advanced search & filtering

User authentication layer

Document generation/export

Dashboard with analytics and case summaries

🌟 Roadmap
Feature	Status
Search and filter cases	Planned
Export data to PDF/Word	Planned
User login with roles	Planned
Audit trail and history	Under Consideration
