using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblemStatment
{
    public class MoodAnalysisException : Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD, EMPTY_MOOD
        }
        public ExceptionType Type;
        public MoodAnalysisException(ExceptionType Type, string message) : base(message)
        {
            this.Type = Type;
        }
    }
}
