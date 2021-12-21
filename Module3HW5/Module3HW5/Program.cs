using System;

namespace Module3HW5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fileService = new FileService();
            var files = new string[] { "Hello.txt", "World.txt" };
            var result = fileService.ReadFilesAsync(files).GetAwaiter().GetResult();
            Console.WriteLine(result);
        }
    }
}
