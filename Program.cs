using System;
using System.Collections.Generic;

namespace AlgosDS
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Data Structure and Algorithms!");

            //ReverseName("fisayo oluwayemi");

            List<string> namesOfPeople = new List<string> { "fisayo", "nathaniel", "doyinsola", "rahiilaa" };
            //GTBStandPOS(namesOfPeople);


            int[] IntArray = new int[10] { 1, 3, 5, 7, 11, 13, 17, 19, 23, 31 };
            // Value to search for    
            int target = 17;
            int pos = Array.BinarySearch(IntArray, target);
            if (pos >= 0)
                Console.WriteLine($"Item {IntArray[pos].ToString()} found at position {pos + 1}.");
            else
                Console.WriteLine("Item not found");
            Console.ReadKey();
        }

        private static void ReverseName(string name)
        {
            //Stack - LIFO (Last In First Out)
            //Push - Last In
            //Pop - First Out

            //using the stack DS, reverse your name

            //word reversal
            //undo -redo functionality

            // initialize a new stack
            Stack<string> theStack = new();
            string[] token = name.Split(' ');

            //push the words on the stack
            for (int i = 0; i < token.Length; i++)
            {
                theStack.Push(token[i]);
            }

            while (theStack.Count != 0)
            {
                //get the word in revere order
                Console.WriteLine(theStack.Peek() + " ");
                theStack.Pop();
            }
        }

        //check the number of people that were at the POS stand today
        private static void GTBStandPOS(List<string> namesOfPeople)
        {
            Queue<string> listOfPeople = new(namesOfPeople);

            listOfPeople.Enqueue("amarachi");
            listOfPeople.Enqueue("oluwaseyii");

            //FIFO
            listOfPeople.Dequeue();


            foreach (string item in listOfPeople)
            {
                Console.WriteLine($"Name is: {item}");
            }


        }


        //HashTable - using Dictionary
        private static void UsageOfDictionaries()
        {
            Dictionary<string, string> keyValuePairs = new();

            keyValuePairs.Add("dt", "fisayo");
            keyValuePairs.Add("cf", "rahilaaa");

            try
            {
                keyValuePairs.Add("dt", "jsjksk");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Exception found: {ex.Message}");

            }

        }
    }
}