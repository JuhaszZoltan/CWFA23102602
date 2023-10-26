using NepessegCLI;
using System.Text;

List<Orszag> orszagok = new();
using StreamReader sr = new(@"..\..\..\src\adatok-utf8.txt", Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) orszagok.Add(new(sr.ReadLine()));

Console.WriteLine("3. feladat:");
Console.WriteLine($"A beolvasott országok száma: {orszagok.Count}.");

Console.WriteLine("4. feladat:");
int f4 = orszagok.Single(o => o.Orszagnev == "Kína").Nepsuruseg;
Console.WriteLine($"Kína népsűrűsége: {f4} fő/km^2.");

Console.WriteLine("5. feladat:");
int f5 = orszagok.Single(o => o.Orszagnev == "Kína").Nepesseg
    - orszagok.Single(o => o.Orszagnev == "India").Nepesseg;
Console.WriteLine($"Kína lakossága {f5} fővel volt több.");

Console.WriteLine("6. feladat:");
var f6 = orszagok.OrderByDescending(o => o.Nepesseg).ToList()[2];
Console.WriteLine($"A 3. legnépesebb orszég: " +
    $"{f6.Orszagnev}, lakossága: {f6.Nepesseg} fő.");

Console.WriteLine("7. feladat:");
Console.WriteLine("A következő országok több, mint 30%-a a fővárosban lakik:");
foreach (var o in orszagok)
    if (o.Koncentralt)
        Console.WriteLine($"\t{o.Orszagnev} ({o.Fovaros})");