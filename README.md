# 🎓 Student Record Management System

A simple full-stack web application built using **ASP.NET Core Web API**, **SQL Server**, and **HTML/CSS/JavaScript**.  
This project performs full CRUD operations (Create, Read, Update, Delete) with a responsive frontend connected via REST API.

---

## 🚀 Features

- ➕ Add new student records
- 📋 View all students
- ✏️ Edit/Update student information
- ❌ Delete student records
- 🔍 Real-time data fetching using API
- ✔️ Basic form validation
- 🎨 Clean and simple UI with CSS styling

---

## 🛠️ Technologies Used

### Frontend:
- HTML5
- CSS3
- JavaScript (Fetch API)

### Backend:
- ASP.NET Core Web API
- Entity Framework Core

### Database:
- SQL Server

---

## 📁 Project Structure


wwwroot/
│── dashboard.html
Controllers/
│── StudentsController.cs
Models/
│── Student.cs
Data/
│── AppDbContext.cs
Program.cs
appsettings.json
📡 API Endpoints
Method	Endpoint	Description
GET	/api/students	Get all students
GET	/api/students/{id}	Get single student
POST	/api/students	Add new student
PUT	/api/students/{id}	Update student
DELETE	/api/students/{id}	Delete student
📸 Screenshots:
<img width="1902" height="949" alt="11" src="https://github.com/user-attachments/assets/cca2a80c-6a29-4703-a4a3-7c8b5347a0c4" />
<img width="1911" height="832" alt="77" src="https://github.com/user-attachments/assets/c030e12c-8a0f-4b6f-ae0c-60e20b280e6c" />
<img width="1873" height="843" alt="66" src="https://github.com/user-attachments/assets/eb783311-47c4-4385-8c74-a39f95713d34" />
<img width="1912" height="928" alt="55" src="https://github.com/user-attachments/assets/851e4df2-6314-4c98-a705-3c6dbf9566b9" />
<img width="1906" height="916" alt="44" src="https://github.com/user-attachments/assets/8c1ea2ab-69f6-432d-9dc6-c9af804f2a93" />
<img width="1899" height="888" alt="33" src="https://github.com/user-attachments/assets/6d8e938b-645b-4dbf-b9ef-823239352e8e" />
<img width="1912" height="925" alt="22" src="https://github.com/user-attachments/assets/275e2100-73e6-4f21-b3a6-e32db4c4e8fe" />
✅ Validation Rules
All fields are required
Marks must be between 0–100
Semester must be valid number
No empty submissions allowed
👨‍💻 Developer
Name: MUHAMMAD ABDULLAH
Roll No: 2504637
Course: Web TRCHNOLOGY / ASP.NET Core
