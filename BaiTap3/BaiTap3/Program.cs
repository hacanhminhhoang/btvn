using System;
class Program
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine();
        if (s == null)
        {
            Console.WriteLine("Chuoi khong doi xung");
            return;
        }
        string temp = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ')
            {
                temp += s[i];
            }
        }
        int left = 0;
        int right = temp.Length - 1;
        bool doiXung = true;
        while (left < right)
        {
            if (temp[left] != temp[right])
            {
                doiXung = false;
                break;
            }
            left++;
            right--;
        }

        if (doiXung)
            Console.WriteLine("Chuoi doi xung");
        else
            Console.WriteLine("Chuoi khong doi xung");
    }
}