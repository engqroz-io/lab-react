# Abstract Factory Design Pattern Implementation

This project demonstrates the Abstract Factory design pattern in C#, using a StarCraft-inspired theme where different races (Protoss, Terran, Zerg) build bases with unique coatings and energy systems.

## Overview

The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.

In this implementation:

- **IBaseFactory**: Abstract factory interface for creating bases.
- **ICoating**: Interface for base coatings.
- **IEnergy**: Interface for base energy sources.
- Concrete factories: `ProtossBaseFactory`, `TerranBaseFactory`, `ZergBaseFactory`
- Concrete products: Corresponding coating and energy classes for each race (e.g., `ProtossBaseCoating`, `TerranBaseEnergy`).

Each factory creates a complete base by instantiating the appropriate coating and energy objects, showcasing how the pattern encapsulates object creation logic.

## UML Diagram

```mermaid
classDiagram
    class IBaseFactory {
        <<interface>>
        +CreateBase()
    }
    class ICoating {
        <<interface>>
        +Composition()
    }
    class IEnergy {
        <<interface>>
        +Composition()
    }
    class ProtossBaseFactory {
        +CreateBase()
    }
    class ProtossBaseCoating {
        +Composition()
    }
    class ProtossBaseEnergy {
        +Composition()
    }
    class TerranBaseFactory {
        +CreateBase()
    }
    class TerranBaseCoating {
        +Composition()
    }
    class TerranBaseEnergy {
        +Composition()
    }
    class ZergBaseFactory {
        +CreateBase()
    }
    class ZergBaseCoating {
        +Composition()
    }
    class ZergBaseEnergy {
        +Composition()
    }
    ProtossBaseFactory ..|> IBaseFactory : implements
    ProtossBaseCoating ..|> ICoating : implements
    ProtossBaseEnergy ..|> IEnergy : implements
    TerranBaseFactory ..|> IBaseFactory : implements
    TerranBaseCoating ..|> ICoating : implements
    TerranBaseEnergy ..|> IEnergy : implements
    ZergBaseFactory ..|> IBaseFactory : implements
    ZergBaseCoating ..|> ICoating : implements
    ZergBaseEnergy ..|> IEnergy : implements
    ProtossBaseFactory --> ProtossBaseCoating : creates
    ProtossBaseFactory --> ProtossBaseEnergy : creates
    TerranBaseFactory --> TerranBaseCoating : creates
    TerranBaseFactory --> TerranBaseEnergy : creates
    ZergBaseFactory --> ZergBaseCoating : creates
    ZergBaseFactory --> ZergBaseEnergy : creates
```