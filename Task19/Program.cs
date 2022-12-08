// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// Усложнил задачу.

void PalinSearch(string str) {
    string newstr = str.Replace(" ", "");
    bool res = int.TryParse(newstr, out int num);                           // создаём логическую переменную да/нет
    int x = num, y = 0, temp = 0;                                           // временные переменные для расчётов
    if (res == true & x % 10 != 0) {                                        // условие: число целое и не оканчивается на 0
        for (int i = 0; x > 10; i++) {                                      // запускаем цикл
            temp = x % 10;
            y = (y + temp) * 10;
            x = x / 10;}
        y = y + x;                                                          // число перевернули
        if (num == y) Console.WriteLine($"Число {num} - палиндром.");       // сравниваем, выводим результат
        else Console.WriteLine($"Число {num} - не палиндром.");
    }
    else {
        char[] strAr = newstr.ToCharArray();                                // создаём массив символов из строки
        Array.Reverse(strAr);                                               // переворачиваем массив
        string str2 = new String(strAr);                                    // создаём новую строку
        if (newstr == str2) Console.WriteLine($"Выражение <{str}> - палиндром.");    // сравниваем, выводим результат
        else Console.WriteLine($"Выражение <{str}> - не палиндром.");
    }}

string str1 = "143676341";
PalinSearch(str1);

string str2 = "0324334230";
PalinSearch(str2);

string str3 = "A роза упала на лапу Aзора";     // Смена регистра - пока сложно.
PalinSearch(str3);                              // Вероятно надо использовать тип char

PalinSearch("а роза упала на лапу азора");