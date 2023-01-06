// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// 4. Метод считает, сколько раз в массиве встречается элемент входных данных, и показывает сколько раз.
void Dictionary(int[,] arr, int value)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == value)
            {
                count++;
            }
        }
    }
    if (count > 0)
        System.Console.WriteLine($"В масиве число {value} встречаються {count} раз");
    if (value < 10)
    {
        Dictionary(arr, value + 1);
    }
}

// 3. Метод выводит массив в терминал
void ShowMatrix(int[,] arr)
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
void ArrayWithRundomNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
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

// 2. Создаётся двумерный массив
int[,] matrix = new int[rows, columns];
ArrayWithRundomNumbers(matrix);

// 3. Вывод массива в терминал 
ShowMatrix(matrix);

// 4. Подсчёт, сколько раз в массиве встречается элемент входных данных, и вывод на экран кол-ва раз.
Dictionary(matrix, 0);