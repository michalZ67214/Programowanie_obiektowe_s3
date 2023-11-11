using zadania;

// main

//Zadanie1a();
//Zadanie1b();
//Zadanie1c();
//Zadanie1d();
//Zadanie1f();
//Zadanie1g();
Zadanie2();

// koniec main

static void Zadanie1a()
{
    Person p1 = new Person("Jan", "Kowalski", 30);
    p1.View();

    Console.WriteLine("Informacje o ksiazce:\n");

    Book b1 = new Book("Tytul1234", p1, "26.01.2023");
    b1.View();
}

static void Zadanie1b()
{
    Person p1 = new Person("Jan", "Kowalski", 30);
    Person p2 = new Person("Marek", "Mostowiak", 32);

    Book b1 = new Book("Tytul111", p1, "26.01.2023");
    Book b2 = new Book("Tytul222", p1, "26.02.2023");
    Book b3 = new Book("Tytul333", p2, "26.03.2023");
    Book b4 = new Book("Tytul444", p1, "26.04.2023");
    Book b5 = new Book("Tytul555", p2, "26.05.2023");

    Reader reader1 = new Reader("Jan", "Nowak", 25, new Book[2]{b1, b2});
    Reader reader2 = new Reader("Janusz", "Nowak", 26, new Book[3]{b3, b4, b5});

    Console.WriteLine("Ksiazki przeczytane przez czytelnika 1:");
    reader1.ViewBook();
    Console.WriteLine();

    Console.WriteLine("Ksiazki przeczytane przez czytelnika 2:");
    reader2.ViewBook();
}

static void Zadanie1c()
{
    Person p1 = new Person("Marek", "Mostowiak", 32);

    Book b1 = new Book("Tytul111", p1, "26.01.2023");
    Book b2 = new Book("Tytul222", p1, "26.02.2023");

    Reader reader1 = new Reader("Jan", "Nowak", 25, new Book[2] { b1, b2 });
    reader1.View();
}

static void Zadanie1d()
{
    Person p1 = new Person("Marek", "Mostowiak", 32);

    Book b1 = new Book("Tytul111", p1, "26.01.2023");
    Book b2 = new Book("Tytul222", p1, "26.02.2023");

    Person o = new Reader("Jan", "Nowak", 25, new Book[2] { b1, b2 });
    o.View();
}

static void Zadanie1f()
{
    Person p1 = new Person("Marek", "Mostowiak", 32);

    Book b1 = new Book("Tytul111", p1, "26.01.2023");
    Book b2 = new Book("Tytul222", p1, "26.02.2023");
    Book b3 = new Book("Tytul333", p1, "26.03.2023");
    Book b4 = new Book("Tytul444", p1, "26.04.2023");

    Reviewer r1 = new Reviewer("Jan", "Nowak", 25, new Book[2] { b1, b2 });
    Reviewer r2 = new Reviewer("Jan", "Kowalski", 22, new Book[2] { b3, b4 });

    Console.WriteLine("Ksiazki ocenione przez recenzenta nr 1:");
    r1.Wypisz();

    Console.WriteLine();

    Console.WriteLine("Ksiazki ocenione przez recenzenta nr 2:");
    r2.Wypisz();
}

static void Zadanie1g()
{
    Person author = new Person("Marek", "Mostowiak", 32);

    Book b1 = new Book("Tytul111", author, "26.01.2023");
    Book b2 = new Book("Tytul222", author, "26.02.2023");
    Book b3 = new Book("Tytul333", author, "26.03.2023");
    Book b4 = new Book("Tytul444", author, "26.04.2023");

    Reader p1 = new Reader("Jan", "Nowak", 25, new Book[2] { b1, b2 });
    Reviewer p2 = new Reviewer("Jan", "Kowalski", 22, new Book[2] { b3, b4 });

    List<Person> osoby = new List<Person>();
    osoby.Add(p1);
    osoby.Add(p2);

    foreach (Person person in osoby)
    {
        person.View();
        Console.WriteLine("\n---\n");
    }
}

static void Zadanie2()
{
    Samochod s1 = new Samochod("Audi", "Q8", "sedan", "srebrny", 2020, 250000);
    Samochod s2 = new Samochod("Citroen", "C3", "crossover", "zielony", 2015, 300000);

    SamochodOsobowy so1 = new SamochodOsobowy("Audi", "A8", "Catchback", "czerwony",
        2019, 230000, 3, 2, 5);

    Console.WriteLine("Pierwszy samochod:");
    s1.View();
    Console.WriteLine();

    Console.WriteLine("Drugi samochod:");
    s2.View();
    Console.WriteLine();

    Console.WriteLine("Trzeci samochod:");
    so1.View();
    Console.WriteLine();
}