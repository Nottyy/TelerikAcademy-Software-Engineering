﻿namespace ExceptionsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class ExceptionsHomework
    {
        
        static void Main()
        {
            var substr = Utils.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Utils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(String.Join(" ", subarr));

            var allarr = Utils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(String.Join(" ", allarr));

            var emptyArr = Utils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(String.Join(" ", emptyArr));
            try
            {
                Console.WriteLine(Utils.ExtractEnding("I love C#", 2));
                Console.WriteLine(Utils.ExtractEnding("Nakov", 4));
                Console.WriteLine(Utils.ExtractEnding("beer", 4));
                Console.WriteLine(Utils.ExtractEnding("Hi", 100));
            }
            catch(NullReferenceException nre)
            {
                Console.WriteLine(nre.Message);
            }
            catch(ArgumentOutOfRangeException aore)
            {
                Console.WriteLine(aore.Message);
            }

            try
            {
                Utils.CheckPrime(23);

                if (Utils.CheckPrime(23))
                {
                    Console.WriteLine("23 is prime");
                }
                else
                {
                    Console.WriteLine("23 is not prime");
                }
            }
            catch (ArgumentOutOfRangeException aore)
            {
                Console.WriteLine(aore.Message);
            }

            try
            {
                Utils.CheckPrime(33);

                if (Utils.CheckPrime(33))
                {
                    Console.WriteLine("33 is prime");
                }
                else
                {
                    Console.WriteLine("33 is not prime");
                }
            }
            catch (ArgumentOutOfRangeException aore)
            {
                Console.WriteLine(aore.Message);
            }

            List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}