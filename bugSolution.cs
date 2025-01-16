public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 5;
        int y = 0;
        try
        {
            int z = x / y; 
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero encountered.  Details: " + ex.Message);
            //Handle the error appropriately, such as setting a default value, logging the event, etc.
        }
    }
}