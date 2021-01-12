## Project to convert a Java Selenium Framework to C#

* We will convert a hypothetical Java Selenium/Webdriver framework to one based on C#

* Cover all the important concepts of OOP as they relate to C#

* Use POM and Factory pattern for abstraction

* Develop framework that consists of Interfaces, static class methods, Enumerations, LinkedLists, Arrays all in C#

* Explore UnitTesting such as MSTest or NUnit

* Maybe dockerize *package the tests with the application? Platform as a service on Azure

```cs
using System.IO;
using OpenQA.Selenium.Edge;

string serverPath = "MS Webdriver";

if (System.Environment.Is64BitOperatingSystem)
{
  serverPath = Path.Combine(System.Environment.ExpandEnvironmentVariables("%ProgramFiles%"), serverPath);
}

EdgeOptions options = new EdgeOptions();
options.PageLoadStrategy = EdgePageLoadStrategy.Eager;
IWebDriver driver = new EdgeDriver(serverPath, options);

```
