﻿using System.Reflection.Metadata.Ecma335;

namespace MyLibrary
{
    public class Operations
    {
        public int Add(int number1, int number2)
        { 
            return number1 + number2; 
        }
          public bool isEven(int number)
        {
            return number %2==0;
        }   
        

    }
}
