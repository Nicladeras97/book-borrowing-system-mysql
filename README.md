# 📚 Book Management System

## 📝 Description  
The **Book Management System** is a digital solution that streamlines the process of borrowing and returning books. It replaces the traditional manual method used by librarians, allowing for easier tracking of book availability, borrower activity, and automated notifications.

---

## 🚀 Features

- 🔍 **Book Search** by Title, Author, or Category (via Report Module)  
- 🔄 **Borrowing & Returning Process Tracking**  
- ➕ **Add, Edit, Delete**, and **Import Books** with downloadable import templates  
- 📊 **Comprehensive Book Reports**:
  - Inventory Report  
  - Borrowed Books Report  
  - Lost Books Report  
  - Damaged Books Report  
  - Overdue Books Report  
  - Books with Multiple Copies  
  - Borrowers Report  
- 📧 **Email Notifications**:
  - Sends real-time email updates for newly added books based on borrower preferences  
  - Sends reminders automatically for upcoming due dates and overdue books  

---

## 💻 System Requirements

```sh
- Microsoft Visual Studio 2022
- VB.NET 2022
- XAMPP (MySQL Database)
- MySQL Connector 9.2 (ODBC)
```

---

## ⚙️ Installation Guide

### 1️⃣ Download & Install Dependencies
- [ ] Install Microsoft Visual Studio 2022  
- [ ] Install **XAMPP** and enable the **MySQL** module  
- [ ] Download and install [MySQL Connector 9.2 (ODBC)](https://dev.mysql.com/downloads/connector/odbc/)  
  - Choose: Windows (x86, 64-bit), MSI Installer  

---

### 2️⃣ Clone the Repository

```sh
git clone https://github.com/Nicladeras97/book-borrowing-system-mysql.git
```

---

### 3️⃣ Set Up the Database

1. Launch **XAMPP** and start the **MySQL** module  
2. Open `phpMyAdmin` and create a new database (e.g., `book-borrowing`)  
3. Import the provided `.sql` file located in the project folder  

---

### 4️⃣ Configure ODBC Connection

1. Press `Windows + R`, type `odbcad32.exe`, and press Enter  
2. Go to the **System DSN** tab → Click **Add**  
3. Select **MySQL ODBC Driver** → Click **Finish**  
4. Enter the following details:  
   - **Data Source Name**: My SQL Connections  
   - **Server**: `localhost`  
   - **User**: `root`  
   - **Password**: *(leave blank)*  
   - **Database**: `book-borrowing`  
5. Click **Test** to verify the connection, then click **OK**  

---

### 5️⃣ Configure the Database Connection in Visual Studio

1. In Visual Studio, go to the **Tools** tab → Select **Connect to Database**  
2. Choose **Microsoft ODBC Data Source**  
3. Select **"Use user or system data source name"** and choose **My SQL Connections**  
4. Enter the **User** as `root`, test the connection, and click OK  

---

### 6️⃣ Run the Application

1. Open the solution file (`.sln`) in Visual Studio  
2. Build the solution using `Ctrl + Shift + B`  
3. Run the application using `F5`  

---

## 🙌 Credits

**Bachelor of Science in Computer Science (BSCS)**  
**College of Mary Immaculate – 2025**

- **Monica L. Cano** – Lead Developer  
  *(Database, Backend, Frontend)*  
- **Rhea Martin** – UI/UX Designer  
  *(Design, Frontend Assistance)*  
- **Kimberly Mae Jeresano** – Documentation  
  *(Thesis Papers and Reports)*  
- **April Joy Reyes** – Documentation & Backend Assistant  
  *(Thesis Papers, Backend Support)*  
- **Alyssa Pacunio** – Email Automation  
  *(Developed the automatic email system for borrower due date reminders)*
