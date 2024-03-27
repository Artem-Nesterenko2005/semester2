namespace TestLZW
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCompressCommonFile()
        {
            string data = File.ReadAllText("C:\\Users\\Huawei\\Desktop\\2sem\\LZW\\testCommonFile.txt");
            var LZWStructure = new LZW();
            List<int> compressedString = LZWStructure.Compress(data);
            List<int> rightResult = [97, 98, 97, 99, 256, 97, 100, 260, 259, 257, 101];
            Assert.IsTrue(Enumerable.SequenceEqual<int>(compressedString, rightResult));
        }

        [Test]
        public void TestCompressEmptyFile()
        {
            string data = File.ReadAllText("C:\\Users\\Huawei\\Desktop\\2sem\\LZW\\testEmptyFile.txt");
            var LZWStructure = new LZW();
            List<int> compressedString = LZWStructure.Compress(data);
            Assert.IsEmpty(compressedString);
        }

        [Test]
        public void TestCompressFileWithSpaces()
        {
            string data = File.ReadAllText("C:\\Users\\Huawei\\Desktop\\2sem\\LZW\\testFileWithSpaces.txt");
            var LZWStructure = new LZW();
            List<int> compressedString = LZWStructure.Compress(data);
            List<int> rightResult = [84, 79, 66, 69, 79, 82, 78, 79, 84, 256, 258, 260, 256, 13, 10, 269, 266, 261, 263];
            Assert.IsTrue(Enumerable.SequenceEqual<int>(compressedString, rightResult));
        }

        [Test]
        public void TestDecompressFileWithSpaces()
        {
            string[] compressedData = File.ReadAllLines("C:\\Users\\Huawei\\Desktop\\2sem\\LZW\\testFileWithSpaces.txt.zipped");
            var LZWStructure = new LZW();
            string decompressionString = LZWStructure.Decompress(compressedData);
            Assert.IsTrue(Equals(decompressionString, "TOBEORNOTTOBEORTO\r\n\r\nBEORNOT"));
        }

        [Test]
        public void TestDecompressEmptyFile()
        {
            string[] compressedData = File.ReadAllLines("C:\\Users\\Huawei\\Desktop\\2sem\\LZW\\testEmptyFile.txt.zipped");
            var LZWStructure = new LZW();
            string decompressionString = LZWStructure.Decompress(compressedData);
            Assert.IsEmpty(decompressionString);
        }

        [Test]
        public void TestDecompressCommonFile()
        {
            string[] compressedData = File.ReadAllLines("C:\\Users\\Huawei\\Desktop\\2sem\\LZW\\testCommonFile.txt.zipped");
            var LZWStructure = new LZW();
            string decompressionString = LZWStructure.Decompress(compressedData);
            Assert.IsTrue(Equals(decompressionString, "abacabadabacabae"));
        }
    }
}
