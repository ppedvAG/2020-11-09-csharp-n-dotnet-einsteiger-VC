# Snippets von VS für C# #

zum schnelleren Schreiben von Codeausschnitten
<!-- 
#todo
Snippet für Console.WriteLine("description : {0}", object o);

#todo
Snippet für Console.ReadKey();
-->
---

<!-- auskommentiert, weil eher für 'C# Fortgeschritten'-Kurs relevant -->
<!-- `Attribute` + `TAB`

```csharp
[AttributeUsage(global::System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
sealed class MyAttribute : Attribute
{
    // See the attribute guidelines at
    //  http://go.microsoft.com/fwlink/?LinkId=85236
    readonly string positionalString;

   // This is a positional argument
   public MyAttribute (string positionalString)
   {
        this.positionalString = positionalString;

       // TODO: Implement code here
       throw new NotImplementedException();
   }

    public string PositionalString
    {
        get { return positionalString; }
    }

   // This is a named argument
   public int NamedInt { get; set; }
}
```

--- -->

`checked` + `TAB`

```csharp
checked { }
```

---

`class` + `TAB`

```csharp
class MyClass { }
```

---

`ctor` + `TAB`

```csharp
// Konstruktor
public MyClass () { }
```

---

`cw` `TAB` `TAB`

```csharp
Console.WriteLine();
```

---

`do` + `TAB`

```csharp
do { } while (true);
```

---

`else` + `TAB`

```csharp
else { }
```

---

`enum` + `TAB`

```csharp
enum MyEnum { }
```

---

<!-- auskommentiert, weil eher für 'C# Fortgeschritten'-Kurs relevant -->
<!-- `equals` + `TAB`

```csharp
// override object.Equals
public override bool Equals (object obj)
{
    //
    // See the full list of guidelines at
    //   http://go.microsoft.com/fwlink/?LinkID=85237  
    // and also the guidance for operator== at
    //   http://go.microsoft.com/fwlink/?LinkId=85238
    //

    if (obj == null || GetType() != obj.GetType())
    {
        return false;
    }

    // TODO: write your implementation of Equals() here
    throw new NotImplementedException();
    return base.Equals (obj);
}

// override object.GetHashCode
public override int GetHashCode()
{
    // TODO: write your implementation of GetHashCode() here
    throw new NotImplementedException();
    return base.GetHashCode();
}
```

--- -->

<!-- auskommentiert, weil eher für 'C# Fortgeschritten'-Kurs relevant -->
<!-- `Exception` + `TAB`

```csharp
[Serializable]
public class MyException : Exception
{
  public MyException() { }
  public MyException( string message ) : base( message ) { }
  public MyException( string message, Exception inner ) : base( message, inner ) { }
  protected MyException(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context ) : base( info, context ) { }
}
```

--- -->

`for` + `TAB`

```csharp
for (int i = 0; i < length; i++) { }
```

---

`foreach` + `TAB`

```csharp
foreach (var item in collection) { }
```

---

`forr` + `TAB`

```csharp
for (int i = length - 1; i >= 0 ; i--) { }
```

---

`if` + `TAB` + `TAB`

```csharp
if (true) { }
```

---

<!-- auskommentiert, weil eher für 'C# Fortgeschritten'-Kurs relevant -->
<!-- `#if` + `TAB` + `TAB`

```csharp
#if true
#endif
```

--- -->

<!-- auskommentiert, weil eher für 'C# Fortgeschritten'-Kurs relevant -->
<!-- `indexer` + `TAB`

```csharp
public object this[int index]
{
    get { /* return the specified index here */ }
    set { /* set the specified index to value here */ }
}
```

--- -->

`interface` + `TAB`

```csharp
interface IInterface { }
```

---
<!-- auskommentiert, weil eher für 'C# Fortgeschritten'-Kurs relevant -->
<!-- `invoke` + `TAB`

```csharp
EventHandler temp = MyEvent;
if (temp != null)
{
    temp();
}
```

--- -->
<!-- auskommentiert, weil eher für 'C# Fortgeschritten'-Kurs relevant -->
<!-- `iterator` + `TAB`

```csharp
public System.Collections.Generic.IEnumerator<ElementType> GetEnumerator()
{
    throw new NotImplementedException();
    yield return default(ElementType);
}
```

--- -->
<!-- auskommentiert, weil eher für 'C# Fortgeschritten'-Kurs relevant -->
<!-- `iterindex` + `TAB`

```csharp
public MyViewIterator MyView
{
    get
    {
        return new MyViewIterator(this);
    }
}

public class MyViewIterator
{
    readonly MyViewIterator outer;

    internal MyViewIterator(MyViewIterator outer)
    {
        this.outer = outer;
    }

    // TODO: provide an appropriate implementation here
    public int Length { get { return 1; } }

    public ElementType this[int index]
    {
        get
        {
            //
            // TODO: implement indexer here
            //
            // you have full access to MyViewIterator privates
            //
            throw new NotImplementedException();
            return default(ElementType);
        }
    }

    public System.Collections.Generic.IEnumerator<ElementType> GetEnumerator()
    {
        for (int i = 0; i < this.Length; i++)
        {
            yield return this[i];
        }
    }
}
```

--- -->
<!-- auskommentiert, weil eher für 'C# Fortgeschritten'-Kurs relevant. Thema: Threads -->
<!-- `lock` + `TAB`

```csharp
lock (this) { }
```

--- -->

`mbox` + `TAB`

```csharp
MessageBox.Show("Test");
// oder
System.Windows.Forms.MessageBox.Show("Test");
```

---

`namespace` + `TAB`

```csharp
namespace MyNamespace { }
```

---

`prop` + `TAB`

```csharp
public int MyProperty { get; set; }
```

---
<!-- auskommentiert, weil eher für 'C# Fortgeschritten'-Kurs relevant -->
<!-- `propa` + `TAB`

```csharp
public static int GetMyProperty(DependencyObject obj)
{
    return (int)obj.GetValue(MyPropertyProperty);
}

public static void SetMyProperty(DependencyObject obj, int value)
{
    obj.SetValue(MyPropertyProperty, value);
}

// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
public static readonly DependencyProperty MyPropertyProperty =
    DependencyProperty.RegisterAttached("MyProperty", typeof(int), typeof(ownerclass), new PropertyMetadata(0));
```

--- -->
<!-- auskommentiert, weil eher für 'C# Fortgeschritten'-Kurs relevant -->
<!-- `propdb` + `TAB`

```csharp
public int MyProperty
{
    get { return (int)GetValue(MyPropertyProperty); }
    set { SetValue(MyPropertyProperty, value); }
}

// Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
public static readonly DependencyProperty MyPropertyProperty =
    DependencyProperty.Register("MyProperty", typeof(int), typeof(ownerclass), new PropertyMetadata(0));
```

--- -->

`propfull` + `TAB`

```csharp
private int myVar;

public int MyProperty
{
    get { return myVar;}
    set { myVar = value;}
}
```

---

`propg` + `TAB`

```csharp
public int MyProperty { get; private set; }
```

---

`region` `TAB` `TAB`
oder
`#region` `TAB` `TAB`

```csharp
#region MyRegion
#endregion
```

---

`sim` + `TAB`

```csharp
static int Main(string[] args)
{
    return 0;
}
```

---
<!-- auskommentiert, weil eher für 'C# Fortgeschritten'-Kurs relevant -->
<!-- `struct` + `TAB`

```csharp
struct MyStruct { }
```

--- -->

`svm` + `TAB`

```csharp
static void Main(string[] args) { }
```

---

`switch` + `TAB`

```csharp
switch (switch_on)
{
    default:
}
```

---

`testc` + `TAB`

```csharp
[Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
public class MyTestClass { }
```

---

`testm` + `TAB`

```csharp
[Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
public void MyTestMethod() { }
```

---

`try` + `TAB`

```csharp
try { }
catch (global::System.Exception)
{
    throw;
}
```

---

`tryf` + `TAB`

```csharp
try { }
finally { }
```

---

`unchecked` + `TAB`

```csharp
unchecked { }
```

---
<!-- auskommentiert, weil eher für 'C# Fortgeschritten'-Kurs relevant -->
<!-- `unsafe` + `TAB`

```csharp
unsafe { }
```

--- -->

`using` + `TAB`

```csharp
using(resource) { }
```

---

`while` + `TAB`

```csharp
while (true) { }
```

---

`~` + `TAB`

```csharp
~MyClass() { }
```

---

Einstellungen: VS -> Tools –> Code Snippets Manager

[Anleitung](https://docs.microsoft.com/de-de/visualstudio/ide/visual-csharp-code-snippets?view=vs-2019&redirectedfrom=MSDN)
