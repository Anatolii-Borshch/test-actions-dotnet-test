using TestBack.Console.Services;

CalculateService service = new CalculateService();

Console.WriteLine(service.Factorial(10));
Console.WriteLine(service.ArraySum([1,2,3,4]));
Console.WriteLine(service.IsPatronimic("abccba"));