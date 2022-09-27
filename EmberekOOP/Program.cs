using EmberekOOP;

Ember e1 = new Ember("Gipsz Jakab", "2003-3-17", "Budapest");
Ember e2 = new Ember("Teszt Elek", "1974-10-3", "Veszprém");
Ember e3 = new Ember("Kovács István", "2000-1-1", "Debrecen");
Emberek ek1 = new Emberek(new Ember[] {e1, e2, e3, e3, e3, e3});
Console.WriteLine(ek1);
try
{
    Emberek ek2 = new Emberek("emberek.txt");
    Console.WriteLine(ek2);
}
catch (FileNotFoundException )
{
    Console.WriteLine("Az emberek.txt fájl nem található");
}