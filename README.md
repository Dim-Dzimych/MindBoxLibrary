# MindBoxLibrary
Completed Test Task

To insert my library to your project:
1) Create project and add my .dll file in project's folder
2) Enjoy well library :))

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
Дополнительно к работоспособности оценим:

- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

1) Have completed. Find in project
2) Can just create new 'Class', inherit from Shape
3) Make polymorphism. for example create 'List<Shape>' than initialize 'Circle' and 'Triangle'. Add these 2 Shape in list and via 'Foreach' call 'GetSquar'
4) Method 'IsRectangular'
