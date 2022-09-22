// Задача 50. Напишите программу, которая на вход принимает позиции
//  элемента в двумерном массиве, и возвращает значение этого элемента 
//  или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// вводим позиции по i и j -> если таких нет - выводим, что позиции не существует.
//  Если есть - выводим элемент по этим индексам.


System.Console.WriteLine("Введите позицию в строке: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите позицию в столбце: ");
int n = Convert.ToInt32(Console.ReadLine());


int [,] GetArray(int m, int n)
{
    int a = new Random().Next(10);
    int b = new Random().Next(10);

int [,] arr = new int [a,b];

    for (int i = 0; i < a; i++){
        for (int j = 0; j < b; j++){
            arr [i,j] = new Random().Next(100);
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
    if(m <= a && n <= b){
        System.Console.WriteLine(arr[m,n]);
    }
    else {
        System.Console.WriteLine("Значения не принадлежат массиву");
    }
    return arr;

}
GetArray(m,n);