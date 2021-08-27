using System;
using System.Collections.Generic;

namespace HW_8._1
{
    class ArrayHelper 
    {
        /// <summary>
        /// Pop
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string Pop(ref string[] arr)
        {
            // 1- pop string
            Console.WriteLine("\nPop string");
            Console.WriteLine("Элементы в типом string (Pop)");
            foreach (var array in arr) { Console.Write(array + " "); }
            string lastElement = arr[arr.Length - 1];
            string[] newArr = new string[arr.Length - 1];
            Console.WriteLine($"\nПоследный элемент: -{lastElement}");
            Console.WriteLine("Новый Массив:");
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i];
                Console.Write(newArr[i] + " ");
            }
            return lastElement;
        }
        public static int Pop(ref int[] arr)
        {
            // 2- pop int
            Console.WriteLine("\n\nPop int");
            Console.WriteLine("Элементы в типом инт(Pop)");
            foreach (var array in arr) { Console.Write(array + " "); }
            int lastElement = arr[arr.Length - 1];
            int[] newArr = new int[arr.Length - 1];
            Console.WriteLine($"\nПоследный элемент: -{lastElement}");
            Console.WriteLine("Новый Массив:");
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i];
                Console.Write(newArr[i] + " ");
            }
            arr = newArr;
            return lastElement;
        }
        public static double Pop(ref double[] arr)
        {
            // 3- pop double
            Console.WriteLine("\n\nPop double");
            Console.WriteLine("Элементы в типом инт(Pop)");
            foreach (var array in arr) { Console.Write(array + " "); }
            double lastElement = arr[arr.Length - 1];
            double[] newArr = new double[arr.Length - 1];
            Console.WriteLine($"\nПоследный элемент: -{lastElement}");
            Console.WriteLine("Новый Массив:");
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i];
                Console.Write(newArr[i] + " ");
            }
            arr = newArr;
            return lastElement;
        }
        public static decimal Pop(ref decimal[] arr)
        {
            // 4- pop decimal
            Console.WriteLine("\n\nPop decimal");
            Console.WriteLine("Элементы в типом инт(Pop)");
            foreach (var array in arr) { Console.Write(array + " "); }
            decimal lastElement = arr[arr.Length - 1];
            decimal[] newArr = new decimal[arr.Length - 1];
            Console.WriteLine($"\nПоследный элемент: -{lastElement}");
            Console.WriteLine("Новый Массив:");
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i];
                Console.Write(newArr[i] + " ");
            }
            arr = newArr;
            return lastElement;
        }
        public static float Pop(ref float[] arr)
        {
            // 5- pop float
            Console.WriteLine("\n\nPop float");
            Console.WriteLine("Элементы в типом инт(Pop)");
            foreach (var array in arr) { Console.Write(array + " "); }
            float lastElement = arr[arr.Length - 1];
            float[] newArr = new float[arr.Length - 1];
            Console.WriteLine($"\nПоследный элемент: -{lastElement}");
            Console.WriteLine("Новый Массив:");
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i];
                Console.Write(newArr[i] + " ");
            }
            arr = newArr;
            return lastElement;
        }
        /// <summary>
        /// Push
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int Push(ref string[] arr , string val)
        {
            // 1- Push string
            Console.WriteLine("\nPush string ");
            Console.WriteLine("Элементы в типом string");
            string[] newArr = new string[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
                Console.Write(newArr[i] + " ");
            }
            arr[arr.Length - 1] = val;
            arr = newArr;
            return arr.Length;
        }
        public static int Push(ref int[] arr, int val)
        {         // 1- Push int
            Console.WriteLine("\nPush int ");
            Console.WriteLine("Элементы в типом int");
            int[] newArr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
                Console.Write(newArr[i] + " ");
            }
            arr[arr.Length - 1] = val;
            arr = newArr;
            return arr.Length;
        }
        public static double Push(ref double[] arr, double val)
        {
            // 1- Push double
            Console.WriteLine("\nPush double ");
            Console.WriteLine("Элементы в типом double");
            double[] newArr = new double[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
                Console.Write(newArr[i] + " ");
            }
            arr[arr.Length - 1] = val;
            arr = newArr;
            return arr.Length;
        }
        public static decimal Push(ref decimal[] arr, decimal val)
        {
            // 1- Push decimal
            Console.WriteLine("\nPush decimal ");
            Console.WriteLine("Элементы в типом decimal");
            decimal[] newArr = new decimal[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
                Console.Write(newArr[i] + " ");
            }
            arr[arr.Length - 1] = val;
            arr = newArr;
            return arr.Length;
        }
        public static float Push(ref float[] arr, float val)
        {
            // 1- Push float
            Console.WriteLine("\nPush float ");
            Console.WriteLine("Элементы в типом float");
            float[] newArr = new float[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
                Console.Write(newArr[i] + " ");
            }
            arr[arr.Length - 1] = val;
            arr = newArr;
            return arr.Length;
        }
        /// <summary>
        /// Shift
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string shift(ref string[] arr)
        {
            // 1- shift---string
            Console.WriteLine("\n\nShift string");
            Console.WriteLine("Элементы в типом string (Shift)");
            foreach (var array in arr) { Console.Write(array + " "); }
            string firstlement = arr[0];
            string[] newArr = new string[arr.Length - 1];
            Console.WriteLine($"\nпервый элемент: {firstlement}");
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i + 1];
                Console.Write(newArr[i] + " ");
            }
            return firstlement;
        }
        public static int shift(ref int[] arr)
        {
            // 2- shift--int--
            Console.WriteLine("\n\nShift int");
            Console.WriteLine("Элементы в типом int (Shift)");
            foreach (var array in arr) { Console.Write(array + " "); }
            int firstlement = arr[0];
            int[] newArr = new int[arr.Length - 1];
            Console.WriteLine($"\nпервый элемент: {firstlement}");
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i + 1];
                Console.Write(newArr[i] + " ");
            }
            return firstlement;
        }
        public static double shift(ref double[] arr)
        {
            // 3- shift---double--
            Console.WriteLine("\n\nShift double");
            Console.WriteLine("Элементы в типом double (Shift)");
            foreach (var array in arr) { Console.Write(array + " "); }
            double firstlement = arr[0];
            double[] newArr = new double[arr.Length - 1];
            Console.WriteLine($"\nпервый элемент: {firstlement}");
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i + 1];
                Console.Write(newArr[i] + " ");
            }
            return firstlement;
        }
        public static decimal shift(ref decimal[] arr)
        {
            // 4- shift--decimal
            Console.WriteLine("\n\nShift decimal");
            Console.WriteLine("Элементы в типом decimal (Shift)");
            foreach (var array in arr) { Console.Write(array + " "); }
            decimal firstlement = arr[0];
            decimal[] newArr = new decimal[arr.Length - 1];
            Console.WriteLine($"\nпервый элемент: {firstlement}");
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i + 1];
                Console.Write(newArr[i] + " ");
            }
            return firstlement;
        }
        public static float shift(ref float[] arr)
        {
            // 5- shift--float
            Console.WriteLine("\n\nShift float");
            Console.WriteLine("Элементы в типом float (Shift)");
            foreach (var array in arr) { Console.Write(array + " "); }
            float firstlement = arr[0];
            float[] newArr = new float[arr.Length - 1];
            Console.WriteLine($"\nпервый элемент: {firstlement}");
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = arr[i + 1];
                Console.Write(newArr[i] + " ");
            }
            return firstlement;
        }
        public static int UnShift(ref string[] arr, string val)
        {
            // 4- Unshift  string
            Console.WriteLine("\n\nunShift string");
            Console.WriteLine("Элементы в типом string (unShift)");
            string[] newArr = new string[arr.Length + 1];
            newArr[0] = val;

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
                Console.Write(newArr[i] + " ");
            }
            arr[arr.Length - 1] = val;
            arr = newArr;
            return arr.Length;
        }
        public static int UnShift(ref int[] arr, int val)
        {
            // 4- Unshift int
            Console.WriteLine("\n\nunShift int");
            Console.WriteLine("Элементы в типом int (unShift)");
            int[] newArr = new int[arr.Length + 1];
            newArr[0] = val;

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
                Console.Write(newArr[i] + " ");
            }
            arr[arr.Length - 1] = val;
            arr = newArr;
            return arr.Length;
        }
        public static double UnShift(ref double[] arr, double val)
        {
            // 4- Unshift double
            Console.WriteLine("\n\nunShift double");
            Console.WriteLine("Элементы в типом double (unShift)");
            double[] newArr = new double[arr.Length + 1];
            newArr[0] = val;

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
                Console.Write(newArr[i] + " ");
            }
            arr[arr.Length - 1] = val;
            arr = newArr;
            return arr.Length;
        }
        public static decimal UnShift(ref decimal[] arr, decimal val)
        {
            // 4- Unshift decimal
            Console.WriteLine("\n\nunShift decimal");
            Console.WriteLine("Элементы в типом decimal (unShift)");
            decimal[] newArr = new decimal[arr.Length + 1];
            newArr[0] = val;

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
                Console.Write(newArr[i] + " ");
            }
            arr[arr.Length - 1] = val;
            arr = newArr;
            return arr.Length;
        }
        public static float UnShift(ref float[] arr, float val)
        {
            // 4- Unshift float
            Console.WriteLine("\n\nunShift float");
            Console.WriteLine("Элементы в типом float (unShift)");
            float[] newArr = new float[arr.Length + 1];
            newArr[0] = val;

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
                Console.Write(newArr[i] + " ");
            }
            arr[arr.Length - 1] = val;
            arr = newArr;
            return arr.Length;
        }
    }

    class Program : ArrayHelper
    {
 
        static void Main(string[] args)
        {
                      // 1- pop string 
            string[] pop = new string[] { "a", "b", "c", "d", "e", "f"};
             Pop(ref pop);
                     //2-pop int
            int[] pop2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Pop(ref pop2);
                     //3-pop double
            double[] pop3 = new double[] { 1.2, 2.3, 33.3, 4.3, 5.5 };
            Pop(ref pop3);
                    //4-pop decimal
            decimal[] pop4 = new decimal[] {3,5,999,666,5,6563 };
            Pop(ref pop4); 
                    //5-pop float
            float[] pop5 = new float[] { 6,5, 7,8, 8,4, 9,43, 10,12 };
            Pop(ref pop5);
            Console.WriteLine("\n============================================");
                     //1- Push string
            string[] push = new string[] { "a", "b", "c", "d", "e", "f" };
            Console.WriteLine("\nНовая длина массива: {0}", Push(ref push, "p"));
                    //2- Push int
            int[] push2 = new int[] { 1,2,3,4,5,6,7,8,9 };
            Console.WriteLine("\nНовая длина массива: {0}", Push(ref push2, 1));
            //3- Push double
            double[] push3 = new double[] { 1.3,2.5,3.8,4.5 };
            Console.WriteLine("\nНовая длина массива: {0}", Push(ref push3, 3.3));
            //4- Push decimal
            decimal[] push4 = new decimal[] { 16,24,3,4,5,6,7,8,9 };
            Console.WriteLine("\nНовая длина массива: {0}", Push(ref push4, 3));
            //5- Push float
            float[] push5 = new float[] { 1,2,3,4,5,6,7,8,9 };
            Console.WriteLine("\nНовая длина массива: {0}", Push(ref push5, 1));

            Console.WriteLine("\n============================================");

            string[] Shift = new string[] { "a", "b", "c", "d", "e", "f" };
            shift(ref Shift);
            //2-pop int
            int[] Shift2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            shift(ref Shift2);
            //3-pop double
            double[] Shift3 = new double[] { 1.2, 2.3, 33.3, 4.3, 5.5 };
            shift(ref Shift3);
            //4-pop decimal
            decimal[] Shift4 = new decimal[] { 3, 5, 999, 666, 5, 6563 };
            shift(ref Shift4);
            //5-pop float
            float[] Shift5 = new float[] { 6, 5, 7, 8, 8, 4, 9, 43, 10, 12 };
            shift(ref Shift5);

            Console.WriteLine("\n============================================");

            //1- Shift string
            string[] unShift = new string[] { "a", "b", "c", "d", "e", "f" };
            Console.WriteLine("\nНовая длина массива: {0}", UnShift(ref unShift, "w"));
            //2- Shift int
            int[] unShift2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("\nНовая длина массива: {0}", UnShift(ref unShift2, 1));
            //3- Shift double
            double[] unShift3 = new double[] { 1.3, 2.5, 3.8, 4.5 };
            Console.WriteLine("\nНовая длина массива: {0}", UnShift(ref unShift3, 2.3));
            //4- Shift decimal
            decimal[] unShift4 = new decimal[] { 16, 24, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("\nНовая длина массива: {0}", UnShift(ref unShift4, 5));
            //5- Shift float
            float[] unShift5 = new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("\nНовая длина массива: {0}", UnShift(ref unShift5, 23));


        }
    }

}

