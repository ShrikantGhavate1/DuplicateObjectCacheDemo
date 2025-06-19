

namespace LargeCPUProcessingAppDemo
{
    public class Program
    {

        public static void Main(string[] args)
        {
            try
            {
                Employee emp = new Employee { Id = 1, Name = "Shrikant" };
                Employee emp2 = new Employee { Id = 1, Name = "Shrikant" };

                string ans = ObjectValidator.Evaluate(emp);
                Console.WriteLine("Result 1: " + ans);

                string ans2 = ObjectValidator.Evaluate(emp2);
                Console.WriteLine("Result 2: " + ans2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
