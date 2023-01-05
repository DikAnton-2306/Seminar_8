// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// 4. Метод замены первой строки на последнюю и наоборот
void ChangeRows(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int temp = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0) - 1, i];
        arr[arr.GetLength(0) - 1, i] = temp;
    }
}

// 3. Метод выводит массив в терминал
void ShowMatrix(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write("[" + arr[i, j] + "] ");
        }
        System.Console.WriteLine();
    }
}

// 2. Метод заполняет массив рандомно
void ArrayWithRundomNumbers(int[,] arr, int leftRange, int rightRange)
{
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }
}

// 1. Метод спрашивает пользователя ввести число
int EnterNumber(string message)
{
    System.Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

// ================================================================================================

// 1. Пользователь вводит размер массива и границы цифр
int rows = EnterNumber("Введите кол-во строк: ");
int columns = EnterNumber("Введите кол-во столбцов: ");

int min = EnterNumber("Укажите левую границу цифр: ");
int max = EnterNumber("Укажите правую границу цифр: ");

// 2. Создаётся двумерный массив
int [,] matrix = new int[rows, columns];
ArrayWithRundomNumbers(matrix, min, max);

// 3. Вывод массива в терминал 
ShowMatrix(matrix);

// Вывод пустой строки для визуального разделения массивов
System.Console.WriteLine();

// 4. Замена первой строки на последнюю и наоборот
ChangeRows(matrix);

// 5. Вывод изменённого массива в терминал 
ShowMatrix(matrix);