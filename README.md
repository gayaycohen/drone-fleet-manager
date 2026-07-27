# Drone Fleet Management System

A C# Windows Forms system for managing delivery drones, surveillance drones, missions, battery levels, and charging stations.

## Main Features

- Add delivery and surveillance drones
- Add charging stations
- Assign missions manually or automatically
- Automatically select the available drone with the highest battery level
- Monitor battery levels and display low-battery warnings
- Charge drones using charging stations
- Complete missions using a timer
- Move and delete selected objects
- Save and load the fleet state
- Display drones and stations on a graphical map

## Object-Oriented Design

The project demonstrates:

- Abstract classes
- Inheritance
- Polymorphism
- Method overriding
- Generic collections with `List<T>`
- Events and delegates
- Event-driven programming
- Custom drawing with `System.Drawing`
- File serialization

## Class Structure

```text
FleetEntity
├── Drone
│ ├── DeliveryDrone
│ └── SurveillanceDrone
└── ChargingStation
```

## Technologies

- C#
- .NET
- Windows Forms
- System.Drawing
- Visual Studio

## How to Run

1. Open the .sln file in Visual Studio.
2. Build the solution.
3. Run the project.

## Author
Developed independently by Gaia Cohen as an academic Object-Oriented Programming project.
