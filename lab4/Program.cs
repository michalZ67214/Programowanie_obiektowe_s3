﻿using zadania;

//Zadanie1();
//Zadanie2();
Zadanie3();

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
    Console.WriteLine("Osoba nr 1:");

    Person p1 = new Person();

    p1.SetFirstName("Jan");
    p1.SetLastName("Kowalski");
    p1.SetPesel("10302476452", true);

    Console.WriteLine(p1.GetFullName());
    Console.WriteLine(p1.GetAge());
    Console.WriteLine(p1.GetGender());

    if(p1.CanGoAloneToHome()) Console.WriteLine("Moze isc sam do domu"); 
    else Console.WriteLine("Nie moze isc sam do domu");

    Console.WriteLine();

    Console.WriteLine("Student nr 1:");

    Student s1 = new Student();

    s1.SetFirstName("Maciej");
    s1.SetLastName("Nowak");
    s1.SetPesel("12322443114", true);
    s1.SetSchool("Szkola podstawowa nr 1");
    s1.SetCanGoHomeAlone(true);

    Console.WriteLine(s1.GetFullName());
    Console.WriteLine(s1.GetAge());
    Console.WriteLine(s1.GetGender());
    Console.WriteLine(s1.GetEducationInfo());

    if (s1.CanGoAloneToHome()) Console.WriteLine("Moze isc sam do domu");
    else Console.WriteLine("Nie moze isc sam do domu");

    Console.WriteLine();

    Console.WriteLine("Student nr 2:");

    Student s2 = new Student();

    s2.SetFirstName("Kamil");
    s2.SetLastName("Wojcik");
    s2.SetPesel("11252933291", true);
    s2.SetSchool("Szkola podstawowa nr 1");
    s2.SetCanGoHomeAlone(false);

    Console.WriteLine(s2.GetFullName());
    Console.WriteLine(s2.GetAge());
    Console.WriteLine(s2.GetGender());
    Console.WriteLine(s2.GetEducationInfo());

    if (s2.CanGoAloneToHome()) Console.WriteLine("Moze isc sam do domu");
    else Console.WriteLine("Nie moze isc sam do domu");

    Console.WriteLine();

    Console.WriteLine("Nauczyciel nr 1:");

    Teacher t1 = new Teacher();

    t1.SetFirstName("Wojciech");
    t1.SetLastName("Kowalczyk");
    t1.SetPesel("95021656352", false);
    t1.setTytulNaukowy("Magister");

    Console.WriteLine(t1.GetFullName());
    Console.WriteLine(t1.GetAge());
    Console.WriteLine(t1.GetGender());
    Console.WriteLine(t1.GetEducationInfo());

    List<Student> PodwladniUczniowie = new List<Student>();
    PodwladniUczniowie.Add(s1);
    PodwladniUczniowie.Add(s2);

    t1.setPodwladniUczniowie(PodwladniUczniowie);

    Console.WriteLine();
    Console.WriteLine("Uczniowie ktorzy moga isc sami do domu: ");

    t1.WhichStudentCanGoHomeAlone(new DateTime(2023, 12, 4));
}

static void Zadanie3()
{
    Osoba o1 = new Osoba("Jan", "Kowalski");
    Osoba o2 = new Osoba("Maciej", "Nowak");
    Osoba o3 = new Osoba("Kamil", "Kowalczyk");

    List<Osoba> osoby = new List<Osoba>();
    osoby.Add(o1);
    osoby.Add(o2);
    osoby.Add(o3);

    Osoba.WypiszOsoby(osoby);
    Osoba.PosortujOsobyPoNazwisku(ref osoby);
    Console.WriteLine();
    Osoba.WypiszOsoby(osoby);

    Console.WriteLine();
    Console.WriteLine("Student: ");
    Student_3 s1 = new Student_3("Jan", "Wojcik", "WSIiZ", "II", "2022", "3");
    Console.WriteLine(s1.WypiszPelnaNazweIUczelnie());

    Console.WriteLine();
    Console.WriteLine("Student WSIiZ: ");
    StudentWSIiZ sW1 = new StudentWSIiZ("Jan", "Wojcik", "WSIiZ", "II", "2022", "3", "w23142");
    Console.WriteLine(sW1.WypiszPelnaNazweIUczelnie());
}