namespace Healthbar;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //var name = "Arthur"
        //string name = "Arthur"
        //int age = 15;
        //bool isAlive = true;
        //float health = 100.0f;
        //double mana = 100.0;

        //Console.WriteLine(name);
        //Console.WriteLine(age);
        //Console.WriteLine(isAlive);
        //Console.WriteLine(health);
        //Console.WriteLine(mana);

        int life = 10;

        while (life > 0)
        {
            Console.Clear();
            ShowLife(life);
           

            Console.WriteLine();
            Console.WriteLine("Press ENTER to take damage");
            Console.ReadKey();

            life--;
        }
       
        Console.Clear();
        ShowLife(life);

        Console.WriteLine("\nGAME OVER");
    }
    
    static void ShowLife (int life)
    {
        Console.Write("HP: ");

        for (int i = 0; i < 10; i++)
        {
            if (i < life)
            {
                Console.Write("▓");
            }
            else
            {
                Console.Write("░");
            }
        }

        Console.WriteLine(" " + life + "/10");
    }
}
