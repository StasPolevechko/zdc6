/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

const int coefficient = 0;
const int constant = 1;
const int x_coord = 0;
const int y_coord = 1;
const int line1 = 1;
const int line2 = 2;

double[] lineData1 = InputLineDate(line1);
double[] lineData2 = InputLineDate(line2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($" точка пересечений уравнений y={lineData1[coefficient]} * x + {lineData1[constant]} и y={lineData2[coefficient]} * x + {lineData2[constant]}: ");
    Console.Write($"имеет координаты ({coord[x_coord]}, {coord[y_coord]})");
}

double Prompt(string message)
{
    System.Console.Write(message);
    string value = System.Console.ReadLine() ?? "";
    double result = Convert.ToDouble(value);
    return result;
}
double[] InputLineDate (int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[coefficient] = Prompt($"введите коэффициент для {numberOfLine} прямой >");
    lineData[constant] = Prompt($"введите константу для {numberOfLine} прямой >");
    return lineData;
}
double[] FindCoords(double[] lineDate1, double[] lineDate2)
{
    double[] coord = new double[2];
    coord[x_coord] = (lineData1[constant] - lineData2[constant]) / (lineData2[coefficient] - lineData1[coefficient]);
    coord[y_coord] = lineData1[constant] * coord[x_coord] + lineData1[constant];
    return coord;
}
bool ValidateLines(double[] lineData1, double[] liteData2)
{
    if (lineData1[coefficient] == lineData2[coefficient])
    {
        if (lineData1[constant] == lineData2[constant])
        {
            Console.WriteLine("прямые совпадают");
            return false;
        }
        else 
        {
            Console.WriteLine("прямые паралельны");
            return false;
        }
        
    }
    return true;
}