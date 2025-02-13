using System;
public class Days
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a date in the (dd/mm/yyyy) or type 'exit' to quit:");
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
            {
                break;
                }
                if (DateTime.TryParse(input, out DateTime enteredDate)){
                DateTime currentDate = DateTime.Now;
                if (enteredDate > currentDate)
                {
                    TimeSpan timeUntil = enteredDate - currentDate;
                    Console.WriteLine($"There are {timeUntil.Days} days remaining until {enteredDate:dd-MM-yyyy}.");
                }
                else if (enteredDate < currentDate)
                {
                    TimeSpan timeSince = currentDate - enteredDate;
                    Console.WriteLine($"There have been {timeSince.Days} days since {enteredDate:dd-MM-yyyy}.");
                }
                else
                {
                    Console.WriteLine($"The date {enteredDate:dd-MM-yyyy} is today.");
                }
            }
            else
            {
                Console.WriteLine("wrong input. try again");
            }
        }
    }
}

