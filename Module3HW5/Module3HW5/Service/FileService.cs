using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;

namespace Module3HW5.Service
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

            await Task.WhenAll(list);
            var fulltext = new StringBuilder();
            foreach (var item in list)
            {
                fulltext.Append(item.Result);
            }

            return fulltext.ToString();
        }
    }
}