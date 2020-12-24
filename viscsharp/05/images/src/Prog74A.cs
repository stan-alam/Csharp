class DaysTemp {

  public int High = 90;
  public int Low  = 50;

}

class Prog {

  static void Main()
  {

    DaysTemp temp = new DaysTemp();

    temp.High = 83;
    temp.Low = 23;

    Console.WriteLine("High is " {0}", temp.High");
    Console.WriteLine($"Low: { temp.Low }");
    }

}
