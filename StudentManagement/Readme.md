# Student Management System (.NET MVC)

## 📌 Overview

This is a simple **ASP.NET Core MVC** application built to understand and practice the **MVC architecture**, routing, services, and clean separation of concerns using **static data**.

The project intentionally avoids databases and external UI frameworks to focus on **core fundamentals** such as Controllers, Services, ViewModels, and Razor Views.

---

## 🛠 Tech Stack

* ASP.NET Core MVC
* C#
* Razor Views
* Plain CSS
* Static In‑Memory Data (No Database)

---

## ✨ Features

* Display a list of students
* Filter students by course (server‑side, GET request)
* View detailed information of a student
* Highlight top‑performing students
* Clean MVC folder structure
* Service layer for business logic
* Strongly‑typed ViewModels (no ViewBag for main data)
* Basic error handling

---

## 📂 Folder Structure

```
StudentManagement
│
├── Controllers
│   └── StudentsController.cs
│
├── Models
│   └── Student.cs
│
├── ViewModels
│   └── StudentListViewModel.cs
│
├── Services
│   ├── Interfaces
│   │   └── IStudentService.cs
│   └── StudentService.cs
│
├── Data
│   └── StudentData.cs
│
├── Views
│   ├── Shared
│   │   └── _Layout.cshtml
│   └── Students
│       ├── Index.cshtml
│       ├── Details.cshtml
│       └── _StudentRow.cshtml
│
├── wwwroot
│   └── css
│       └── site.css
│
└── Program.cs
```

---

## ▶️ How to Run the Project

1. Clone the repository
2. Open the solution in **Visual Studio**
3. Run the project (`Ctrl + F5`)
4. Open the browser and navigate to:

    * `/Students` – View all students
    * `/Students?course=BCA` – Filter students by course

---

## 🧠 Design Decisions

* **ViewModels** are used instead of `ViewBag` for better type safety and scalability
* **Services** handle business logic to keep controllers thin
* Filtering is implemented using **HTTP GET** for bookmarkable and testable URLs
* Plain CSS is used to demonstrate styling fundamentals
* Swagger is intentionally not added because this is an MVC (server‑rendered) application, not a Web API

---

## 🚀 Future Improvements

* Replace static data with DbContext and database
* Add pagination and sorting
* Add search functionality
* Improve UI styling
* Add authentication and authorization

---

## 🎯 Learning Goals

* Understand MVC architecture and request flow
* Proper separation of concerns
* Server‑side routing and filtering
* Clean, maintainable project structure
