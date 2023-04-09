// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//В итоге получается вот такой массив:

//1 2 4 7

//2 3 5 9

//2 4 4 8
// int [,] myArray (int rows,int colums,int max, int min )
// {
//        int [,] arr = new int [rows,colums];
//     for (int i = 0; i < rows;i++)
//     {
//            for (int j  = 0; j < colums;j++)
//            {

//               Console.WriteLine ( Random.Shared.Next(min,max));


//            }


//     }



// }
// int [,] ShowPractic  (int[,]arr)
// { 
//     int rows = arr.GetLength(0);
//     int colums = arr.GetLength(1);
//     for (int i = 0; i< rows; i++)
//     {

//           for (int j = 0; j < colums;j++)
//           {

//             Console.WriteLine($"{arr[i,j]}");

//           }
//               Console.WriteLine();
//     }




// }
// void Prina2Dmax (int [,] arr)
// {
//    for (int i = 0; i < arr.GetLength(0);i++ )
//    {

//         for (int j = 0; j < arr.GetLength(1);j++)
//         {


//            int temp = arr[i,j];
//            arr [i,j] = temp;


//         }



//    }  


// } 
// int [,] arr =
// {

// {1 ,4, 7, 2},

// {5, 9, 2, 3},

// {8, 4, 2, 4}


// };
// ShowPractic(arr);
// Console.WriteLine($"покажите возрастное {myArray}");
// Prina2Dmax(arr);
Console.WriteLine($"покажите обратное числ  ");
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// Console.WriteLine("покажите пременай m");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("покажите пременая n");
// int n = Convert.ToInt32(Console.ReadLine());
// if (m == n)
// {
//      int [,] newarr = new int [m,n];
//       for (int i = 0; i< n ;i++)
//       {

//       for (int j = 0; j < m ; j++)
//       {

//         Console.WriteLine($"[i,j]");

//       }

//       }


// }
// void Prina2Dmax (int rows,int colums)
// {

//     for (int i = 0; i < rows;i++)
//     {

//       for (int j = 0; j < colums;j++)
//       {




//       }


//     }


// }
// int [,] MyProperti (int [,]arr)
// {
//      int rows = arr.GetLength(0);
//      int colums = arr.GetLength(1);
//      for (int i = 0; i< rows;i++)
//      {

//          for (int j = 0; j < colums;j++)
//          {

//            int temp = arr[i,j];
//            arr[i,j]= temp;


//          }
//              Console.WriteLine();
//      }

  
// }
// int [,] arr   = 
// {
//   {1, 4, 7, 2},
//  { 5 ,9, 2 ,3}


// };
// Prina2Dmax(0,0);
// Console.WriteLine($"{MyProperti}");
// Console.WriteLine($"покажити число   {MyProperti}");
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// и

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10

// 20 81 8 6

// 56 8 4 24

// 10 6 24 49
// Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
// int m = InputNumbers("Введите число строк 1-й матрицы: ");
// int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
// int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

// int[,] firstMartrix = new int[m, n];
// CreateArray(firstMartrix);
// Console.WriteLine($"Первая матрица:");
// WriteArray(firstMartrix);

// int[,] secomdMartrix = new int[n, p];
// CreateArray(secomdMartrix);
// Console.WriteLine($"Вторая матрица:");
// WriteArray(secomdMartrix);

// int[,] resultMatrix = new int[m,p];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"Произведение первой и второй матриц:");
// WriteArray(resultMatrix);

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)
// Console.WriteLine("пременая x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("пременая y");
// int y = Convert.ToInt32(Console.ReadLine());
// Random random = new Random();
// {

//   int[,] myArray = new int[3, 5];
//   for (int i = 2; i < myArray.GetLength(0); i++)
//   {
//     for (int j = 2; j < myArray.GetLength(1); j++)
//     {


//       myArray[i, j] = Random.Shared.Next(100);

//     }


//   }
//   for (int i = 2; i < myArray.GetLength(0); i++)
//   {
//     Console.WriteLine("page #1 " + i + 1);


//     for (int j = 2; j < myArray.GetLength(1); j++)
//     {


//      Console.WriteLine(myArray[i,j]);

//     }  
//         Console.WriteLine();


//   }




// }




// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7
// int n = 4;
// int[,] sqareMatrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//   sqareMatrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// WriteArray(sqareMatrix);

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }
  
