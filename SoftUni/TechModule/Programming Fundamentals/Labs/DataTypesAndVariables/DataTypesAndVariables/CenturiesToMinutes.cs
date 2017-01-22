﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndVariables
{
    class CenturiesToMinutes
    {
        static void Main(string[] args)
        {

            int centuries = int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int) (years * 364.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");


        }
    }
}
