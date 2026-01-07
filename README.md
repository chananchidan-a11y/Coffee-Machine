# Coffee Machine 

ชื่อ: น.ส.ชนัญชิดา นามมูลตรี
รายวิชา: Object-Oriented Programming
ภาษา: C# (Console Application)

# รายละเอียดโปรแกรม
โปรแกรมจำลองเครื่องชงกาแฟร้อนอัตโนมัติ  
ผู้ใช้สามารถเลือกเครื่องดื่มได้ 4 เมนู ได้แก่
- กาแฟดำ
- มอคค่า
- ลาเต้
- ช็อกโกแลต

ระบบจะตรวจสอบวัตถุดิบก่อนชง  
หากวัตถุดิบไม่เพียงพอ ระบบจะเติมวัตถุดิบให้อัตโนมัติ

## Class Diagram

```mermaid
classDiagram
    class IngredientStock {
        +int Water
        +int Coffee
        +int Milk
        +int Chocolate
        +Refill()
    }

    class Drink {
        +string Name
        +int Water
        +int Coffee
        +int Milk
        +int Chocolate
    }

    class CoffeeMachine {
        -IngredientStock stock
        +CanMake(Drink)
        +MakeDrink(Drink)
    }

    Program --> CoffeeMachine
    CoffeeMachine --> IngredientStock
    CoffeeMachine --> Drink
