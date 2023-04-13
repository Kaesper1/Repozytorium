using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //int i = 0;
        //string file = @"start.txt";
        //string[] lines = File.ReadAllLines("start.txt");
        //foreach (string ln in lines)
        //{
        //    i++;
        //    Console.WriteLine(i + " " + ln);
        //}

        // zad 2



        string file = @"imiona.txt";
        string[] lines = File.ReadAllLines("imiona.txt");
        string k = "Imiona żenskie: ";
        string m = "Imiona męskie: ";
        foreach (string ln in lines)
        {
            if (ln[ln.Length - 1] == 'a')
            {
                k += ln + " ";

            }
            else
            {
                m += ln + " ";

            }
        }
        Console.WriteLine(k);
        Console.WriteLine(m);

        Console.WriteLine("Hello, World!");
        int i = 0;
        string file1 = @"licby.txt";
        string[] lines1 = File.ReadAllLines("liczby.txt");
        foreach (string ln in lines1)
        {

            Console.WriteLine(ln);


        }
    }


    }

