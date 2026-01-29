using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap mot cau: ");
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Chuoi null/rong -> Khong xu ly.");
            return;
        }

        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length == 0) return;
        string longestWord = words[0];

        for (int i = 1; i < words.Length; i++)
        {
            if (words[i].Length > longestWord.Length)
            {
                longestWord = words[i];
            }
        }
        Console.WriteLine($"Tu dai nhat la: '{longestWord}' (Do dai: {longestWord.Length})");
    }
}