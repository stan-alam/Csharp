## 05 Classes in C#, theBasics!

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%201.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%202.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%203.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%204.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%205.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%206.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%207.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%208.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%209.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%2010.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%2011.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%2012.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%2014.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%2015.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%2016.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%2017.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%2018.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%2019.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%2020.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%2021.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%2022.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%2023.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/master/viscsharp/05/images/vcshrp05%20-%20page%2024.png" width="80%" height="80%">
</a>

```cs

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
```