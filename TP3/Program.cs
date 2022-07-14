using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;


namespace TP3.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();




            // Q1
            Api Weather1 = new Api();
            Console.WriteLine("What's the weather like in Morocco ? \n");
            City morocco = new City("morocco");
            Root weatherMorocco = Weather1.Request(morocco);
            Console.WriteLine(weatherMorocco.weather[0].main);

            // Q2
            Api Weather2 = new Api();
            Console.WriteLine("When will the sun rise and set today in Oslo* (in readable, UTC time)?");
            City oslo = new City("oslo");
            Root weatherOslo = Weather1.Request(oslo);
            Console.WriteLine(weatherOslo.sys.sunrise + "  -  " + weatherOslo.sys.sunset);

            // Q3
            Api Weather3 = new Api();
            Console.WriteLine("What’s the temperature in Jakarta* (in Celsius)?");
            City jakarta = new City("jakarta");
            Root weatherJakarta = Weather1.Request(jakarta);
            Console.WriteLine(weatherJakarta.wind.deg);

            // Q4
            Api Weather4 = new Api();
            Console.WriteLine("Where is it more windy, New-York*, Tokyo* or Paris*?");
            City tokyo = new City("tokyo");
            Root weatherTokyo = Weather1.Request(tokyo);
            double speedTokyo = weatherTokyo.wind.speed;
            City paris = new City("paris");
            Root weatherParis = Weather1.Request(paris);
            double speedParis = weatherParis.wind.speed;
            //City ny = new City("tokyo");
            //Root weatherNy = Weather1.Request(ny);
            //double speedNy = weatherNy.wind.speed;
            if (speedParis < speedTokyo)
            {
                Console.WriteLine("Tokyo");
            }
            else
            {
                Console.WriteLine("Paris");
            }

            // Q5
            Api Weather5 = new Api();
            Console.WriteLine("What is the humidity and pressure like in Kiev*, Moscow* and Berlin*?");
            City kiev = new City("kiev");
            Root weatherKiev = Weather1.Request(kiev);
            Console.WriteLine("Kiev : " + weatherKiev.main.humidity + " - " + weatherKiev.main.pressure);
            City moscow = new City("moscow");
            Root weatherMoscow = Weather1.Request(moscow);
            Console.WriteLine("Moscow : " + weatherMoscow.main.humidity + " - " + weatherMoscow.main.pressure);
            City berlin = new City("berlin");
            Root weatherBerlin = Weather1.Request(berlin);
            Console.WriteLine("Berlin : " + weatherBerlin.main.humidity + " - " + weatherBerlin.main.pressure);
            





        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
