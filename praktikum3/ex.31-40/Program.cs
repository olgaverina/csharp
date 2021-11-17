
// Почувствуй себя сеньором
// 31. Задать массив из 8 элементов и вывести их на экран 
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
// 34. Написать программу замену элементов массива на противоположные
// 35. Определить, присутствует ли в заданном массиве, некоторое число 
// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетныхчетных чисел
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом



using static System.Console;


// Почувствуй себя сеньором
// 31. Задать массив из 8 элементов и вывести их на экран 

//int[] array = new int[8];

// int [] array = {1, 3, 5, 7, 9, 2, 4, 6};
// int length = array.Length;

// int[] array = new int[8];

// int[] array = CreateArray(10_000_000);
// // int length = array.Length;

// int[] CreateArray(int len)
// {
//     return new int[len];
// }

// void Fill_Array(int[] arr)
// {
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
// }

// DateTime dt = DateTime.Now;
// //WriteLine(Sum(N));
// Fill_Array(array);
// Console.WriteLine((DateTime.Now-dt).TotalMilliseconds);

// string PrintArray(int[] arr,)
// {
//     string result = string.Empty;
//     for (int i = 0; i < len; i++)
//     {
//         result += $"{arr[i]} "; 
//     }
//     return result;
// }

// WriteLine(PrintArray(array, length));


// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

// int[] array = new int[8];
// int length = array.Length;

// void Fill_Array(int[] arr, int len)
// {
//     int i = 0;
//     while (i < len)
//     {
//         array[i] = new Random().Next(0, 2);
//         i++;
//     }
// }

// string Print_Array(int[] arr, int len)
// {
//     string result = string.Empty;
//     for (int i = 0; i < len; i++)
//     {
//         result += $"{arr[i]} "; 
//     }
//     return result;
// }
// Fill_Array(array, length);
// WriteLine(Print_Array(array, length));

// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива

// int[] array = new int[12];
// int length = array.Length;

// void Fill_Array(int[] arr, int len)
// {
//     for (int i = 0; i < len; i++)
//         array[i] = new Random().Next(0, 10);
// }

// Fill_Array(array, length);

// int Sum_elem_arr(int[] arr, int len)
// {
//     int sum = 0;
//     for (int i = 0; i < len; i++)
//     {
//         if (i >= 0)
//             sum
//     }
// }

// 34. Написать программу замену элементов массива на противоположные

// int[] CreateArray(int len)
// {
//     return new int[len];
// }

// int[] array = CreateArray(10);

// int[] Fill_Array(int[] arr)
// {
//     int length = arr.Length;
//     for (int i = 0; i < length; i++)
//         arr[i] = new Random().Next(-100, 100);
//     return arr;
// }

// array = Fill_Array(array);

// int[] Exchange (int[] arr)
// {
//     int length = arr.Length;
//     for (int i = 0; i < length; i++)
//         arr[i] *= -1;
//     return arr;
// }
// WriteLine(Print_Array(array));

// array = Exchange(array);

// string Print_Array(int[] arr)
// {
//     string res = string.Empty;
//     for (int i = 0; i < arr.Length; i++)
//         res += $"{arr[i]} ";
//     return res;
// }

// WriteLine(Print_Array(array));

// 35. Определить, присутствует ли в заданном массиве, некоторое число 

// int[] CreateArray(int len)
// {
//     return new int[len];
// }

// int[] array = CreateArray(10);

// int[] FillArray(int[] arr)
// {
//     int length = arr.Length;
//     for (int i = 0; i < length; i++)
//         arr[i] = new Random().Next(-10, 10);
//     return arr;
// }
// array = FillArray(array);

// string PrintArray(int[] arr)
// {
//     string res = string.Empty;
//     for (int i = 0; i < arr.Length; i++)
//         res += $"{arr[i]} ";
//     return res;
// }

// WriteLine(PrintArray(array));

// int number = new Random().Next(-10, 10);
// WriteLine(number);

// int FindinArray(int[] arr, int n)
// {
//     int length = arr.Length;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == n)
//             return (1);       // нашли
//     }
//     return -1;                  // не нашли
// }

// WriteLine(FindinArray(array, number));



// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетныхчетных чисел

// int[] CreateArray(int len)
// {
//     return new int[len];
// }

// int[] array = CreateArray(10);

// int[] FillArray(int[] arr)
// {
//     int length = arr.Length;
//     for (int i = 0; i < length; i++)
//         arr[i] = new Random().Next(111, 1000);
//     return arr;
// }
// array = FillArray(array);

// string PrintArray(int[] arr)
// {
//     string res = string.Empty;
//     for (int i = 0; i < arr.Length; i++)
//         res += $"{arr[i]} ";
//     return res;
// }

// WriteLine(PrintArray(array));

// int CountOdd(int[] arr)
// {
//     int count_odd = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 != 0)
//             count_odd++;
//     }
//     return count_odd;
// }
// WriteLine($"В массиве {CountOdd(array)} нечетных чисел");
// WriteLine($"В массиве {array.Length - CountOdd(array)} четных чисел");



// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// int[] CreateArray(int len)
// {
//     return new int[len];
// }

// int[] array = CreateArray(123);

// int[] FillArray(int[] arr)
// {
//     int length = arr.Length;
//     for (int i = 0; i < length; i++)
//         arr[i] = new Random().Next(0, 100);
//     return arr;
// }
// array = FillArray(array);

// string PrintArray(int[] arr)
// {
//     string res = string.Empty;
//     for (int i = 0; i < arr.Length; i++)
//         res += $"{arr[i]} ";
//     return res;
// }

// WriteLine(PrintArray(array));

// int Search (int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] >= 10 && arr[i] <= 99)
//             count++;
//     }
//     return count;
// }

// WriteLine(Search(array));


// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции


// int[] CreateArray(int length)
// {
//     return new int[length];
// }

// int[] array = CreateArray(20);

// int[] FillArray(int[] arr)
// {
//     int length = arr.Length;
//     for (int i = 0; i < length; i++)
//         arr[i] = new Random().Next(0, 10);
//     return arr;
// }
// array = FillArray(array);

// string PrintArray(int[] arr)
// {
//     string res = string.Empty;
//     for (int i = 0; i < arr.Length; i++)
//         res += $"{arr[i]} ";
//     return res;
// }

// WriteLine(PrintArray(array));

// int OddPosition(int[] arr)
// {
//     int sum = 0;
//     int i = 1;
//     while (i < arr.Length)
//     {
//         sum += arr[i];
//         i += 2;
//     }
//     return sum;
// }

// WriteLine(OddPosition(array));



// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// int[] array = new int[10];
// string final_res = string.Empty;

// int[] GetArray (int[] A)
// {
//     for (int i = 0; i < A.Length; i++)
//     {
//         A[i] = new Random().Next(1,10);
//     }
//     return A;
// }

// string PrintArray (int[] B)
// {
//     string result = string.Empty;
//     for (int i = 0; i < B.Length; i++)
//     {
//         result = result + $" {B[i]} ";
//     }
//     return result;
// }

// GetArray(array);
// final_res = PrintArray(array);
// WriteLine(final_res);

// string Count (int[] C)
// {
//     string result = string.Empty;
//     for (int i = 0; i < C.Length/2; i++)
//     {
//         result += $"{C[i]*C[C.Length-1-i]} ";
//     }
//     return result;
// }
// WriteLine(Count(array));

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


// double[] CreateArray(int length)
// {
//     return new double[length];
// }

// double[] array = CreateArray(10);

// double[] FillArray(double[] A)
// {
//     for (int i = 0; i < A.Length; i++)
//     {
//         A[i] = new Random().NextDouble()*100;
//     }
//     return A;
// }
// array = FillArray(array);

// string PrintArray(double[] arr)
// {
//     string res = string.Empty;
//     for (int i = 0; i < arr.Length; i++)
//         res += $"{arr[i]}   ";
//     return res;
// }
// WriteLine(PrintArray(array));

// double MinMaxDiff(double[] arr)
// {
//     double min = arr[0];
//     double max = arr[0];
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (min > arr[i])
//             min = arr[i];
//         if (max < arr[i])
//             max = arr[i];
//     }
//     WriteLine(min);
//     WriteLine(max);
//     return max - min;
// }
// double result = MinMaxDiff(array);
// WriteLine(result);