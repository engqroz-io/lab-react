# Factory Method Design Pattern Implementation

This project demonstrates the Factory Method design pattern in C#, using a Mortal Kombat-inspired theme where characters are selected based on input strings.

## Overview 

The Factory Method pattern defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

In this implementation:

- **ICharacter**: Interface for character types.
- **LiuKang, Raiden, Scorpion, SubZero**: Concrete character classes implementing ICharacter.
- **FactoryMethod**: Factory class that creates character instances based on string input.

## UML Diagram

```mermaid
classDiagram
    class ICharacter {
        <<interface>>
        +Chosen() void
    }
    
    class LiuKang
    
    class Raiden
    
    class Scorpion
    
    class SubZero
    
    class FactoryMethod {
        +ChooseCharacter(character: string) ICharacter
    }
    
    ICharacter <|.. LiuKang
    ICharacter <|.. Raiden
    ICharacter <|.. Scorpion
    ICharacter <|.. SubZero
    
    FactoryMethod --> ICharacter
    
    note "Factory Method Pattern 
          Creates character instances based on input string"