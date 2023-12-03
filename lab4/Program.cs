using zadania;

//Zadanie1();
Zadanie2();

static void Zadanie1()
{
    List<Shape> figures = new List<Shape>();

    Rectangle rectangle = new Rectangle(0, 0, 12, 23, "Prostokat");
    Triangle triangle = new Triangle(0, 0, 12, 5, "Trojkat");
    Circle circle = new Circle(0, 0, 4, "Kolo");

    figures.Add(rectangle);
    figures.Add(triangle);
    figures.Add(circle);

    foreach (Shape shape in figures)
    {
        shape.Draw();
    }
}

static void Zadanie2()
{
    Console.WriteLine("zadanie 2");
}