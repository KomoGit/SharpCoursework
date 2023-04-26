using System;
using System.Collections.Generic;

namespace Homework_4
{  
    internal class Program
    {
        //Uncomment these to test the project.
        //private static readonly FirstHomework firstHomework = new FirstHomework();
        //private static readonly SecondHomework secondHomework = new SecondHomework();
        //private static readonly ThirdHomework thirdHomework = new ThirdHomework();
        //private static readonly FourthHomework fourthHomework = new FourthHomework();
        private static FifthHomework FifthHomework = new FifthHomework();
        static void Main()
        {           
            //int[] arr = { 4, 7, 9, 12, 14 };
            //Console.Write("The amount of the purchase - ");
            string pur = Console.ReadLine();

            if (float.TryParse(pur, out float value))
            {
                //thirdHomework.DiscountedPrice(value);
                Console.WriteLine(FifthHomework.DetermineGrade(value));
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid float value.");
            }                   
            //firstHomework.DividesToThree(7,18);
            //secondHomework.MinimumMaximum(arr);
            //Console.WriteLine(fourthHomework.ArithmeticMean(arr)); 
        }
    }
}

class FirstHomework
{
    public void DividesToThree(int range1, int range2)
    {
        for (int i = range1; i <= range2; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }           
        }
    }
}

class SecondHomework
{
    public void MinimumMaximum(int[] arr)
    {
        int min = arr[0];
        int max = arr[0];
        for (int i = 0; i < arr.Length; i++) 
        {
            if(arr[i] > max)
            {
                max = arr[i];             
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        Console.WriteLine(min);
        Console.WriteLine(max);
    }
}

class ThirdHomework
{
    public void DiscountedPrice(float purchase)
    {
        float finalPrice = purchase;
        float res;
        switch (purchase)
        {
            case float p when p > 1000f:
                //10 percent discount to this.
                res = purchase * 10 / 100;
                finalPrice -= res;
                Console.WriteLine(finalPrice);
                break;
            case float p when p > 100 && p < 1000:
                //8 percent discount to this.              
                res =  purchase * 8 / 100;
                finalPrice -= res;
                Console.WriteLine(finalPrice);
                break;
            default:
                //5 percent discount to this.
                res = purchase * 5 / 100;
                finalPrice -= res;
                Console.WriteLine(finalPrice);
                break;
        }
    }
}

class FourthHomework
{
    public float ArithmeticMean(int[] arr)
    {
        float result = default;
        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
        }
        return result / arr.Length;
    }
}

class FifthHomework
{   
    public char DetermineGrade(float grade)
    {
        switch (grade)
        {
            case float g when g >= 90:
                return 'A';
            case float g when g >= 80:
                return 'B';
            case float g when g >= 70:
                return 'C';
            case float g when g >= 60:
                return 'D';
            case float g when g > 50:
                return 'E';
            default:
                return 'F';
        } 
    }
}