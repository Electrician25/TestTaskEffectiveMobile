using FluentAssertions;
using TestTaskEffectiveMobile.Commands;
using TestTaskEffectiveMobile.Exceptions.AddrestStartCommandIsNull;
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
            act.Should().Throw<AddresCommandFileNotFoundException>();
        }

        [TestMethod]
        public void WhenWritingCommand_AndOutputFilePathIsNull_ThrowException()
        {
            // Arrange
            var command = new FileCommand();
            command.OutputLogFile = null;
            var args = new string[] { };

            //Act
            Action act = () => FileOption.Options(command, args);

            //Assert
            act.Should().Throw<AddresCommandFileNotFoundException>();
        }
    }
}