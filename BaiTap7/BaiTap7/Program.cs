using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap ho va ten: ");
        string fullName = Console.ReadLine();
        if (string.IsNullOrEmpty(fullName))
        {
            Console.WriteLine("Chuoi null hoac rong -> Khong tach.");
            return;
        }
        string[] words = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (words == null)
        {
            Console.WriteLine("Mang ket qua null -> Khong in.");
            return;
        }

        Console.WriteLine("Ket qua tach:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
        Console.WriteLine("Ha Canh Minh Hoang. Msv: 2415053122219");
    }
}