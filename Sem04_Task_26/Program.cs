﻿// Задача 26.
/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.*/

Console.WriteLine("Введите число a(для ввода дробных чисел используйте запятую)");

try /* Блок обработки исключений.*/
{
    decimal a = Convert.ToDecimal(Console.ReadLine());
    /*Оператор decimal дает возможность вводить дробные числа.
    Decimal- Тип значения представляет десятичные числа в
    диапазоне от плюс 79,228,162,514,264,337,593,543,950,335
    до минус 79,228,162,514,264,337,593,543,950,335. */

    ulong b = 0; /* Вводим переменную (b) для того,
                    чтобы потом присвоить ей значения переменной (а) в формате ulong.
                    ulong: хранит целое число от 0 до 18 446 744 073 709 551 615.*/

    int count = 0; /* Счётчик, для дальнейшего деления нашего числа на 10.
                      Сколько раз разделим (либо умножим), столько цифр в числе.*/

    // Первый блок

    if (a < 0) a = a * -1; /* Если число (а) меньше нуля, то умножим его
                              на (-1) и получится положительное число.*/

    // Второй блок

    if (a == 0) /* Если число (а) равно нулю, то...*/
    {
        Console.WriteLine("1 цифра в заданном числе"); /* В ответ пойдет это.*/
        return; /* Это возврат значения, чтобы программа не продолжала дальнейшие действия.*/
    }

    // Третий блок

    if (a >= 1) /* Если число (а) больше или равно (1), то...*/
    {
        while (Convert.ToDecimal(a) != Convert.ToUInt64(a)) /* Если ввели дробное число, то до тех пор,
                                                               пока оно не стало целым...*/
        {
            a = a * 10; /* будем умножать его на 10.*/
        }
        b = (ulong)a; /* Присвоим переменной (b) значение переменной (а) в формате (ulong).*/

        while (b >= 1) /* До тех пор, пока переменная (b) больше или равна (1)...*/
        {
            b = b / 10; /* будем делить (b) на 10.*/
            count++; /* и счётчик увеличивать на (1) после каждой итерации.*/
        }
    }

    // Четвёртый блок

    if (a > 0 & a < 1) /* Если число (а) больше нуля и меньше (1), то...*/
    {
        count = count + 1; /* Прибавили (1) потому, что в целой части стоит цифра (0),
                              которая, уже, пойдёт в ответ,
                              но не будет входить в количество итераций в данном цикле.*/

        while (Convert.ToDecimal(a) != Convert.ToUInt64(a)) /* Если ввели дробное число, то до тех пор,
                                                               пока оно не стало целым...*/
        {
            a = a * 10; /* будем умножать его на 10.*/
            count++;    /* и счётчик увеличивать на (1) после каждой итерации.*/
        }
    }
    Console.WriteLine($"{count} цифр в заданном числе"); /* В ответ пойдёт последнее показание
                                                            счётчика.*/
}

catch /* Окончание блока обработки исключений.*/
{
    Console.WriteLine("Неправильный ввод значения. Введите число.");
}