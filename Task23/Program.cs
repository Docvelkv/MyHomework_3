// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N. Усложнил: от 0,
// с десятичными дробями.

void CubeNumRange(double num) {
        Console.Write($"Кубы чисел в диапазоне от 0 до {num}: ");
        double temp;
        if (num > 0){
            for (double i = 0; i <= num; i = i + 0.1) {
            temp = Math.Pow(i, 3);
            Console.Write($"|{Math.Round(i, 1)} - {Math.Round(temp, 5)}| ");}
            Console.WriteLine("\n");}
        if (num <= 0){
            for (double i = 0; i >= num; i = i - 0.1) {
            temp = Math.Pow(i, 3);
            Console.Write($"|{Math.Round(i, 1)} - {Math.Round(temp, 5)}| ");}
            Console.WriteLine("\n");}}
        

Console.Clear();        
CubeNumRange(-5.2);
CubeNumRange(11.3);
CubeNumRange(-0.4);
CubeNumRange(0);
