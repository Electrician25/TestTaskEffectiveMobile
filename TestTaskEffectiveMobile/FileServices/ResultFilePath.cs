using TestTaskEffectiveMobile.Commands;

namespace TestTaskEffectiveMobile.FileServices
{
    public class ResultFilePath
    {
        public static void GetFilePath(FileCommand path)
        {
            IsValid(path);

            Console.WriteLine("Результирующий файл найден!");
            Console.WriteLine();
        }

        private static void IsValid(FileCommand path)
        {
            _ = File.ReadAllLines(path.OutputLogFile)
                ?? throw new FileNotFoundException();
        }
    }
}