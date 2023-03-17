var result = GenerateNumbers(10)
    .Where(n =>
    {
        return n % 2 == 0;
    }).Select(n=>
    {
       return n * 3;
    });
               

foreach (var number in result)
{
    Console.WriteLine(number);
}
IEnumerable<int> GenerateNumbers(int max)
{
   // var numbers = new List<int>();
    for(int i = 0; i<= max; i++)
    {
        yield return i; //return the value one by one .
    }
   // return numbers;
}