//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine ("Введите число дня недели от 1 до 7");

int day = Convert.ToInt32 ( Console.ReadLine());

switch (day)
{
case 1:
Console.WriteLine ("Понедельник рабочий день");
break;

case 2:
Console.WriteLine ("Вторник рабочий день");
break;

case 3:
Console.WriteLine ("Среда рабочий день");
break;

case 4:
Console.WriteLine ("Четверг рабочий день");
break;

case 5:
Console.WriteLine ("Пятница рабочий день, но уже почти)");
break;

case 6:
Console.WriteLine ("Суббота! Ура, выходной!");
break;

case 7:
Console.WriteLine ("Воскресенье! Ура, выходной!");
break;

default:
Console.WriteLine ("Вы ввели некорректное число. Введите число от 1 до 7.");
break;

}


    
    

