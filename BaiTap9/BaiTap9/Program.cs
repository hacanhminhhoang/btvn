using System;

class Program
{
    static void Main()
    {
        string[] data = { "Ha Canh Minh Hoang", null, "", "2415053122219", "   ", "C#" };
        Console.WriteLine("Mang du lieu: { \"Ha Canh Minh Hoang\", null, \"\", \"2415053122219\", \"   \", \"C#\" }");

        if (data == null) return;

        int count = 0;
        for (int i = 0; i < data.Length; i++)
        {
            if (!string.IsNullOrEmpty(data[i]))
            {
                count++;
            }
        }
        Console.WriteLine($"So phan tu hop le (khac null/rong): {count}");
    }
}