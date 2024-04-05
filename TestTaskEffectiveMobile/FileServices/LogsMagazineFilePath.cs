using TestTaskEffectiveMobile.Commands;
using TestTaskEffectiveMobile.Exceptions.FileIsEmpty;

namespace TestTaskEffectiveMobile.ReadFile
{
    public class LogsMagazineFilePath
    {
        public static void GetFilePath(FileCommand path)
        {
            IsValid(path);

            Console.WriteLine("Файл с логами найден!");
        }

        private static void IsValid(FileCommand path)
        {
            var file = File.ReadAllLines(path.InputLogFilePath)
                ?? throw new FileNotFoundException();

            if (file.Length == 0)
                throw new FileEmptyException();
        }
    }
}