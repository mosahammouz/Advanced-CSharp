namespace ConsoleApp6;

public class Account
{
    public string name { get; set; }
    public int age { get; set; }
    public Account(){}

    
    public void Sort(List<int> l, Func<List<int>, List<int>> operation)
    {
        var res = operation(l);
        Console.WriteLine(string.Join(" ", res));
    }

}