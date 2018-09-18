using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuizApplication
{
    class TrueFalseQuestion : Question
    {
        private bool answer;

        public TrueFalseQuestion(string questionText, String answerText) : base(questionText)
        {
            answer = string.Equals(answerText, "True", StringComparison.InvariantCultureIgnoreCase);
        }

        public override string getAnswer()
        {
            if (answer)
            {
                return ("True");
            }
            else { return ("False"); }
        }

        public override string getQuestion()
        {
            return this.questionText + "(True/False)";
        }

        public override bool checkAnswer(String givenAnswer)
        {
            return (answer == string.Equals(givenAnswer, "True", StringComparison.InvariantCultureIgnoreCase));
        }

    }
}
