using TestTaskEffectiveMobile.Commands;

namespace TestTaskEffectiveMobile.FileServices
{
    public class FileReader
    {
        public string Read(FileCommand path)
        {
            StreamReader streamReader = new(path.InputLogFilePath);
            var allText = streamReader.ReadToEnd();
            streamReader.Close();
            return allText;
        }
    }
}