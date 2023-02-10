using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in hur lång är ditt låt. T.ex. 3 min & 50 sek ==> 3 50 ");
        int min = Convert.ToInt32(Console.ReadLine());
        int sek = Convert.ToInt32(Console.ReadLine());

        if (min >= 2 && min <= 4)
        {
            if (min >= 2 && sek >= 45 && sek < 60)
            {
                Console.WriteLine("Din låt får spelas på radiostatinen");
            }
            else if (min <= 4 && sek <= 20)
            {
                Console.WriteLine("Din låt får spelas på radiostatinen");
            }
            else
            {
                Console.WriteLine("Din låt får tyvär inte spelas på radiostatinen");
            }
        }
        else
        {
            Console.WriteLine("Din låt får tyvär inte spelas på radiostatinen");
        }
    }
}