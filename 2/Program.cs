// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine ("Введите число");

int num = Convert.ToInt32 ( Console.ReadLine());

if (99 < num )
{
string stringNumber = Convert.ToString(num);
    Console.WriteLine("третья цифра этого числа -> " + stringNumber[2]);
}

else
Console.WriteLine ("В данном числе нет третьей цифры");