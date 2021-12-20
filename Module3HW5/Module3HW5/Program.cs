using System;
using Module3HW5.Service;

namespace Module3HW5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fileService = new FileService();
            var files = new string[] { "Files/Hello.txt", "Files/World.txt" };
            var result = fileService.ReadFilesAsync(files).GetAwaiter().GetResult();
            Console.WriteLine(result);
        }
    }
}
