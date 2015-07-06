using System;

namespace TrueOrFalse
{
    public class Question
    {
        public enum Category
        {
            None = 0,
            Nature = 1,
            Sport = 2,
            People = 3,
            ManMade = 4
        }

        public Question (string text, bool answer, Category category)
        {
            QuestionText = text;
            QuestionAnswer = answer;
            QuestionCategory = category;
        }

        public string QuestionText {get; private set;}
        public bool QuestionAnswer {get; private set;}
        public Category QuestionCategory {get; private set;}

    }
}

