using System;
class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();
        if (s == null)
        {
            Console.WriteLine("So tu: 0");
            return;
        }
        s = s.Trim();

        if (s.Length == 0)
        {
            Console.WriteLine("So tu: 0");
            return;
        }
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("So tu trong chuoi: " + words.Length);
    }
}