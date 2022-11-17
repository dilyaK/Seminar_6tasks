//Напишите программу, которая найдёт точку пересечения двух 
//прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0,5; -0.5)


void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
}

double x, y;

double[] Line1 = new double[2];
double[] Line2 = new double[2];

Console.WriteLine("Enter the coordinates value for k1 and b1: ");
FillArray(Line1);
Console.WriteLine("Enter the coordinates value for k2 and b2: ");
FillArray(Line2);

if(Line1[0] == Line2[0]) 
{
    Console.WriteLine("No intersection points");
}
else
{
    x=(Line1[1] - Line2[1])/(Line2[0]-Line1[0]);
    y=Line1[0]*x + Line1[1];
    Console.WriteLine($"The common points coordinates : x={x} and y={y}");
}
