using System;

class Program
{
    static void Main()
    {
        int[] a = new int[10];
        Random r = new Random();

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = r.Next(-10, 10);
            Console.Write(a[i] + ", ");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Введите свое число: ");

        int num = int.Parse(Console.ReadLine());
        Ifs(a, num);
    }

    static void Ifs(int[] a, int b)
    {
        int c = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < b)
            {
                c++;
            }
        }

        Console.WriteLine(c);
    }
}