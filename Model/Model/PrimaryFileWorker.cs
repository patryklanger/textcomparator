using System;
using System.IO;
using System.Threading.Tasks;
namespace FileComparator
{
    public class PrimaryFileWorker : IFileReader, IFileSaver
    {
        public PrimaryFileWorker()
        {
        }

        public Text ReadFile(string filePath)
        {
            string text;
            try
            {
                text = System.IO.File.ReadAllText(filePath);
            }
            catch (Exception e)
            {
                throw;
            }
            var resultObject = new Text();
            resultObject.Directory = filePath;
            resultObject.Content = text;
            return resultObject;
        }

        public async Task SaveFile(Text textToSave, string filePath)
        {
            await File.WriteAllTextAsync(filePath, textToSave.Content);
        }
    }
}
