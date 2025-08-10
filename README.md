# 📝 NotesUser_Project

A simple yet secure Windows Forms application for managing users and notes, built using C#, ADO.NET, and SQL Server.

---

## 📌 Features

- 🔐 Secure user registration & login with SHA-256 hashing
- 👤 Admin and regular user roles (IsAdmin)
- ✏️ Add, update, delete users
- 🔄 Change password with validation
- 🧾 View current user info using a custom UserControl
- 🧩 Modular architecture with 3 layers:
  - Data Layer
  - Business Layer
  - Presentation Layer

---

## 🧱 Technologies & Concepts

| Category         | Details                                 |
|------------------|------------------------------------------|
| 💻 Language       | C# (.NET Framework – Windows Forms)      |
| 🛢️ Database       | SQL Server, ADO.NET, Stored Procedures   |
| 🔐 Security       | Password Hashing (SHA-256)               |
| 🧠 Architecture   | 3-Tier (Data, Business, UI)              |
| 🧰 Used Concepts  | User Controls, ErrorProvider, ContextMenuStrip, SendBack with Events |

---

## 🧩 Structure

```
NotesUser_Project/
├── NotesUserApp/             → UI Layer (Forms)
├── NUA_UserBusiness/         → Business Logic Layer
├── NUA_UserData/             → ADO.NET + Stored Procedures
├── NUA_Security/             → SHA-256 Hashing Logic
└── SQL Scripts/              → (optional) contains stored procedures
```

---

## 🔐 Admin Access

- The app supports role-based access (IsAdmin)
- Only admins can:
  - Add new users
  - Delete users
- Regular users can:
  - View their own info
  - Change password

---

## 🧪 Demo Accounts

| Role   | Username | Password  |
|--------|----------|-----------|
| Admin  | admin    | admin123  |
| User   | testuser | test123   |


---

## 📸 Screenshots

<img width="600" height="600" alt="NoteUser" src="https://github.com/user-attachments/assets/de83b39d-9553-47e0-ab2d-c6b52d205329" />

<img width="889" height="674" alt="NoteUser1" src="https://github.com/user-attachments/assets/8e46e59a-1f84-49e8-8528-77857e9820fd" />

<img width="830" height="468" alt="NoteUser3" src="https://github.com/user-attachments/assets/5fef92d1-fd48-4bce-a707-2d16c244f119" />

<img width="908" height="616" alt="NoteUser2" src="https://github.com/user-attachments/assets/ba1f8c21-04f4-4553-9d2a-5470287dff16" />

<img width="780" height="613" alt="NoteUser4" src="https://github.com/user-attachments/assets/713b563a-ab8e-4d7e-a113-1b112080c12e" />




---

## 🚀 Getting Started

### Requirements:

- Visual Studio
- SQL Server
- .NET Framework 4.7.2 or above

### Run the App:

1. Clone the repository
2. Create a SQL Server database and run the stored procedures
3. Update the connection string in `clsDataAccessSettings`
4. Build and run the solution

---

## 🤝 Contribution

This project was developed entirely by **Aziza Abdel Hamid Diab** as a self-practice project to demonstrate knowledge in:

- ADO.NET
- User authentication & hashing
- Event-driven programming
- Desktop application design with Windows Forms

---

## 📎 Related Skills

- Object-Oriented Programming
- Event Handling (SendBack)
- DataGridView manipulation
- Error handling and validation
- Custom User Controls

---

## 📂 License

This project is open source and available under the MIT License.

---

## 🔗 Author

- 💼 [Aziza Abdel Hamid Diab](https://www.linkedin.com/in/azizadiab)
- 🧑‍💻 [GitHub Profile](https://github.com/azizadiab)
