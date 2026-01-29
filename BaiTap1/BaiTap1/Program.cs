using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap ho ten: ");
        string fullName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(fullName))
        {
            Console.WriteLine("Error: Ho ten khong hop le!");
            return;
        }
        fullName = fullName.Trim();
        string[] words = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i].ToLower();
            words[i] = char.ToUpper(word[0]) + word.Substring(1);
        }
        string normalizedName = string.Join(" ", words);

        Console.WriteLine("Ho ten sau khi chuan hoa: " + normalizedName);
    }
}