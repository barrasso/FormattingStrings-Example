using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingStrings_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write to console with currency format
            Console.WriteLine("This is an example of formatting money: {0:C}", 25);

            // Write to console with 4 decimal place format
            Console.WriteLine("This is an exmaple of formatting with 4 decimal places: {0:F4}", 12.733242);

            // Write to console with percents
            Console.WriteLine("This is an exmaple of formatting with percents: {0:P10}", 1.4356);

            // Write to console with commas and decimal formatting
            Console.WriteLine("This is an exmaple of comma and decimal formatting: {0:N2}", 2452323.942);

            // Keep console open
            Console.Read();
        }
    }
}
