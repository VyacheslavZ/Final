// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] Massive(int N)
{
    string[] array = new string[N];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива c индексом {i} = ");
        array[i] = Console.ReadLine();
    }
    return array;
}
string[] Search_elements (string[] args)
{
    string[] array = new string[args.Length];
    int j=0;
    for (int i = 0; i < args.Length; i++)
    {
        if (args[i].Length<=3) array[j]=args[i];
        j++;
    }
    return array;
}
try
{
    Console.Write("Введите размер массива = ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(string.Join(" , " , Search_elements(Massive(a))));
}
catch
{
    Console.WriteLine("Нельзя вводить минусовое значение либо значение не больше 9 цифр ");
}
