//Liskov Subtitution Principle (LSP)

using SOLID_L;

Shape rectangle = new Rectangle { Width = 5, Height = 4};
System.Console.WriteLine(rectangle.Area);

Shape square = new Square { SideLength = 45 };
System.Console.WriteLine(square.Area);
