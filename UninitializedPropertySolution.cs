public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize the property before accessing it.
        MyProperty = 10; // Or assign a value based on your logic
        Console.WriteLine(MyProperty); 
    }
}