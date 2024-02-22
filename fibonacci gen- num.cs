using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace LogicalPrograms
{
    public class Program
    {
        public static void Main()
        {
            int firstNumber = 0, SecondNumber = 1, nextNumber, numberOfElements;
            Console.Write("napiš poèet generací : ");
            numberOfElements = int.Parse(Console.ReadLine());
            if (numberOfElements < 2)
            {
                Console.Write("víc než 2 plsky");
            }
            else
            {
                Console.Write(firstNumber + " " + SecondNumber + " ");

                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
            }

            Console.ReadKey();
        }
    }
}