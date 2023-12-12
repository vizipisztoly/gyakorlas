//A derékszögő háromszög két befogója 15 és 20 egység, számold ki az átfogóját!

//int a = 15;
//int b = 20;
//double c = Math.Sqrt(a ^ 2 + b ^ 2);

//Console.WriteLine("A háromszög melynek befogói a következőek, {0} és {1} egység\n" +
//    "Ennek a derékszögű háromszögnek a befogója {2}", a, b, Math.Round(c, 2));

//Console.WriteLine("A háromszög melynek befogói a következőek, " + a + " és " + b + " egység\n" +
//    "Ennek a derékszögű háromszögnek a befogója " + Math.Round(c, 2));

//Console.WriteLine($"A háromszög melynek befogói a következőek, {a} és {b} egység\n" +
//    $"Ennek a derékszögű háromszögnek a befogója {Math.Round(c, 2)}");

//Hónapos feladat

//Console.WriteLine("Hónapos feladat!");
//Console.WriteLine("Hanyadik hónapnak a hosszára vagy kíváncsi?");
//int honapSzam = int.Parse(Console.ReadLine());
//switch (honapSzam)
//{
//    case 1 | 3 | 5 | 7 | 8 | 10 | 12:           //ALTgr+ W --> | < Ezeka jelek egyenlőek a vaggyal "or"
//        Console.WriteLine("Ez a hónap 31 napos");
//        break;
//    case 2:
//        Console.WriteLine("Ez a hónap 28 napos");
//        break;

//    case 4:
//    case 6:
//    case 9:
//    case 11:
//        Console.WriteLine("Ez a hónapos 30 napos");
//        break;
//    default: 
//        Console.WriteLine("Nincs ilyen hónapo");
//        break;
//}

//Array feladat

using System.Linq;

int[] hajoTomegek = new int[20]; //Indexelésük a 0-ról indul [1,2,3], hivatkozoka 2. elemre akkor 1-et kell írni
var rnd = new Random();
for (int i = 0; i < 20; i++)
{
    hajoTomegek[i] = rnd.Next(1000, 10001);  //rnd.Next(x, y) --> x - minimum értéke, ez is benne van a véletlenben
                                             //y -- > maximum értéke, az y érték már nem szerepel benne, de az y-1 még igen
}

//a)
//I.m.o.
for (int i = 0; i < 20; i++)         //hajoTomegek.Length --> 20, mivel 20 elemből áll a tömb
{
    if (hajoTomegek[i] > 9300)
    {
        Console.WriteLine("Volt olyan jármű ami nehéznek számít");
        break; //--> Ha volt ilyen eset, akkor kíratta, majd LEÁLLÍTOTTA a for ciklust
    }
}

//II.m.o.
bool nehezJarmu = false;
for (int i = 0; i < 20; i++)
{
    if (hajoTomegek[i] > 9300)
    {
        nehezJarmu = true;
    }
}
if (nehezJarmu)
{
    Console.WriteLine("Volt olyan jármű ami nehéznek számít");
}

//b)
int nehezJarmuvekSzama = 0;
for (int i = 0;i < 20; i++)
{
    if (hajoTomegek[i] > 9300)
    {
        nehezJarmuvekSzama++;
    }
}
Console.WriteLine($"{nehezJarmuvekSzama}db nehéz jármű volt");

//c)

//I.m.o.
int jarmuvekTomege = hajoTomegek.Sum();     //Sum() --> Összeadja 
Console.WriteLine($"A járművek össztömege {jarmuvekTomege}kg");

//II.m.o.
jarmuvekTomege = 0; //Visszaállítottam a változót 0-ra, nem létrehzotam!!!!!
for (int i = 0; i < 20 ; i++)
{
    jarmuvekTomege += hajoTomegek[i];       //x += y    hozzáadjuk x-hez y-t
}
Console.WriteLine($"A járművek össztömege {jarmuvekTomege}kg");

//d)
int nehezJarmuvekTomege = 0;
for (int i = 0; i < 20; i++)
{
    if (hajoTomegek[i] > 9300)
    {
        nehezJarmuvekTomege += hajoTomegek[i];       //x += y    hozzáadjuk x-hez y-t
    }
}
Console.WriteLine($"A nehéz járművek össztömege {nehezJarmuvekTomege}kg");