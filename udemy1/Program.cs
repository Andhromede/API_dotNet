// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;


string AreYouPlayingBanjo(string name)
{
    bool result = name.StartsWith("r");

    if (result)
    {
        return ("Your are playing banjo !");
    }
    else
    {
        return ("Your are not playing banjo !");
    }
}

Console.Write("quel est votre nom ? ");                     // prompt en JS
string name = Console.ReadLine();                           // pour lire la ligne précédente
Console.WriteLine(AreYouPlayingBanjo(name));                // console.log en js
