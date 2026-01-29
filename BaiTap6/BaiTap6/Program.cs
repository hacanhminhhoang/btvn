using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap so phan tu n: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("So n khong hop le.");
            return;
        }
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            int.TryParse(Console.ReadLine(), out arr[i]);
        }
        if (arr == null)
        {
            Console.WriteLine("So phan tu chan: 0 (Do mang null)");
            return;
        }

        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine($"So phan tu chan trong mang: {count}");
        Console.WriteLine("Ha Canh Minh Hoang. Msv: 2415053122219");
    }
}