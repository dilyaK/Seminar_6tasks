// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел меньше 0 ввел пользователь.
//1,-7,567, 89, 223 -> 3
//0,7,8,-2,-2 -> 2

Console.Write("Enter numbers using spaces: "); // fill the array using spaces
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
int result = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        result++;
    }
}
 
Console.WriteLine($"Quantity of elements less than 0: {result}");