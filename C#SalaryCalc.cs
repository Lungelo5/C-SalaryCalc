using System;

namespace EmployeeSalry
{
    class Program
    {
        private const string Format = "C";

        static void Main(string[] args)
        {

        //this application calculates employee salary and overtime based on  overtime rate
        //if the hours worked exceeds 40 hours.
        //It also handlesn format  exeptions  when the user enters string/character values instead of numbers.
            double grossPay = 0;
            double overTime = 0;
            double  hoursWorked = 0;
            double hourlyRate = 0;


           try
            { 

            Console.WriteLine("Enter hours worked ");
            hoursWorked = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Hourly Rate");
            hourlyRate = Convert.ToDouble(Console.ReadLine());

            
            

                if (hoursWorked <= 40)
                {
                    grossPay = hoursWorked * hourlyRate;
                }
                else
                {
                    grossPay = 40 * hourlyRate;
                    overTime = (hoursWorked - 40) * (hourlyRate * 1.5);
                    grossPay = grossPay + overTime;

                }
                Console.Write("GrossPay:" + grossPay.ToString("C"));

            }
            catch (FormatException )
            {

                Console.WriteLine("Please Enter only Numbers");
            } 
            
            
            









        }
    }
}
