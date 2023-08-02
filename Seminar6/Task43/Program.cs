/* Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
int coefeicient = 0;
int constant = 1;
int coordX = 0;
int coordY = 1;
int line1 = 1;
int line2 = 2;
double[] lineData1 = InputLineData(line1);
double[] lineData2 = InputLineData(line2);
if (ValidateLines(lineData1,lineData2))
{
    double[] coord = FindCoords(lineData1,lineData2);
    Console.Write ($"Точка пересечения уравнений y = {lineData1[coefeicient]} * x + {lineData1[coefeicient]} и y = {lineData2[coefeicient]} * x + {lineData2[coefeicient]}");
        Console.WriteLine($" имеет координаты = ({coord[coordX]}, {coord[coordY]}) ");
}
double Prompt (string message)
{
Console.Write (message);
double result = Convert.ToDouble(Console.ReadLine());
return result;
}
double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double [2];
    lineData[coefeicient] = Prompt ($"Введите коэффициент для {numberOfLine} прямой >");
    lineData[constant] = Prompt ($"Введите константу для {numberOfLine} прямой >");
    return lineData;
}
double[] FindCoords(double[] lineData1,double[] lineData2)
{
    double[] coord = new double[2];
    coord[coordX] = (lineData1[constant] - lineData2[constant]) / (lineData2[coefeicient] - lineData1[coefeicient]);
    coord[coordY] = lineData1[constant] * coord[coordX] + lineData1[constant];
    return coord;
}
bool ValidateLines ()