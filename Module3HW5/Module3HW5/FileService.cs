using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Module3HW5
{
    public class FileService
    {
        public async Task<string> ReadFileAsync(string file) => await File.ReadAllTextAsync(file);

        public async Task<string> ReadFilesAsync(string[] paths)
        {
            var list = new List<Task<string>>();
            foreach (var item in paths)
            {
                list.Add(ReadFileAsync(item));
            }

            var result = await Task.WhenAll(list);
            return string.Join(" ", result);
        }
    }
}