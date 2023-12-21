using NetExceptionsApp;

Person person = new Person();

try
{
    person.Name = "Bobby";
    person.Age = -1;
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.InnerException);
    Console.WriteLine(e.Source);
    Console.WriteLine(e.TargetSite);
    Console.WriteLine(e.StackTrace);
}



/*
if(Int32.TryParse(Console.ReadLine(), out int number))
{
    try
    {

        Console.WriteLine($"{100 / number}");
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine($"{e.Message}");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Error! {e.Message}");
    }
    finally
    {
        Console.WriteLine("Block finally");
    }
}
else
    Console.WriteLine("Input integer number!");
*/

Console.WriteLine("Other code");
