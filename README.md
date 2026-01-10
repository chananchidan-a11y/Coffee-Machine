- ชื่อ: น.ส.ชนัญชิดา นามมูลตรี  
- รหัสนักศึกษา: 683450186-6  
- Project: Automatic Coffee Machine  

## Description
This project is a C# console application that simulates an automatic hot coffee machine.
Users can select drinks, check ingredient availability, and refill ingredients.
The system runs continuously until the user exits the program.

## Drinks Menu
- Black Coffee
- Mocha
- Latte
- Chocolate

## Ingredients
- Water
- Coffee
- Milk
- Chocolate

## Class Diagram
```mermaid
classDiagram
    class CoffeeMachine {
        -int water
        -int coffee
        -int milk
        -int chocolate
        +CoffeeMachine()
        +MakeBlackCoffee()
        +MakeMocha()
        +MakeLatte()
        +MakeChocolate()
        +ShowStock()
        +Refill()
    }

    class Program {
        +Main()
    }

    Program --> CoffeeMachine
