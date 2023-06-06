using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProgramming
{
    internal class VariableTypes
    {
        public void VariableType() {

            var five = 5;
            var five_point_zero = 5.0;
            var five_greater_than_one = 5 > 1;
            var five_with_quotes = '5';
            var five_multiplied_by_two = 5 * 2;
            var five_with_qoute_multiplied_by_two = '5' * 2;
            var five_with_qoute_multiplied_by_two_with_qoute = '5' + '2';
            var five_devided_by_two = 5 / 2;
            var reminder = 5 % 2;
            int[] list_on_number = { 5, 2, 1 };
            var five_euquals_to_three = 5 == 3;
            var pi = Math.PI;

            Console.WriteLine(five.GetType());
            Console.WriteLine(five_point_zero.GetType());
            Console.WriteLine(five_greater_than_one.GetType());
            Console.WriteLine(five_with_quotes.GetType());
            Console.WriteLine(five_multiplied_by_two.GetType());
            Console.WriteLine(five_with_qoute_multiplied_by_two.GetType());
            Console.WriteLine(five_with_qoute_multiplied_by_two_with_qoute.GetType());
            Console.WriteLine(five_devided_by_two.GetType());
            Console.WriteLine(reminder.GetType());
            Console.WriteLine(list_on_number.GetType());
            Console.WriteLine(five_euquals_to_three.GetType());
            Console.WriteLine(pi.GetType());

            
        }
    }
}
