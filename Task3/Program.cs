// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


System.Console.WriteLine("Введите количество элементов в строке: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество элементов в столбце: ");
int n = Convert.ToInt32(Console.ReadLine());

int GetResult(int m, int n)
{
    
int [,] arr = new int [m,n];
int [] result = new int [m];
int sum = 0;
int res = 0;
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            arr [i,j] = new Random().Next(10);
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }

    System.Console.WriteLine();

    for (int i = 0; i < n; i++){
        sum += arr[i,j];
        for (int j = 0; j < m; j++){
            
            
            //System.Console.Write();
        }
        res = sum / m;
        System.Console.Write(sum);
        System.Console.Write(res);
        System.Console.WriteLine();
    }
    return res;
    
}
GetResult(m,n);
