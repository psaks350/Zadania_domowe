Console.WriteLine("Podaj swoje imię:");
var name = Console.ReadLine();
Console.WriteLine("Hello " + name);
Console.WriteLine();

/**************************************************************/

int result = 5 + 9;
Console.WriteLine(result);
Console.WriteLine();

/**************************************************************/

int number = 10;
float money = 3.14f;
string text = "Hello World";
bool isLogged = true;
char myChar = 'A';
decimal price = 9.99m;

Console.WriteLine("number: " + number);
Console.WriteLine("money: " + money);
Console.WriteLine("text: " + text);
Console.WriteLine("isLogged: " + isLogged);
Console.WriteLine("myChar: " + myChar);
Console.WriteLine("price: " + price);
Console.WriteLine();

/**************************************************************/

string myAge = "Age: ";
int wifeAge = 18;
string result2 = myAge + wifeAge;
Console.WriteLine(result);
Console.WriteLine();

//Wniosek: W C#, nie możemy bezpośrednio dodawać wartości typu string i int.
//Musimy najpierw przekonwertować wartość int na string za pomocą metody ToString(), a następnie możemy ją dodać do string.
//Wynik zostanie wyświetlony w konsoli jako "Age: 18".

/**************************************************************/

bool isTrue = true;
bool isFalse = false;
bool isReallyTrue = true;

bool and = isTrue && isFalse;
bool or = isTrue || isReallyTrue;
bool negative = !isFalse;

Console.WriteLine("and: " + and);
Console.WriteLine("or: " + or);
Console.WriteLine("negative: " + negative);
Console.WriteLine();

/**************************************************************/

int a = 5;
int b = 12;

int add = a + b;
int sub = a - b;
int div = a / b;
int mul = a * b;
int mod = a % b;

Console.WriteLine("add: " + add);
Console.WriteLine("sub: " + sub);
Console.WriteLine("div: " + div);
Console.WriteLine("mul: " + mul);
Console.WriteLine("mod: " + mod);
Console.WriteLine();

/**************************************************************/

int n1 = 10;
int n2 = 20;

if (n1 > n2)
{
    Console.WriteLine("n1 jest większe od n2");
}
else if (n1 < n2)
{
    Console.WriteLine("n2 jest większe od n1");
}
else
{
    Console.WriteLine("n1 jest równe n2");
}
Console.WriteLine();

/**************************************************************/

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("C#");
}

int counter = 0;
while (counter < 10)
{
    Console.WriteLine("C#");
    counter++;
}
Console.WriteLine();

/**************************************************************/

int n = 10;

for (int i = 0; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " - Parzysta");
    }
    else
    {
        Console.WriteLine(i + " - Nieparzysta");
    }
}
Console.WriteLine();

/**************************************************************/

int nn = 5;

for (int i = 1; i <= nn; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
Console.WriteLine();

/**************************************************************/



int exam = 57;

if (exam >= 0 && exam <= 39)
{
    Console.WriteLine("Ocena Niedostateczna");
}
else if (exam >= 40 && exam <= 54)
{
    Console.WriteLine("Ocena Dopuszczająca");
}
else if (exam >= 55 && exam <= 69)
{
    Console.WriteLine("Ocena Dostateczna");
}
else if (exam >= 70 && exam <= 84)
{
    Console.WriteLine("Ocena Dobra");
}
else if (exam >= 85 && exam <= 98)
{
    Console.WriteLine("Ocena Bardzo Dobra");
}
else if (exam >= 99 && exam <= 100)
{
    Console.WriteLine("Ocena Celująca");
}
else
{
    Console.WriteLine("Wartość poza zakresem");
}

Console.WriteLine();

/**************************************************************/

string[] colors = new string[4] { "niebieski", "zielony", "czerwony", "żółty" };

Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
Console.WriteLine("Mój ostatni kolor to: " + colors[colors.Length - 1]);

Console.WriteLine();

/**************************************************************/

int[] numbers = new int[10] { 5, 8, 13, 2, 9, 7, 4, 11, 6, 3 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Liczba: " + numbers[i]);
}

Console.WriteLine();

foreach (int numberr in numbers)
{
    Console.WriteLine("Liczba: " + numberr);
}

Console.WriteLine();

int counterr = 0;
while (counterr < numbers.Length)
{
    Console.WriteLine("Liczba: " + numbers[counterr]);
    counterr++;
}

Console.WriteLine();

/**************************************************************/




List<string> fruits = new List<string>() { "Pomidor", "Jabłko", "Marchewka", "Banan" };

foreach (string fruit in fruits)
{
    Console.Write(fruit);
    if (fruit != fruits[fruits.Count - 1])
    {
        Console.Write(", ");
    }
}
Console.WriteLine();

fruits.Remove("Pomidor");
fruits.RemoveAt(fruits.Count - 1);

foreach (string fruit in fruits)
{
    Console.Write(fruit);
    if (fruit != fruits[fruits.Count - 1])
    {
        Console.Write(", ");
    }
}
Console.WriteLine();

