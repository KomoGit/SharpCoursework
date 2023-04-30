using System;

namespace Homework_4
{  
    internal class Program
    {
        static void Main()
        {           

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
    public int[] MinimumMaximum(params int[] arr)
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
        return new int[] { min,max };
    }
}

class ThirdHomework
{
    public float DiscountedPrice(float purchase)
    {
        float finalPrice = purchase;
        float result;
        switch (purchase)
        {
            case float p when p > 1000f:
                result = purchase * 10 / 100;
                finalPrice -= result;
                return finalPrice;
            case float p when p > 100 && p < 1000:            
                result =  purchase * 8 / 100;
                finalPrice -= result;
                return finalPrice;
            default:
                result = purchase * 5 / 100;
                finalPrice -= result;
                return finalPrice;
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