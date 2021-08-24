using System;

namespace Problem {
    class Program {
        static void Main(string[] args) {
            int[] arr = {1, 2, 3, 4};

            ArrayHelper.PrintArray(arr);
           
            int del = ArrayHelper.Pop(ref arr);
            System.Console.WriteLine($"deleted {del}");
            ArrayHelper.PrintArray(arr);

            del = ArrayHelper.Shift(ref arr);
            System.Console.WriteLine($"deleted {del}");
            ArrayHelper.PrintArray(arr);
    
            int len = ArrayHelper.Push(ref arr, 10);
            System.Console.WriteLine($"pushed 10, new length = {len}");
            ArrayHelper.PrintArray(arr);

            len = ArrayHelper.UnShift(ref arr, -10);
            System.Console.WriteLine($"poped -10, new length = {len}");
            ArrayHelper.PrintArray(arr);
        }
    }

    static class ArrayHelper {
        public static void PrintArray<T>(T[] arr) {
            Console.Write("Array: ");

            foreach(T elm in arr) {
                Console.Write($"{elm} ");
            }
            
            Console.WriteLine();
        }

        public static T Pop<T>(ref T[] arr) {
            if(arr.Length == 0)
                return default(T);

            T[] nArr = new T[arr.Length - 1];
            T res = arr[arr.Length - 1];
            
            for(int i = 0; i < nArr.Length; i++) 
                nArr[i] = arr[i];
            

            arr = nArr;
            return res;
        }      

        public static int Push<T>(ref T[] arr, in T elm) {
            T[] nArr = new T[arr.Length + 1];
            
            for(int i = 0; i < arr.Length; i++)
                nArr[i] = arr[i];

            nArr[arr.Length] = elm;
            arr = nArr;

            return nArr.Length;
        }

        public static T Shift<T>(ref T[] arr) {
            if(arr.Length == 0)
                return default(T);

            T[] nArr = new T[arr.Length - 1];
            T res = arr[0];
            
            for(int i = 0; i < nArr.Length; i++) 
                nArr[i] = arr[i + 1];
            
            arr = nArr;
            
            return res;
        }      

        public static int UnShift<T>(ref T[] arr, T elm) {
            if(arr.Length == 0)
                return 0;
            
            T[] nArr = new T[arr.Length + 1];
            
            for(int i = 0; i < arr.Length; i++)
                nArr[i + 1] = arr[i];

            nArr[0] = elm;
            arr = nArr;

            return nArr.Length;
        }
    }
} 