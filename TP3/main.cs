using System;
using TP3.API;

namespace TP3
{
    class main
    {

    
    static void Main(string[] args)
    {


        // Q1
        Api Weather1 = new Api();
        Console.WriteLine("What's the weather like in Morocco ? \n");
        City morocco = new City("morocco");
        Root weatherMorocco = Weather1.Request(morocco);
        // Modifier la requete 
        Console.WriteLine(weatherMorocco.data.clouds);
    }
    }
}

