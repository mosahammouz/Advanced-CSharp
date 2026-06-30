namespace ConsoleApp6;

public record Person(string FllName , DateOnly DateOfBirth);
public record Employee(string LastName, DateOnly DateOfBirth);
public record Order(int Id, String CustomerName, double Price);