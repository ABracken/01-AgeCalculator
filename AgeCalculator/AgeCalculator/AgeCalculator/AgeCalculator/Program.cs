using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("What is your birthday? (Enter date in format MM/DD/YYYY):");

            string input = Console.ReadLine();

            DateTime birthDate = DateTime.Parse(input);

            DateTime now = DateTime.Now;



            TimeSpan Span = now - birthDate;


            DateTime Age = DateTime.MinValue + Span;



            int Years = Age.Year - 1;
            int Months = Age.Month - 1;
            int Days = Age.Day - 1;
            Console.WriteLine("You are " + Years.ToString() + " Years, " + Months.ToString() + " Months, " + Days.ToString() + " Days");



        }
    }
