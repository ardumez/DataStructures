using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercices
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/problems/left-view-of-binary-tree/1
    /// </summary>
    [TestClass]
    public class LeftViewOfBinaryTree
    {
        [DataTestMethod]
        [DataRow("1 2 3", "1 3")]
        [DataRow("10 20 30 40 60", "10 20 40")]
        public void Execute(string input, string expectedOutput)
        {
            // Act
            var output = ExecuteInternal(input);

            // Assert
            Assert.AreEqual(expectedOutput, output.Trim());
        }

        private string ExecuteInternal(object input)
        {
            throw new NotImplementedException();
        }
    }
}
