# CSharp-Advanced-Delegates

## 🚀 Overview
This repository contains three C# projects that demonstrate advanced concepts of **Delegates**, **Anonymous Methods**, **Lambda Expressions**, **Multicast Delegates**, **Func/Action/Predicate**, **Events**, and **Covariance/Contravariance**. Each project showcases how these concepts can be applied to real-world applications.

---

## 🎓 Student Grading System
### Description
The **Student Grading System** is a console-based application built in **C#** to evaluate student performance using delegates. The project showcases the practical use of **Func, Action, and Predicate** to process and analyze student grades efficiently.

### ⭐ Features
- **Student Data Management:** Add students and enter their grades.
- **Grade Calculation:** Compute students' average grades dynamically.
- **Pass/Fail Evaluation:** Determine students' results based on predefined grading criteria.
- **Flexible Delegates:** Uses **Func, Action, and Predicate** for efficient grade processing.
- **Console-Based Interface:** Simple and interactive user experience.

### 🔧 Technologies Used
- **C#**
- **.NET Console Application**
- **Delegates (Func, Action, Predicate)**

### 🗂 Project Structure
- `Program.cs` – Main entry point of the application.
- `Student.cs` – Represents student data including name, grades.
- `GradeProcessor.cs` – Implements delegate-based grade processing logic.

---

# 🌡️ Temperature Sensor System

## Description

The **Temperature Sensor System** is a real-time console-based application that simulates a temperature monitoring system using two different approaches:

- **Observer Pattern (Old Version)**
- **Publish/Subscribe Pattern (Refactored Version)**

Both versions allow users to set temperature thresholds and trigger alarms when limits are exceeded.

## ⭐ Features

- **Temperature Monitoring**: Users can input temperature readings dynamically.
- **Alarm System**: Triggers an alarm if the temperature exceeds a set threshold.
- **Real-time Display**: Shows live temperature updates.
- **Event-driven Architecture** (Observer Pattern) and **Decoupled Messaging** (Publish/Subscribe Pattern).

## 🔧 Technologies Used

- **C#**
- **.NET Console Application**
- **Events & Delegates** (Old Version - Observer Pattern)
- **Publish/Subscribe Pattern** (New Version - Refactored)

### 🗂 Project Structure

#### Observer Pattern Version
- `Program.cs`  
- `Sensor.cs`  
- `TempArgs.cs`  
- `Display.cs`  
- `Alarm.cs`  

#### Publish/Subscribe Version (Refactored)
- `Program.cs`  
- `Sensor.cs`  
- `TempArgs.cs`  
- `Display.cs`  
- `Alarm.cs`  
- `Broker.cs`  

---

## 📖 Topics Covered

This repository demonstrates key programming concepts, including:

- **Observer Pattern (Before Update) & Publish/Subscribe Pattern (After Update):** Implementing a decoupled event-driven architecture.

- **Delegates in C#:**
  - **Func:** Used to calculate student averages dynamically.
  - **Predicate:** Determines whether a student passes or fails.
  - **Action:** Displays formatted student results.

- **Events & Event Handling (Before Update):**
  - **EventHandler:** Used to manage temperature changes.
  - **Custom Event Arguments:** Passing temperature values through events.

- **Publish/Subscribe Pattern (After Update):**
  - **Broker-based message distribution:** Decoupling publishers and subscribers.
  - **Flexible and extensible subscription model.**

- **Data Processing:** Efficient handling of student grades and temperature readings.

- **Console Application Development:** Creating user-friendly CLI applications.
- 
---

## 🚀 Learning Journey
This repository is part of my **C# and .NET learning journey**, focusing on **delegates, events, and console applications**. Through these projects, I have:

- Strengthened my understanding of **delegates and event-driven programming**.
- Implemented efficient logic using **functional programming and event handling**.
- Improved **code structure, modularity, and reusability**.

These projects are practical exercises in applying **C# delegates, events, and functional programming** to real-world scenarios.

---

## 📩 Contact  
For any questions, suggestions, or collaboration opportunities, feel free to connect with me on **[LinkedIn](https://www.linkedin.com/in/ziad-ghoraba-developer/)**.

---

**💡 Developed as a learning project to explore and implement C# Delegates and Events effectively.**
