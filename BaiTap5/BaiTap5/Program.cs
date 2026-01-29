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
        if (arr == null || arr.Length == 0)
        {
            Console.WriteLine("Mang rong hoac null, khong xu ly.");
            return;
        }
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine($"Gia tri lon nhat la: {max}");
        Console.WriteLine("Ha Canh Minh Hoang. Msv: 2415053122219");
    }
}