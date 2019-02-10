using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercices
{
    /// <summary>
    /// https://www.geeksforgeeks.org/queue-based-approach-for-first-non-repeating-character-in-a-stream/
    /// </summary>
    [TestClass]
    public class QueueBasedApproachForFirstNonRepeatingCharacterInAStream
    {
        [DataTestMethod]
        [DataRow("a a b c", "a -1 b b")]
        [DataRow("a a c", "a -1 c")]
        public void Execute(string input, string expectedOutput)
        {
            // Act
            var output = ExecuteInternal(input);

            // Assert
            Assert.AreEqual(expectedOutput, output.Trim());
        }

        private string ExecuteInternal(string input)
        {
            string result = string.Empty;
            Queue queu = new Queue();
            char[] inputChar = input.Replace(" ", "").ToCharArray();
            char previousChar = Char.MinValue;

            for (int i = 0; i < inputChar.Length; i++)
            {
                char c = inputChar[i];
                queu.Enqueue(c);

                if (c == previousChar)
                {
                    queu.Dequeue();
                    queu.Dequeue();
                }

                if (queu.Count == 0)
                {
                    result += " " + -1;
                }
                else
                {
                    result += " " + queu.Peek();
                }

                previousChar = c;
            }

            return result;
        }
    }
}
