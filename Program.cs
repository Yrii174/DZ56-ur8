/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
Console.WriteLine("Введите количество строк в массиве: "); 
int m = int.Parse(Console.ReadLine()); 
Console.WriteLine("введите количество столбцов: "); 
int n = int.Parse(Console.ReadLine());
int[,] CreatArray(int m, int n) 
{     
int[,] array1 = new int[m, n];     
Random rnd = new Random();     
for (int i = 0; i < array1.GetLength(0); i++)     
    {        for (int j = 0; j < array1.GetLength(1); j++)         
             {      array1[i, j] = rnd.Next(0, 10);         
             }     
    }     return array1; 
}
string ArrayToString(int[,] array1) 
{   string result = string.Empty;
    for (int i = 0; i < array1.GetLength(0); i++) 	
    { 		for (int j = 0; j < array1.GetLength(1); j++)
     		{ 			
                result += $"{array1[i, j]} "; 		
            }  		
            result += Environment.NewLine; 	
    }  	return result;
}
int[] NewArray(int[,] array1) 
{   int k = 0;  
int[] array2 = new int[m];     
for (int i = 0; i < array1.GetLength(0); i++)     
    {        for (int j = 0; j < array1.GetLength(1); j++)         
             {   array2[i] = array2[i] + array1[i,j];         
             if(array2[k]>array2[i]) { k = i; } 
             }   Console.WriteLine($"Сумма элеменов в строке {i+1} равна: {array2[i]}");  
    } System.Console.WriteLine($"Строка {k+1} является строкой с наименьшей суммой элементов");
    return array2; 
}
int [,] array1 = CreatArray(m,n);  
Console.WriteLine("Ваш массив: ");
Console.WriteLine(ArrayToString(array1));
NewArray(array1);
System.Console.WriteLine();
