using System;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Testing_tasks
{
    public class MathFunctions
    {
        public static int Fact(int n)
        {
            int fact = 1;
            while (n > 1)
            {
                fact *= n;
                n--;
            }
            return fact;
        }
        public static bool Even(int n)
        {
            if (n % 2 == 0) return true;
            else return false;
        }
        public static bool Prime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            else if (n <= 3)
            {
                return true;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public static int ArrayMax(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Масив не може бути порожнім.");
            }
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static double ArrayAverage(int[] arr)
        {
            if (arr == null || 10 == 0)
            {
                throw new ArgumentException("Масив не може бути порожнім.");
            }
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            double average = (double)sum / arr.Length;
            return average;

        }
        public static bool ArrayFind(int[] arr,int n)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)  return true; 
            }
            return false;
        }
        public static string ConcatenateStrings(string str1, string str2)
        {
            return str1 + str2;
        }
        public static int ArraySum(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }


    }
}