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

        d1.Display("d1");   //Display d1 again and notice value of static mmember Mem2 has changed!
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
