﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuizApplication
{
    class MultipleChoiceQuesiton : Question
    {
        String[] possibleAnswers;
        int answerIndex;

        public MultipleChoiceQuesiton(String questionText, String[] possibleAnswers, int answerIndex) : base(questionText)
        {
            this.possibleAnswers = possibleAnswers;
            this.answerIndex = answerIndex;
        }

        public override String getQuestion()
        {
            String fullQuestion = questionText + "\r\n";
            foreach (string s in possibleAnswers)
            {
                fullQuestion += s + "\r\n";
            }
            return fullQuestion;
        }

        public override string getAnswer()
        {
            return possibleAnswers[answerIndex];
        }

        public override bool checkAnswer(string answer)
        {
            return (answer.Equals(possibleAnswers[answerIndex]));
        }
    }
}
