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

double GetResult(int m, int n)
{
    
int [,] arr = new int [m,n];
int [] result = new int [m];
double sum = 0;
double res = 0;
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            arr [i,j] = new Random().Next(10);
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }

    System.Console.WriteLine();

    for (int i = 0; i < n; i++){
        
        for (int j = 0; j < m; j++){
            
            sum += arr[j,i];
            //System.Console.Write();
        }
        res = sum / m;
        System.Console.Write("Сумма элементов в столбце " + sum + " ");
        System.Console.Write("Среднее арифметическое " + res);
        System.Console.WriteLine();
        sum = 0;
    }
    return res;
    
    
}
GetResult(m,n);
