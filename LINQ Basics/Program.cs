var result = GenerateNumbers(10).Where(n=>n%3==0);
foreach (var number in result)
{
    Console.WriteLine(number);
}
Console.WriteLine(result);
IEnumerable<int> GenerateNumbers(int max)
{
    var numbers = new List<int>();
    for(int i = 0; i<= max; i++)
    {
        numbers.Add(i);
    }
    return numbers;
}