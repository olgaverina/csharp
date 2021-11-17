
// Почувствуй себя лидом
// 41. Выяснить являются ли три числа сторонами треугольника 
// 42. Определить сколько чисел больше 0 введено с клавиатуры
// 43. Написать программу преобразования десятичного числа в двоичное
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива



using static System.Console;



// Почувствуй себя лидом
// 41. Выяснить являются ли три числа сторонами треугольника /могут ли три отрезка заданной длины образовать треугольник
// 42. Определить сколько чисел больше 0 введено с клавиатуры


// 43. Написать программу преобразования десятичного числа в двоичное
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива

// #проблема
// Если мы перечислим все натуральные числа ниже 10, которые кратны 3 или 5, мы получим 3, 5, 6 и 9. Сумма этих кратных 23.
// Найдите сумму всех кратных 3 или 5 ниже 1000.


// int[] entering = {11, 13, 15, 17, 19, 12, 14, 16};
// int[] exit = {12, 15, 20, 19, 23, 16, 20, 21};

// void GetArray (int [] array)
// {
//     int count = array.Length;
//     for (int index = 0; index < count; index++)
//     {
//        array [index] = new Random ().Next (0, 24);
//     }
//  }
//  void PrintArray (int [] arr)
//  {
//      int number = arr.Length;
//      for (int i = 0; i < number; i++)
//      {
//          Console.Write (arr [i] + " " );
//      }
//  }
// int [] A = new int [2];
// GetArray (A);
// PrintArray (A);
// int [] B = new int [2];
// void GetArrayB (int [] array, int [] arrayA)
// {
//     int count = array.Length;
//     for (int index = 0; index < count; index++)
//     {
//        array [index] = new Random ().Next (arrayA[index] +1, 24);
//     }
//  }
// GetArrayB (B, A);
// Console.WriteLine ();
// PrintArray (B);
// Console.WriteLine ();
// int [] C = new int [24];
// void GetArrayC(int[] arr3, int[] arr2, int[] arr1)
// {
//     for (int i = 0; i < arr3.Length; i++)
//     {
//         for (int j = 0; j < arr1.Length; j++)
//         {
//             if (arr1[j] == i)
//             {
//                 arr3[i] += 1;
//                 while (arr1[j]++ < arr2[j])
//                     arr3[i] += 1;
//             }
//         }
//     }
// }
// GetArrayC (C, B, A);
// PrintArray (C);


// void GetArray (int [] array) 
// {     
//     int count = array.Length;     
//     for (int index = 0; index < count; index++)     
//     {       
//         array [index] = new Random ().Next (0, 24);         
//     }  
// }  
// void PrintArray (int [] arr)  
// {      
//     int number = arr.Length;      
//     for (int i = 0; i < number; i++)      
//     {          
//         Console.Write (arr [i] + " " );      
//     }   

// } 
// int [] A = new int [1000]; 
// GetArray (A); 
// //PrintArray (A); 
// int [] B = new int [1000]; 
// void GetArrayB (int [] array, int [] arrayA) 
// {     
//     int count = array.Length;     
//     for (int index = 0; index < count; index++)     
//     {        
//         array [index] = new Random ().Next (arrayA[index] +1, 24);     
//     }  
// }  
// GetArrayB (B, A); 
// Console.WriteLine (); 
// //PrintArray (B); 
// int [] C = new int [24]; 
// for (int hours = 0; hours <23; hours ++) 
// {     
//     for (int h = 0; h < A.Length; h ++)     
//     {     
//         if ((A[h] <= hours) && (hours < B [h]))     
//         {         
//             C [hours] = C [hours] + 1;     
//         }     
//     }      
// } 
// Console.WriteLine (); 
// PrintArray (C);
// WriteLine();

// int Max(int[] arr)
// {
//     int max = arr[0];
//     int max_i = 1;
//     for (int i = 1; i < arr.Length; i++)
//     {
//         Math.Max(max, arr[i]);
//         if (arr[i] > max)
//         {
//             max = arr[i];
//             max_i = i;
//         }
//     }
//     return max_i;
// }
//int number = C.Max();

// WriteLine(Max(C));

// WriteLine();
// int a = 2;
// int b = 5;
// int c = 15;
// WriteLine(Math.Max(a, b));


//Определить сколько чисел больше 0 введено с клавиатуры
// string number = Console.ReadLine();
// int GetCount(string x)
// {
//     char[] array = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
//     int count = 0;
//     for (int i = 0; i < x.Length; i++)
//     {
//         for (int j = 0; j < array.Length; j++)
//         {
//             if ((x[i] == array[j]) && i < array.Length)
//             {
//                 count++;
//                 i++;
//             }
//         }
//     }
//     return count;
// }

// System.Console.WriteLine($"Чисел больше 0 введено с клавиатуры: {GetCount(number)}");

//Определить сколько чисел больше 0 введено с клавиатуры
// string number = Console.ReadLine();
// int GetCount(string x)
// {
//     char[] array = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' }; 
//     int count = 0;
//     for (int i = 0; i < x.Length; i++)   //123qwerty567
//     {
//         for (int j = 0; j < array.Length; j++)
//         {
//             while (x[i] == array[j])
//             {
//                 i++;
//                 count++;
//             }
//         }
//     }
//     return count;
// }

// System.Console.WriteLine($"Чисел больше 0 введено с клавиатуры: {GetCount(number)}");
