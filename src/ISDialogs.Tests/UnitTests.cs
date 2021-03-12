using NUnit.Framework;

namespace ISDialogs.Tests
{
    public class Tests
    {
        [Test]
        public void OpenFileTest()
        {
            Exports.OpenFile("All Files|*.*");
            Assert.Pass();
        }

        [Test]
        public void SaveFileTest()
        {
            Exports.SaveFile("TestFile.cmd", "All Files|*.*");
            Assert.Pass();
        }

        [Test]
        public void OpenFolderTest()
        {
            Exports.OpenFolder("Warface");
            Assert.Pass();
        }
    }
}