﻿// Задача 24
/* Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.*/

Console.WriteLine("Введите целое число A");/* Вывод числа на экран.*/

try /* Блок обработки исключений. Если ввели некорректные данные, то смотри строку 40*/
{
    int A = Convert.ToInt32(Console.ReadLine());/* A- число целого типа, которое 
                                                   будет вводиться пользователем.*/
    int sum = 0; /* Переменная, в которую будем складывать сумму чисел от 1 до А.*/

    if (A >= 1) /* Если вводимое число больше единицы, то...*/
    {
        for (int i = 1; i <= A; i++) /* Вводим переменную (i)- это наш счётчик. 
                                        До тех пор, пока счётчик (i) не сравняется с  вводимым числом (А),
                                        будем увеличивать (i) на единицу и каждый раз...*/
        {
            sum = sum + i; /* сумму будем увеличивать на значение счётчика,
                              т.е. сначала +1, потом +2, потом +3 и т.д.*/
        }
        Console.WriteLine(sum); /* В ответ пойдёт сумма от последнего действия.*/

    }

    if (A < 1) /* Если вводимое число меньше единицы, то...*/
    {
        for (int i = 1; i >= A; i--) /* Вводим переменную (i)- это наш счётчик. 
                                        До тех пор, пока счётчик (i) не сравняется с  вводимым числом (А),
                                        будем уменьшать (i) на единицу и каждый раз...*/
        {
            sum = sum + i; /* к сумме будем прибавлять  значение счётчика,
                              т.е. сначала +1, потом 0, потом -1 и т.д.*/
        }
        Console.WriteLine(sum); /* В ответ пойдёт сумма от последнего действия.*/
    }

}
catch /* Окончание блока обработки исключений.*/
{
    Console.WriteLine("Неправильный ввод значения. Введите целое число.");
}
