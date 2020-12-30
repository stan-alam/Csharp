## 07

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%201.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%202.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%203.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%204.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%205.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%206.png" width="80%" height="80%">
</a>

```cs
//cb 132.A
using System;

class D {
  public int Mem1;
}

class Prog {
  static void Main() {
    D d1 = new D();
    D d2 = new D();
    d1.Mem1 = 10; d2.Mem1 = 28;

    Console.WriteLine($"d1 = { d1.Mem1 }, d2 = { d2.Mem1}");
    }
}
```

<p align="center">
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/2020-12-25%2013_54_37-Developer%20Command%20Prompt%20for%20VS%202017.png" width="75%" height="75%">
</p>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%207.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%208.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%209.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2010.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2011A.png" width="80%" height="80%">
</a>

```cs
//cb 135.A
class D
{
  int        Mem1;
  static int Mem2;

  public void SetVars(int v1, int v2) // set the values
  { Mem1 = v1; Mem2= v2; } //Mem2 has access as if it were an instance field

  public void Display( string str ){
    Console.WriteLine("{0}: Mem1 = {1}, Mem2 = {2}", str, Mem1, Mem2);
  }

  class Prog {
    static void Main(){
      D d1 = new D();
      D d2 = new D(); //create instances of default:

        d1.SetVars(4, 2); //Set d1's values
        d1.Display("d1");

        d2.SetVars(11, 11); //set d2's values
        d2.Display("d2");

        d1.Display("d1");   //Display d1 again and notice value of static member Mem2 has changed!
    }
  }
}
```

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2011B.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2012.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2013.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2014.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2015.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2016.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2017.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2018.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2019.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2020.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2021.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2022.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2023.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2024.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2025.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2026.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2027.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2028.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2029.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2030.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2031.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2032.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2033.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2034.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2035.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2036.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2037.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2038.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2039.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2040.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2041.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2042.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2043A.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2043B.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2044.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2045.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2046.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2047.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2048.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2049A.png" width="80%" height="80%">
</a>  

```cs
//cb 154.A
class Class2
{
  public Class2(int Value) {...}  //Constructor 0
  public Class2(String value) {...} //Constructor 1
}

class Prog
{
  static void Main()
  {
    Class2 c2 = New Class2(); //**************************ERROR******************************* no constructor with 0 params
  }
}

```
<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2049B.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2050.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2051.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2052.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2053.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2054.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2055.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2056.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2057.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2058.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2059.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2060.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2061.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2062.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2063.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2064.png" width="80%" height="80%">
</a>

```cs
//cb 162.A
class Emp
{
  public string LastName;
  public string FirstName;
  public string CityOfBirth;
}

class MyProg
{
  static void Main()
  {
  Emp = emp1 = new Emp;

  emp1.LastName = "Doe";
  emp1.FirstName = "Jane";
  emp1.CityOfBirth = "NYC";
  Console.WriteLine("{0}", emp1.LastName);
  Console.WriteLine("{0}", emp1.FirstName);
  Console.WriteLine("{0}", emp1.CityOfBirth);
  }
}
```
<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2065.png" width="80%" height="80%">
</a>

```cs
//cb 162.B
//using indexed fields
class Emp
{
  public string LastName;
  public string FirstName;
  public string CityOfBirth;
}

class MyProg
{
  static void Main()
  {
  Emp = emp1 = new Emp;

  emp1[0] = "Doe";
  emp1[1] = "Jane";
  emp1[2] = "NYC";
  Console.WriteLine("{0}", emp1[0]);
  Console.WriteLine("{0}", emp1[1]);
  Console.WriteLine("{0}", emp1[2]);
  }
}
```
<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2066.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2067.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2068.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2069.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2070.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2071.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2072.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2073.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2074.png" width="80%" height="80%">
</a>

```cs
//167.A
class Emp {
  public string LastName;      // call this field 0
  public string FirstName;     //call this field 1
  public string CityOfBirth;   //call this field2

  public string this[int index]
  {
    set
    {
      switch (index) {
        case 0: LastName = value;
          break;
        case 1: FirstName = value;
          break;
        case 2: CityOfBirth = value;
          break;

          default:
            throw new ArgumentOutOfRangeException("index");
      }
    }

    get
    {
      switch (index) {
        case 0: return LastName;
        case 1: return FirstName;
        case 2: return CityOfBirth;

        default:
          throw new ArgumentOutOfRangeException("index");
      }
    }
  }
} //end class Emp
```

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2075.png" width="80%" height="80%">
</a>

```cs
//168.A
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
```

<p align="center">
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/src/2020-12-30%2017_40_26-Developer%20Command%20Prompt%20for%20VS%202017.png" width="75%" height="75%">
</p>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/07/images/viscsharp07%20-%20page%2076.png" width="80%" height="80%">
</a>

```cs
//169.A
class MyAwesomeClass
{
  public string this [ int index ]
  {
    get{...}
    set{...}
  }

  public string this [ int index1, index2 ]
  {
    get{...}
    set{...}
  }
  ...
}

```
