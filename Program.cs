// See https://aka.ms/new-console-template for more information
using System;

using OOPS;
using OOPS.overload;
using OOPS.partialpart;
using OOPS.encapsulation;
using OOPS.inheritance;
using OOPS.Interface;
using OOPS.indexer;

// Console.WriteLine("Hello, World!");
// Customer obj = new Customer();
// obj.displayData();
//fields calling

// Console.WriteLine();

// FunOverLoad obj1 = new FunOverLoad();
// obj1.setName("Thapa");

// FunOverLoad obj2 = new FunOverLoad();
// obj2.setName("Samip", "Thapa");

// FunOverLoad obj3 = new FunOverLoad();
// obj3.setName("Samip", "Bikram", "Thapa");

// obj1.displayName();
// obj2.displayName();
// obj3.displayName();

// PartialPart obj4 = new PartialPart();
// obj4.displayData1();
// obj4.displayData2();

// Encapsulation obj5 = new Encapsulation(5);
// obj5.MySquare();

// Father objfather = new Father();
// objfather.FatherMethod();
//Here Child object can access both class methods
// Child objchild = new Child();
// objchild.FatherMethod();
// objchild.ChildMethod();

// IShape[] shapes = new IShape[3];
// shapes[0] = new Circle(5);
// shapes[1] = new Square(4);
// shapes[2] = new Triangle(4, 5);
// foreach (IShape shape in shapes)
// {
//     shape.Display();
//     Console.WriteLine("Area: " + shape.CalculateArea());
//     Console.WriteLine();
// }
// Console.ReadLine();

MyCollection collection = new MyCollection();
collection[0] = "Hello";
string value = collection[0];
Console.WriteLine(value);  // Output: Hello
