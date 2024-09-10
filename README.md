# PROG-6212-POE-Part-1
Contract Monthly Claim System

# Contract Monthly Claim System (CMCS)

The **Contract Monthly Claim System (CMCS)** is a WPF-based application designed to streamline the submission, review, and approval process of monthly claims for Independent Contractor (IC) lecturers. The system provides an intuitive user interface where lecturers can submit claims, track statuses, and upload supporting documents, while Programme Coordinators and Academic Managers can review and approve the claims.

---

## Table of Contents
- [Project Overview](#project-overview)
- [Technologies](#technologies)
- [Setup and Installation](#setup-and-installation)
- [Usage](#usage)
- [Features](#features)
- [Assumptions and Constraints](#assumptions-and-constraints)
- [Future Enhancements](#future-enhancements)

---

## Project Overview

The CMCS application is built using the **.NET Core WPF framework** with **C#** to provide a user-friendly interface for handling lecturer claims. It follows the **MVVM (Model-View-ViewModel)** architecture to separate concerns and allow for scalable, maintainable code. The system consists of the following features:

- Claim submission by lecturers.
- Document upload for each claim.
- Claim status tracking (Pending, Approved, Rejected).
- Role-based features for Programme Coordinators and Academic Managers to approve/reject claims.

---

## Technologies

- **.NET Core (WPF)**
- **C#**
- **MVVM (Model-View-ViewModel) Architecture**
- **XAML** for UI design

---

## Setup and Installation

### Prerequisites
- **Visual Studio 2019/2022** or higher.
- **.NET Core SDK** (3.1 or later).
- **Windows OS** (WPF is not cross-platform).

### Steps to Install
1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-repository/CMCS_WPF.git
   ```

2. **Open the project** in **Visual Studio**.
   - Open **Visual Studio**.
   - Click **File > Open > Project/Solution**.
   - Browse to the cloned repository and select the `.sln` file.

3. **Build the project**:
   - Right-click the solution in **Solution Explorer** and select **Build**.

4. **Run the application**:
   - Press `F5` or click the **Run** button in Visual Studio.

---

## Usage

### Main Window
- Upon launching the application, you will see the **Main Dashboard** where lecturers can:
  - **Submit a new claim**.
  - **View previously submitted claims** with statuses (Pending, Approved, Rejected).
  
### Submit Claim Window
- Click the **Submit New Claim** button to open the claim submission form:
  - Enter **total hours worked**.
  - View the **hourly rate** (pre-set).
  - Automatically calculate the **total claim amount**.
  - **Upload supporting documents** (PDF, DOCX, XLSX).
  - Submit the claim for review.

### Logout
- Users can click **Logout** to close the application (or redirect to a login page if implemented).

---

## Features

- **Lecturer Role**:
  - Submit monthly claims by entering hours worked and uploading documents.
  - Track claim status (Pending, Approved, Rejected).
  
- **Programme Coordinator & Academic Manager Roles**:
  - Review and approve or reject claims.
  - See detailed claim and document information.

- **File Upload**:
  - Lecturers can upload **PDF**, **Word**, and **Excel** files to support their claims.

- **Dynamic Claim Loading**:
  - Claims are loaded dynamically when the user navigates through the system.

---

## Assumptions and Constraints

### Assumptions:
- The user (lecturer, coordinator, or manager) is logged in when the application is launched.
- The lecturer's hourly rate is predefined and cannot be changed by the user.
- Claims are reviewed based on supporting documents and hours worked.

### Constraints:
- The application is designed as a **WPF desktop application** and is not cross-platform.
- No database is connected in this version; data is manually loaded or can be connected via an external service.
- File uploads are limited to **PDF**, **Word**, and **Excel** formats.
  
---


## Future Enhancements

1. **Database Integration**:
   - Connect to a database (SQL Server or SQLite) to store and retrieve claims and user data dynamically.

2. **Authentication**:
   - Add a login system to authenticate users (Lecturers, Coordinators, and Managers) before accessing the system.

3. **Role-Based Navigation**:
   - Implement role-based access control, where different roles have different interfaces and features.

4. **Notifications**:
   - Add real-time notifications to inform users of claim status updates.

5. **REST API**:
   - Create a RESTful API backend to allow cross-platform or web-based access to the system.

---

### Contact
For any questions or support, feel free to contact [Dakalo Maumela] at [magnumtheprince@gmail.com].

---
