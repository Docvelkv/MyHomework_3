// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

void Dist3D(double Ax, double Ay, double Az, double Bx, double By, double Bz) {
    double res = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2)), 2);
    Console.Write($"Расстояние между двумя точками в трёхмерном пространстве: {res}");
}

double OutPosition (string num) {
    Console.Write(num);
    double.TryParse(Console.ReadLine(), out double pos);    // нет исключений, всегда выводит 
    return pos;                                             // число (0, если введено не число)
}

Console.Clear();
double Ax = OutPosition("Введите координату Ax: ");         // ввод осуществляется согласно национальным
double Ay = OutPosition("Введите координату Ay: ");         // настройкиам системы (в русском языке,
double Az = OutPosition("Введите координату Az: ");         // десятичные дроби через запятую)
double Bx = OutPosition("Введите координату Bx: ");
double By = OutPosition("Введите координату By: ");
double Bz = OutPosition("Введите координату Bz: ");
Console.Clear();
Console.Write($"Координаты А ({Ax}; {Ay}; {Az}). Координааты В ({Bx}; {By}; {Bz}). ");
Dist3D(Ax, Ay, Az, Bx, By, Bz);                             // результат округляется до сотых долей