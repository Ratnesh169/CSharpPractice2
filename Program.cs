namespace PracticeProject
{
    internal class Program : MultipleReturn
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using Tuple");

            var result = GetMultipleValues();
            Console.WriteLine($"Number: {result.Item1}, Text: {result.Item2}, Flag: {result.Item3}");

            Console.WriteLine("Using Class");

            var resultClass = GetMultipleValuesClass();
            Console.WriteLine($"Number: {resultClass.Number}, Text: {resultClass.Text}, Flag: {resultClass.Flag}");

            Console.WriteLine("Using Struct");

            var resultStruct = GetMultipleValuesStruct();
            Console.WriteLine($"Number: {resultStruct.Number}, Text: {resultStruct.Text}, Flag: {resultStruct.Flag}");

            Console.WriteLine("Using Dynamic");

            dynamic resultDynmic = GetMultipleValuesDynamic();
            Console.WriteLine($"Number: {resultDynmic.Number}, Text: {resultDynmic.Text}, Flag: {resultDynmic.Flag}");

        }
    }
}
