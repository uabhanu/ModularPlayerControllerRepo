# 🎮 Modular Player Controller

**Project Name:** ModularPlayerController | **Status:** Implementation Phase | **Platform:** PC

---

## 💡 Overview
This project delivers a **modular, decoupled player movement system** built to professional standards. It proves the ability to implement reliable physics-based movement using Unity's `Rigidbody` and ensures full separation of input handling from movement logic.

This feature directly integrates with the **Singleton/FSM architecture** established in Project 1.

## 🧱 Core Architectural Concepts

### 1. Input Decoupling (Interface Pattern)
* **Implementation:** The **`IInputReceiver`** interface acts as a contract, allowing the `PlayerInputHandler` to send input data without ever knowing the concrete type of the `PlayerController`.
* **Benefit:** Enables swapping player control schemes (e.g., to an AI script) without changing the core input system.

### 2. Physics Reliability (`FixedUpdate` Loop)
* **Implementation:** All movement forces, velocity calculations, and jumps are performed inside Unity's **`FixedUpdate()`** lifecycle method.
* **Benefit:** Ensures physics calculations are accurate, reliable, and run independently of the game's frame rate.

## ⚙️ Technical Stack
| Category | Detail | Purpose |
| :--- | :--- | :--- |
| **Engine** | Unity 2023+ (Unity 6.2) | The base development environment. |
| **Language** | C# (DOT NET Standard 2.1) | Used for clean, object-oriented pattern implementation. |
| **Input** | Unity New Input System | Used for decoupled input mapping. |
| **Architecture** | Interface Pattern, Component Composition | Ensures modularity and separation of concerns (SRP). |

## 💾 Key Scripts
| Category | File Name | Purpose |
| :--- | :--- | :--- |
| **Interfaces (Decoupling)** | IInputReceiver.cs | Defines the C# Interface/Contract that decouples input reading from movement logic.
| **Player(Input)** | PlayerInputHandler.cs | Reads the Unity New Input System callbacks and sends decoupled signals to the Controller. |
| **Player(Logic)** | PlayerController.cs (Physics logic: Rigidbody, FixedUpdate) | Contains the physics logic, calculates movement/jump forces using a Rigidbody in FixedUpdate(). |

## 🗓️ Roadmap
| Status | Task | Feature Branch |
| :--- | :--- | :--- |
| ✅ | **Setup:** Repository creation and README setup. | `main` |
| 🚧 | **Decoupling Core:** Implement `IInputReceiver.cs` and core `PlayerController.cs`. | `feature/modular-player-controller` |
| ⬜ | **Input Integration:** Implement `PlayerInputHandler.cs` and test movement. | `feature/modular-player-controller` |
| ⬜ | **Polish:** Add simple jump and ground check logic. | `feature/modular-player-controller` |
