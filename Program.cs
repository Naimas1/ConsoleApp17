using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть число для перевірки:");
        int number = int.Parse(Console.ReadLine());

        bool isPalindrome = CheckPalindrome(number);

        Console.WriteLine($"Число {number} є паліндромом: {isPalindrome}");

        Console.ReadLine();
    }

    static bool CheckPalindrome(int number)
    {
        string numberString = number.ToString();
        int left = 0;
        int right = numberString.Length - 1;

        while (left < right)
        {
            if (numberString[left] != numberString[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
