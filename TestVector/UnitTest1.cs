//MIT License
//Copyright (c) 2024 Artem-Nesterenko2005
//All rights reserved

namespace TestVector
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCheckNotNullVector()
        {
            var vector = new VeñtorOperations();
            var firstVector = new Dictionary<int, int>() { { 1, 2 }, { 2, 7 }, { 3, 5 }, { 4, 9 }};
            Assert.IsFalse(vector.CheckNullVector(firstVector));
        }

        [Test]
        public void TestCheckEmptyVector()
        {
            var vector = new VeñtorOperations();
            var firstVector = new Dictionary<int, int>();
            Assert.IsTrue(vector.CheckNullVector(firstVector));
        }

        [Test]
        public void TestMultiplicateVector()
        {
            var vector = new VeñtorOperations();
            var firstVector = new Dictionary<int, int>() { { 1, 1 }, { 2, 4 }, { 3, 7 }, { 4, 2 }, { 5, 10 } };
            var secondVector = new Dictionary<int, int>() { { 1, 2 }, { 2, 1 }, { 3, 2 }, { 4, 6 }, { 5, 10 } };
            Assert.That(vector.Multiplicate(firstVector, secondVector), Is.EqualTo(132));
        }

        [Test]
        public void TestAdditionVector()
        {
            var vector = new VeñtorOperations();
            var firstVector = new Dictionary<int, int>() { { 1, 1 }, { 2, 4 }, { 3, 7 }, { 4, 2 }, { 5, 10 } };
            var secondVector = new Dictionary<int, int>() { { 1, 2 }, { 2, 1 }, { 3, 2 }, { 4, 6 }, { 5, 10 } };
            var rightVector = new Dictionary<int, int>() { { 1, 3 }, { 2, 5 }, { 3, 9 }, { 4, 8 }, { 5, 20 } };
            Assert.That(vector.Addition(firstVector, secondVector), Is.EqualTo(rightVector));
        }
    }
}
