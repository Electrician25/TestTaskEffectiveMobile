using FluentAssertions;
using TestTaskEffectiveMobile.Commands;
using TestTaskEffectiveMobile.Exceptions.AddrestStartCommandIsNull;
using TestTaskEffectiveMobile.Exceptions.InputLogFilePathNull;
using TestTaskEffectiveMobile.Exceptions.OutputLogFilePathNull;
using TestTaskEffectiveMobile.FileOntions;

namespace ApplicationFileTest
{
    [TestClass]
    public class FileTest
    {
        [TestMethod]
        public void WhenWritingCommand_AndInputFilePathIsNull_ThrowException()
        {
            // Arrange
            var command = new FileCommand();
            command.InputLogFilePath = null;
            var args = new string[] { };

            //Act
            Action act = () => FileOption.Options(command, args);

            //Assert
            act.Should().Throw<InputLogFilePathIsNullException>();
        }

        [TestMethod]
        public void WhenWritingCommand_AndOutputFilePathIsNull_ThrowException()
        {
            // Arrange
            var command = new FileCommand();
            command.InputLogFilePath = "D:\\AccessLog\\FileLog1.txt";
            command.OutputLogFile = null;
            var args = new string[] { };

            //Act
            Action act = () => FileOption.Options(command, args);

            //Assert
            act.Should().Throw<OutputLogFilePathIsNullException>();
        }

        [TestMethod]
        public void WhenWritingCommand_AndPathsIsNotNullAndAddresStartIsNull_ThrowException()
        {
            // Arrange
            var command = new FileCommand();
            command.InputLogFilePath = "D:\\AccessLog\\FileLog1.txt";
            command.OutputLogFile = "D:\\OutputLog\\Result.txt";
            command.AddresStart = null;
            command.AddresMask = 1;
            var args = new string[] { };

            //Act
            Action act = () => FileOption.Options(command, args);

            //Assert
            act.Should().Throw<AddresCommandFileNotFoundException>();
        }
    }
}