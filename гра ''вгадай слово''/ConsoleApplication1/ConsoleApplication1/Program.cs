using System;

class BP
{
    static void Main()
    {
        Random rand = new Random();
        int secret = rand.Next(1, 11);
        int gusca = 0;
        while (secret != gusca)
        {
            gusca = Convert.ToInt32(Console.ReadLine());
            if (secret < gusca)
            {
                Console.WriteLine("Неправильно! секрт менший за введене число");
            }
            if (secret > gusca)
            {
                Console.WriteLine("Неправильно! секрт більший за введене число");
            }
        }
            Console.WriteLine("Правильно!" + "Секретом був "+secret);
            Console.ReadKey();
    }
}


