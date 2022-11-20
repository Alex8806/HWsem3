// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.WriteLine("Введите число с двумя или более цифр");
string s = Console.ReadLine();
int i = Math.Abs(Convert.ToInt32(s));// проверка на число
//s = i.ToString(); // убираем минус если есть

if (s[0] == '-')
{
    s = s.Substring(1); // второй вариант убрать минус
}
i = s.Length - 1;
if (s.Length >= 2)
{
    int j = 0;
    bool check = true;
    while (i > (s.Length - 1) / 2)
    {
        if (s[i] == s[j])
        {
            check = true;
        }
        else
        {
            check = false;
            break;
        }
        j++;
        i--;
    }

    if (check == true)
    {
        System.Console.WriteLine($"Число {s} - полиндром");
    }
    else
    {
        System.Console.WriteLine($"Число {s} - НЕ полиндром");
    }
}

else
{
    System.Console.WriteLine("вы ввели некоректное число");
}
