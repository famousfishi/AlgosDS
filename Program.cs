using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgosDS
{
    public class FisayoDTO
    {
        public int age { get; set; }
        public string Name { get; set; }
    }

    public class RahilaaDTO
    {
        public int age { get; set; }
        public string Name { get; set; }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Data Structure and Algorithms!");

            //ReverseName("fisayo oluwayemi");

            //List<string> namesOfPeople = new List<string> { "fisayo", "nathaniel", "doyinsola", "rahiilaa" };
            //GTBStandPOS(namesOfPeople);

            //int[] IntArray = new int[10] { 1, 3, 5, 7, 11, 13, 17, 19, 23, 31 };
            //// Value to search for
            //int target = 17;
            //int pos = Array.BinarySearch(IntArray, target);
            //if (pos >= 0)
            //    Console.WriteLine($"Item {IntArray[pos].ToString()} found at position {pos + 1}.");
            //else
            //    Console.WriteLine("Item not found");
            //Console.ReadKey();

            Console.WriteLine("Test....");

            //string yourPhone = "08165158180";

            //FisayoDTO fisayoDTO = new()
            //{
            //    age = 26,
            //    Name = "Fisayo Oluwayemi"
            //};

            //RahilaaDTO rahilaaDTO = new()
            //{
            //    age = 21,
            //    Name = "Rahilaa Zaka"
            //};

            //BothDTOs(yourPhone, fisayoDTO, null);

            //List<int> data = GenerateHundredRandomNumbers();

            //foreach (int item in data)
            //{
            //    Console.WriteLine($"My data at  is {item}");
            //}

            //List<string> data = ReturnLastFiveMonthsFromThisMonth();

            //foreach (string item in data)
            //{
            //    Console.WriteLine($"My New month  is at {item}");
            //}

            //AreaOfACircle();

            int[] ints = new int[] { 1,568, 2, 3, 67, -98 };

            bool result = ExistingNumber(ints, 3);

            Console.WriteLine(result);

        }

        public static double AreaOfACircle()
        {
            const double pi = 3.142;
            double r;
            Console.WriteLine("Enter radius");
            r = Convert.ToDouble(Console.ReadLine());

            double areaOfACircle = pi * r * r;
            Console.WriteLine("The area of a crcle is {0}", areaOfACircle);
            Console.ReadLine();

            return areaOfACircle;
        }

        //check if a given number exists in an array with short possible solution and CPU usage cycles
        public static bool ExistingNumber(int[] ints, int k)
        {
            
            return Array.BinarySearch(ints, k) > -1;

           
        }

     
        public class ProfileData
        {
            public int JobId { get; set; }
            public string Name { get; set; }
            public bool JobStatus { get; set; }
            public string PropertyLease { get; set; }
        }

        public class ProfileDataGroup
        {
            public int JobId { get; set; }
            public List<ProfileData> ProfileDatas { get; set; }
        }

        private static void RetunGroupdByData()
        {
            List<ProfileData> profileDatas = new()
            {
                new ProfileData() { JobId = 1, JobStatus = true, Name = "Fisayo", PropertyLease = "Maitama" },
                new ProfileData() { JobId = 1, JobStatus = true, Name = "Fisayo Nathan", PropertyLease = "Gwarimpa" },
                new ProfileData() { JobId = 1, JobStatus = true, Name = "Doyin", PropertyLease = "Asokoro" },
                new ProfileData() { JobId = 2, JobStatus = true, Name = "Codeease", PropertyLease = "Kubwa" },
                new ProfileData() { JobId = 2, JobStatus = true, Name = "Emmannuel", PropertyLease = "Arab Road" },
            };

            List<ProfileDataGroup> groupedData = profileDatas.GroupBy(x => x.JobId).Select(x => new ProfileDataGroup()
            {
                JobId = x.Key,
                ProfileDatas = x.ToList()
            }).ToList();

            foreach (ProfileDataGroup data in groupedData)
            {
                //do anything with the data (JobId )

                foreach (ProfileData profileData in data.ProfileDatas)
                {
                    //do anything with prodile data
                }
            }
        }

        private static List<string> ReturnLastFiveMonthsFromThisMonth()
        {
            DateTime presentMonth = DateTime.UtcNow;

            List<string> result = new();

            for (int i = 5; i > 0; i--)
            {
                DateTime data = presentMonth.AddMonths(-i);
                result.Add(data.ToString("MMM"));
            }

            List<string> reveresedString = Enumerable.Reverse(result).ToList();

            return reveresedString;
        }

        private static List<int> GenerateHundredRandomNumbers()
        {
            List<int> numbers = new();

            Random random = new();

            for (int i = 0; i < 2000; i++)
            {
                int data = random.Next();
                numbers.Add(data);
            }

            return numbers;
        }

        private void BothDTOs(string phone, FisayoDTO fisayoDTO = null, RahilaaDTO rahilaaDTO = null)
        {
            string phoneNumber = phone;

            if (fisayoDTO != null)
            {
                Console.WriteLine($"{phoneNumber} is for fisayo");
            }
            else if (rahilaaDTO != null)
            {
                Console.WriteLine($"{phoneNumber} is for rahilaa");
            }
        }

        private void ReverseName(string name)
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
        private void GTBStandPOS(List<string> namesOfPeople)
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
        private void UsageOfDictionaries()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

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