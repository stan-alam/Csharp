
<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%201.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%202.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%203.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%204.png" width="80%" height="80%">
</a>

```cs
//cb177.A
class SomeClass
{
  public string Field1 = "base class field";
  public void Method1( string value ) {
    Console.WriteLine($"Base class --> Method1:  { value } ");
  }
} //end SomeClass

class OtherClass : SomeClass {  //derived class
  public string Field2 = "derived class field";
  public void Method2( string value ) {
    Console.WriteLine($"Derived class --> Method2:  { value }");
  }
} // end OtherClass

class Prog {
  static void Main() {
    OtherClass oc = new OtherClass();

    oc.Method1( oc.Field1 ); //base method with base field
    oc.Method1( oc.Field2 ); //base method with derived Field
    oc.Method2( oc.Field1 ); //derived method with base field
    oc.Method2( oc.Field2 ); //Derived method with derived field
  }
}

```
<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%205.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%206.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%207.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%208.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%209.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%2010.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%2011.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%2012.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%2013.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%2014.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%2015.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%2016_ed.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%2017.png" width="80%" height="80%">
</a>

```cs
//cb185.A
class MyBaseClass
{
  virtual public void Print()
  {
    Console.WriteLine("This is the base class!");
  }
}

class MyDerivedClass : MyBaseClass
{
  override public void Print()
  {
    Console.WriteLine("This is the derived class.");
  }
}

class Prog
{
  static void Main()
  {
    MyDerivedClass derived = new MyDerivedClass();
    MyBaseClass mybc       = (MyBaseClass)derived;  //case to base class

    derived.Print();
    mybc.Print();
  }
}
```

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%2018.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%2019.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%2020.png" width="80%" height="80%">
</a>

<a>
  <img src="https://github.com/stan-alam/Csharp/blob/develop/viscsharp/08/images/vischarp08%20-%20page%2021.png" width="80%" height="80%">
</a>

```cs
class SecondDerived : MyDerivedClass
{
  override public void Print() {
    Console.WriteLine("this is the 2nd derived class--");
  }
}

class Prog {

  static void Main()
  {
    SecondDerived derived = new SecondDerived(); // use SecondDerived
    MyBaseClass mybc = (MyBaseClass)derived; // use MyBaseClass

    derived.Print();
    mybc.Print();
  }
}
```
