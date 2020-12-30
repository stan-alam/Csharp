using System;

class Class1
{
  int Temp0;
  int Temp1;
  public int this [ int index ]
  {
    get
    {
      return ( 0 == index ) ? Temp0 : Temp1; // return value of either Temp0 or Temp1
    } //end get scope

    set
    {
      if ( 0 == index )
        Temp0 = value;
      else
        Temp1 = value;

    }// end set scope
  }
} //end class1

class Prog
{
  static void Main()
  {
    Class1 c1 = new Class1();

      Console.WriteLine("Values -- To: {0}, T1: {0}", c1[0], c1[1]);
      c1[0] = 11;
      c1[1] = 42;
      Console.WriteLine($"Values -- To: { c1[0] }, T1: { c1[1] }");

  }
}
