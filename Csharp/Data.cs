
using System.Data;

Console.WriteLine("Data e Hora: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

// Program.cs
Console.WriteLine("Qual seu nome?");
Console.WriteLine("Qual sua idade?");

string name = Console.ReadLine();
int idade = int.Parse(Console.ReadLine());
Console.WriteLine($"{name} {idade}");
