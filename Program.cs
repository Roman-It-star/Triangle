using System;

public class Triangle // Данный класс представляет собой треугольник с возможностью инициализации сторон

{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double a, double b, double c) // Конструктор для создания треугольника с заданными длинами сторон
    {
        SideA = a;
        SideB = b;
        SideC = c;
    }

    public Triangle(double lehgth) // Конструктор для создания равностороннего треугольника
    {
        SideA = lehgth;
        SideB = lehgth;
        SideC = lehgth;
    }

    public bool IsValid() // Метод для проверки валидности треугольника
    {
        return (SideA + SideB > SideC) && (SideA + SideB > SideC) && (SideB + SideC > SideA);
    }

    public double CalcuLatePerimeter() // Метод для расчета периметра
    {
        return SideA + SideB + SideC;
    }

    public double CalcuLateArea() // Метод для расчета площади с использованием формулы Герона
    {
        if (!IsValid()) return 0;
        double s = CalcuLatePerimeter() / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public void PrintSides() // Метод для вывода длин сторон на экран
    {
        Console.WriteLine($"Сторона А: {SideA}");
        Console.WriteLine($"Сторона B: {SideB}");
        Console.WriteLine($"Сторона C: {SideC}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Создание треугольника с заданными длинами сторон
        Triangle triangle1 = new Triangle(3, 4, 5);
        Console.WriteLine($"Периметр треугольника 1: {triangle1.CalcuLatePerimeter()}");
        Console.WriteLine($"Площадь треугольника 1: {triangle1.CalcuLateArea()}");
        triangle1.PrintSides();

        // Создание треугольника с длинами сторон, которые не образуют треугольник
        Triangle triangle2 = new Triangle(1, 1, 3);
        Console.WriteLine($"Треугольник 2 валиден: {triangle2.IsValid()}"); // Выведет на экран false

        // Создание равностороннего треугольника
        Triangle triangle3 = new Triangle(5);
        Console.WriteLine($"Периметр равностороннего треугольника 3: {triangle3.CalcuLatePerimeter()}");
        Console.WriteLine($"Площадь равностороннего треугольника 3: {triangle3.CalcuLateArea()}");
        triangle3.PrintSides();
    }
}