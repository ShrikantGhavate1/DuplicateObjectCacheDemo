using Newtonsoft.Json;

namespace LargeCPUProcessingAppDemo
{
    internal class ObjectValidator
    {
        static int counter = 1;
        static Dictionary<string, string> dict = new Dictionary<string, string>();
        internal static string Evaluate(Employee input)
        {
            try
            {
                string key = JsonConvert.SerializeObject(input);
                if (dict.ContainsKey(key))
                {
                    //return from cache.
                    return dict[key];
                }

                dict[key] = Calculate(input);
                return dict[key];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during evaluation: " + ex.Message);
                throw;
            }
        }

        private static string Calculate(Employee emp)
        {
            try
            {
                Console.WriteLine("counter: " + counter++);
                return "$" + emp.Name + "$";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in calculation: " + ex.Message);
                throw;
            }
        }
    }
}

