 using System.Reflection;
using Xunit;

namespace LargeCPUProcessingAppDemo
{
    public class ObjectValidatorTest
    {
        [Fact]
        public void Evaluate_ShouldReturnCachedValue_ForDuplicateEmployee()
        {
            var emp1 = new Employee { Id = 1, Name = "Shrikant" };
            var emp2 = new Employee { Id = 1, Name = "Shrikant" };

            // Reset private static fields using reflection
            var dictField = typeof(ObjectValidator)
                .GetField("dict", BindingFlags.NonPublic | BindingFlags.Static);
            dictField?.SetValue(null, new Dictionary<string, string>());

            var counterField = typeof(ObjectValidator)
                .GetField("counter", BindingFlags.NonPublic | BindingFlags.Static);
            counterField?.SetValue(null, 1);

            var originalOutput = Console.Out;
            var sw = new StringWriter();
            Console.SetOut(sw); // Redirect console output

            var result1 = ObjectValidator.Evaluate(emp1);
            var result2 = ObjectValidator.Evaluate(emp2);

            // Reset console output
            Console.SetOut(originalOutput);

            // Assert
            Assert.Equal("$Shrikant$", result1);
            Assert.Equal(result1, result2);

            var logs = sw.ToString();
            Assert.Contains("counter: 1", logs);               
            Assert.Contains("Returned from cache.", logs);     
        }
    }
}
