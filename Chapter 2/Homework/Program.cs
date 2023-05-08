using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Use Test cases.");
        }
    }
}

internal class FirstHomework
{
    public float SumASCIIValues(string text)
    {
        if(text == null)
        {
            throw new Exception("Value cannot be null");
        }
        float result = default;
        byte[] asciiBytes = Encoding.ASCII.GetBytes(text);
        for (int i = 0; i < asciiBytes.Length; i++)
        {
            result += asciiBytes[i];
        }
        return result;
    }
}