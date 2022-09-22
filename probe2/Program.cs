// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



//ввод цифр и запись их в массив
double[,] InputNumbers()
{
    double[,] numberArray = new double[2, 2];
    for (int i = 0; i < numberArray.GetLength(0); i++)
    {

        for (int j = 0; j < numberArray.GetLength(1); j++)
        {
            if (j == 0)
            {
                Console.Write($"Введи b{i + 1} для {i + 1}-ого уравнения y = k{i + 1} * x + b{i + 1}: ");
                numberArray[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.Write($"Введи k{i + 1} для {i + 1}-ого уравнения y = k{i + 1} * x + b{i + 1}: ");
                numberArray[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    return numberArray;


}


double[] computeIntersectionPoints(double[,] array) // нахождение точек пересечения
{
    double[] crossPoint = new double[2];
    crossPoint[0] = (array[1, 0] - array[0, 0]) / (array[0, 1] - array[1, 1]);
    crossPoint[1] = (crossPoint[0] - array[0, 0]) / array[0, 1];
    return crossPoint;

}

void IntersectionPoints(double[,] array)   //расчеты
{
    if (array[0, 0] == array[1, 0] && array[1, 0] == array[1, 1])
    {
        Console.Write($"b1 = {array[0, 0]}, k1 = {array[0, 1]}, b2 = {array[1, 0]}, k2 = {array[1, 1]} -> Прямые совпадают ");
    }
    else if (array[0, 1] == array[1, 1] && array[0, 0] != array[1, 0])
    {
        Console.Write($"b1 = {array[0, 0]}, k1 = {array[0, 1]}, b2 = {array[1, 0]}, k2 = {array[1, 1]} -> Прямые параллельны ");
    }
    else
    {
        double[] crossPoint = computeIntersectionPoints(array);
        Console.Write($"b1 = {array[0, 0]}, k1 = {array[0, 1]}, b2 = {array[1, 0]}, k2 = {array[1, 1]} -> ({crossPoint[0]}, {crossPoint[1]})");
    }

}

try
{

    double[,] numbers = InputNumbers();
    IntersectionPoints(numbers);

}
catch
{
    Console.Write("Ошибка: не верно введены данные.");
}

