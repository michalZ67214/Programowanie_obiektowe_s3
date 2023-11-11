using zadania;

// main
Zadanie1a();
// koniec main

static void Zadanie1a()
{
    // 1a
    Person p1 = new Person("Jan", "Kowalski", 30);
    p1.View();

    Console.WriteLine("Informacje o ksiazce:\n");

    Book b1 = new Book("Tytul1234", p1, "26.01.2023");
    b1.View();
}