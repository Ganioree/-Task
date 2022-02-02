class Program
{
    static void Main(string[] args)
    {
        int[] MyArray =
        {
             1 2,
           3 4 5,
          6 7 8 9
          };
        var result = new string[array.Length];
var realSize = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
 
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));




