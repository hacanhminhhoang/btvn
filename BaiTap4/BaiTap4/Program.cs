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
            Console.Write($"Nhap phan tu thu {i+1}: ");
            int.TryParse(Console.ReadLine(), out arr[i]);
        }
        if (arr == null)
        {
            Console.WriteLine("Loi: Mang chua duoc khoi tao!");
            return;
        }

        long sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {   
            sum += arr[i];
        }

        Console.WriteLine($"Tong cac phan tu: {sum}");
        Console.WriteLine("Ha Canh Minh Hoang. Msv: 2415053122219");
    }
}