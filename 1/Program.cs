// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine ("Введите трехзначное число");

int num = Convert.ToInt32 ( Console.ReadLine());

if (99 < num && num < 1000)
{
    
    string stringNumber = Convert.ToString(num);
    Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
}

else
    Console.WriteLine (" Вы ввели некорректное число. Введите трёхзначное число.");