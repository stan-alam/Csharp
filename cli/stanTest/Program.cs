using System.Threading.Tasks;
namespace stanTest;

class Program
{
    static void Main(string[] args)
    {
	int counter = 1;
	while(true)
	{
		Console.WriteLine($"Print line number {counter}");
		counter++;
		Task delayTask = Task.Run(async () => await Task.
		Delay(1000));
		delayTask.Wait();
	}
    }    
}
// $ dotnet new console -n stanTest -o stanTest --use-program-main