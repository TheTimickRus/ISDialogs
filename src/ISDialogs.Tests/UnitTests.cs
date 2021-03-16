using NUnit.Framework;

namespace ISDialogs.Tests
{
    public class Tests
    {
        [Test]
        public void OpenFileTest()
        {
            Exports.OpenFile("");
            Assert.Pass();
        }

        [Test]
        public void SaveFileTest()
        {
            Exports.SaveFile("TestFile.cmd", "");
            Assert.Pass();
        }

        [Test]
        public void OpenFolderTest()
        {
            Exports.OpenFolder("Warface", "");
            Assert.Pass();
        }
    }
}