/* Написать программу котораяя из имеющегося массива строк сформирует 
массив в котором длина строк меньше либо равна трем */

string[] array = {"hello", "2", "world", ":)"};
string[] newarray = new string[array.Length];
int j = 0;

void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        {
            Console.Write($"{array[i] } ");
        }
    }
}

string[] CreateNewArray(string[] arr, string[] newarr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (arr[i].Length <= 3){
            newarr[j] = arr[i];
            j++;
        } 
    }
    return newarr; 
}

Console.WriteLine("Заданный массив строк:");
Console.WriteLine();
PrintArray(array);
CreateNewArray(array, newarray);
Console.WriteLine();
Console.WriteLine("Массив строк, длина которых меньше либо равна трем:");
Console.WriteLine();
PrintArray(newarray);

