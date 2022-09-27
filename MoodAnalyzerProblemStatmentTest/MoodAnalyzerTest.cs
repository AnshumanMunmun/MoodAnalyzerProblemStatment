using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblemStatment;

namespace MoodAnalyzerProblemStatmentTest
{
    [TestClass]
    public class MoodAnalyzerTest
    {
        [TestMethod]    // TC 1.1: Given “I am in Sad Mood” message will Return SAD. 
        public void GivenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            string expected = "SAD";                // Arrange
            string message = "I am in Sad Mood";
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);
            string mood = moodAnalyse.AnalyseMood();                // Act
            Assert.AreEqual(expected, mood);                    // Assert
        }
        [TestMethod]    // TC 1.2: Given “I am in Happy Mood” message will Return HAPPY. 
        public void GivenHappyMessage_WhenAnalyse_ShouldReturnSad()
        {
            string expected = "HAPPY";              // Arrange
            string message = "I am in HAPPY Mood";
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);
            string mood = moodAnalyse.AnalyseMood();            // Act
            Assert.AreEqual(expected, mood);                    // Assert
        }
        [TestMethod]    // TC 2.1: Given “I am in HAPPY Mood” and null message will Return HAPPY
        public void GivenNullMessage_WhenAnalyse_ShouldReturnHappy()
        {
            string expected = "HAPPY";              // Arrange
            string message = null;
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);
            string mood = moodAnalyse.AnalyseMood();            // Act
            Assert.AreEqual(expected, mood);                    // Assert
        }
    }
}