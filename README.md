# LargeCPUProcessingAppDemo

This is a sample .NET Framework 4.8 console application that demonstrates object-level caching using JSON serialization and validates functionality using xUnit test cases.

---
# Features

- Caches computed results for duplicate `Employee` objects using `JsonConvert.SerializeObject()`
- Prevents redundant heavy processing using a dictionary cache
- Logs each cache access and heavy computation call
- Includes xUnit test to verify caching behavior

---

## Technologies

- .NET Framework 8
- C#
- xUnit (Unit Testing Framework)
- Newtonsoft.Json (for object serialization)

  ## Package Manager Console Commands:
  - Install-Package xunit
  - Install-Package xunit.runner.visualstudio
  - Install-Package Microsoft.NET.Test.Sdk
  - Install-Package Newtonsoft.Json

---

##  Project Structure
│
├── Program.cs → Entry point for demo
├── Employee.cs → Employee model
├── ObjectValidator.cs → Caching logic
├── ObjectValidatorTest.cs → xUnit test for caching

