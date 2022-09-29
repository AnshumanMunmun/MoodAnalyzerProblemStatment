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
            string expected = "SAD";                            // Arrange
            string message = "I am in Sad Mood";
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);
            string mood = moodAnalyse.AnalyseMood();            // Act
            Assert.AreEqual(expected, mood);                    // Assert
        }
        [TestMethod]    // TC 1.2: Given “I am in Happy Mood” message will Return HAPPY. 
        public void GivenHappyMessage_WhenAnalyse_ShouldReturnSad()
        {
            string expected = "HAPPY";                          // Arrange
            string message = "I am in HAPPY Mood";
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);
            string mood = moodAnalyse.AnalyseMood();            // Act
            Assert.AreEqual(expected, mood);                    // Assert
        }        
        [TestMethod]
        public void GivenNULLMessageWillThrowMoodAnalysisException()    // TC 3.1: Given NULL message will Throw MoodAnalysisException.
        {
            string message = null;
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);
            try
            {
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("Message is Null", ex.Message);
            }
        }
        [TestMethod]            //TC 3.2: Given Empty message will Throw MoodAnalysisException Indicating Empty Mood.
        public void GivenEmptyMessageWillThrowMoodAnalysisException()
        {
            string message = "Invalid Message";
            MoodAnalyzer moodAnalyse = new MoodAnalyzer(message);
            try
            {
                string mood = moodAnalyse.AnalyseMood();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("Message is Empty", ex.Message);
            }
        }
    }
}