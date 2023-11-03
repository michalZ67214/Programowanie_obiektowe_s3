// main

Zadanie1();

//Zadanie2();

//Zadanie3();

//Zadanie4();

//Zadanie5();

//Zadanie6();

//Zadanie7();

// koniec main



// metody
static void Zadanie1()
{
    double a = DoubleInput("a");
    double b = DoubleInput("b");
    double c = DoubleInput("c");

    double delta, x1, x2;

    if (a == 0) Console.WriteLine("To nie jest rownanie kwadratowe");
    else
    {
        delta = (Math.Pow(b, 2)) - (4 * a * c);

        if (delta < 0) Console.WriteLine("Rownanie nie ma rozwiazan");
        else if(delta == 0)
        {
            x1 = (-b) / (2 * a);
            Console.WriteLine("Rownanie ma jedno rozwiazanie: \nx1 = " + x1);
        }
        else 
        {
            x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            x2 = (-b + Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("Rownanie ma dwa rozwiazania: ");
            Console.WriteLine("x1 = " + x1 + "\nx2 = " + x2);
        }
    }
}

// metoda do wczytywania danych z klawiatury
static double DoubleInput(string prompt)
{
    Console.Write($"Podaj wartosc {prompt}: ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

static void Zadanie2()
{
    Menu();
}

static void Menu()
{
    string next = "t";
    while (next == "t")
    {
        ViewMenu:
        Console.WriteLine(" === KALKULATOR === ");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Roznica");
        Console.WriteLine("3. Iloczyn");
        Console.WriteLine("4. Iloraz");
        Console.WriteLine("5. Potega");
        Console.WriteLine("6. Pierwiastek");
        Console.WriteLine("7. Funkcje trygonometryczne zadanego kata");
        Console.WriteLine("8. Koniec");
        Console.Write("Twoj wybor: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1: Total(); break;
            case 2: Difference(); break;
            case 3: ProductNumber(); break;
            case 4: QuotienNumber(); break;
            case 5: PotentiationNumber(); break;
            case 6: SquareNumber(); break;
            case 7: Trigonometry(); break;
            case 8: Close(); break;
            default:
                Console.WriteLine("Bledny wybor, sprobuj ponownie: ");
                goto ViewMenu;
                break;
        }

        Console.Write("Czy chcesz wrocic do menu? t/n: ");
        next = Console.ReadLine();
    }
}

static void Total()
{
    double a = DoubleInput("a");
    double b = DoubleInput("b");
    double wynik = a + b;

    Console.WriteLine($"{a} + {b} = {wynik}");
}

static void Difference()
{
    double a = DoubleInput("a");
    double b = DoubleInput("b");
    double wynik = a - b;

    Console.WriteLine($"{a} - {b} = {wynik}");
}

static void ProductNumber()
{
    double a = DoubleInput("a");
    double b = DoubleInput("b");
    double wynik = a * b;

    Console.WriteLine($"{a} * {b} = {wynik}");
}

static void QuotienNumber()
{
    double a = DoubleInput("a");
    double b = DoubleInput("b");

    if (b == 0) Console.WriteLine("Nie mozna dzielic przez 0");
    else
    {
        double wynik = a / b;
        Console.WriteLine($"{a} / {b} = {wynik}");
    }
}

static void PotentiationNumber()
{
    double a = DoubleInput("a");
    double b = DoubleInput("b");
    double wynik = Math.Pow(a, b);

    Console.WriteLine($"{a} ^ {b} = {wynik}");
}

static void SquareNumber()
{
    double a = DoubleInput("a");
    double wynik = Math.Sqrt(a);

    Console.WriteLine($"Pierwiastek z {a} = {wynik}");
}

static void Trigonometry()
{
    double a = DoubleInput("a");
    // konwersja na radiany
    double rad = (a * Math.PI) / 180;

    Console.WriteLine($"sin({a}) = {Math.Sin(rad)}");
    Console.WriteLine($"cos({a}) = {Math.Cos(rad)}");
    Console.WriteLine($"tg({a}) = {Math.Tan(rad)}");
    Console.WriteLine($"ctg({a}) = {Math.Cosh(rad)}");
}

static void Close()
{
    Console.WriteLine("Koniec programu");
    System.Environment.Exit(1);
}

static void Zadanie3()
{
    double[] array_ = new double[10];

    FillArray(array_);

    FromFirstToLastIndex(array_);

    FromLastToFirstIndex(array_);

    PrintOddIndex(array_);

    PrintEvenIndex(array_);
}

static void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Podaj liczbe rzeczywista nr {i+1}: ");
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
}

static void FromFirstToLastIndex(double[] arr)
{
    Console.WriteLine("\nWyswietlenie tablicy od pierwszego do ostatniego indeksu:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

static void FromLastToFirstIndex(double[] arr)
{
    Console.WriteLine("\nWyswietlenie tablicy od ostatniego do pierwszego indeksu:");
    for (int i = arr.Length-1; i >= 0; i--)
    {
        Console.WriteLine(arr[i]);
    }
}

static void PrintOddIndex(double[] arr)
{
    Console.WriteLine("\nWyswietlenie elementow tablicy o nieparzystych indeksach:");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i%2 != 0) Console.WriteLine(arr[i]);
    }
}

static void PrintEvenIndex(double[] arr)
{
    Console.WriteLine("\nWyswietlenie elementow tablicy o parzystych indeksach:");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0) Console.WriteLine(arr[i]);
    }
}

static void Zadanie4()
{
    double[] array_ = new double[10];

    FillArray(array_);

    SumOfElements(array_);

    ProductOfElements(array_);

    AvgOfElements(array_);

    MinOfElements(array_);

    MaxOfElements(array_);
}

static void SumOfElements(double[] arr)
{
    double sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    Console.WriteLine($"\nSuma elementow tablicy wynosi: {sum}");
}

static void ProductOfElements(double[] arr)
{
    double prod = 1;

    for (int i = 0; i < arr.Length; i++)
    {
        prod *= arr[i];
    }

    Console.WriteLine($"\nIloczyn elementow tablicy wynosi: {prod}");
}

static void AvgOfElements(double[] arr)
{
    double sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    Console.WriteLine($"\nSrednia elementow tablicy wynosi: {sum/arr.Length}");
}

static void MinOfElements(double[] arr)
{
    double min_ = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (min_ > arr[i]) min_ = arr[i];
    }

    Console.WriteLine($"\nMinimalny elementow tablicy: {min_}");
}

static void MaxOfElements(double[] arr)
{
    double max_ = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if(max_ < arr[i]) max_ = arr[i];
    }

    Console.WriteLine($"\nMaksymalny elementow tablicy: {max_}");
}

static void Zadanie5()
{
    for (int i = 20; i >= 0; i--)
    {
        if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19) continue;
        Console.WriteLine(i);
    }
}

static void Zadanie6()
{
    int number;

    while(true)
    {
        Console.Write($"Podaj liczbe calkowita: ");
        number = Convert.ToInt32(Console.ReadLine());
        if (number < 0) break;
    }
}

static void Zadanie7()
{
    Console.Write("Podaj ile liczb chcesz wprowadzic: ");
    int n = Convert.ToInt32(Console.ReadLine());

    double[] array_ = new double[n];

    FillArray(array_);

    BubbleSort(array_);

    Console.WriteLine("\nLiczby w tablicy po posortowaniu metoda babelkowa:");

    FromFirstToLastIndex(array_);
}

static void BubbleSort(double[] arr)
{
    double temp;

    for (int j = 0; j <= arr.Length - 2; j++)
    {
        for (int i = 0; i <= arr.Length - 2; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                temp = arr[i + 1];
                arr[i + 1] = arr[i];
                arr[i] = temp;
            }
        }
    }
}