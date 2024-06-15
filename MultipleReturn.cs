using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    internal class MultipleReturn
    {
        // Using Tuple
        public static (int, string, bool) GetMultipleValues()
        {
            int number = 42;
            string text = "Hello, World!";
            bool flag = true;
            return (number, text, flag);
        }
        
        // Using Class
        public static MultipleValues GetMultipleValuesClass()
        {
            return new MultipleValues
            {
                Number = 42,
                Text = "Hello, World!",
                Flag = true
            };
        }
        // Using Struct
       

        public static MultipleValuesStruct GetMultipleValuesStruct()
        {
            return new MultipleValuesStruct
            {
                Number = 42,
                Text = "Hello, World!",
                Flag = true
            };
        }

        // Using Dynamic

        public static dynamic GetMultipleValuesDynamic()
        {
            return new
            {
                Number = 42,
                Text = "Hello, World!",
                Flag = true
            };
        }


    }
    public class MultipleValues
    {
        public int Number { get; set; }
        public string Text { get; set; }
        public bool Flag { get; set; }
    }

    public struct MultipleValuesStruct
    {
        public int Number { get; set; }
        public string Text { get; set; }
        public bool Flag { get; set; }
    }
}
