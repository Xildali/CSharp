using System;
using System.Collections.Generic;
using System.IO;

namespace TrueFalseGame
{
    class Game
    {
        #region Private Fields

        private Random random;
        private TrueFalse database;
        private Question currentQuestion;
        private List<int> usedQuestions;

        #endregion

        #region Properties

        public int Rounds { private set; get; }
        public int CurrentRound { private set; get; }
        public int RightAnswers { private set; get; }
        public bool IsGameOver
        {
            get
            {
                return CurrentRound > Rounds;
            }
        }
        public string QuestionText 
        { 
            get 
            {
                return currentQuestion.Text; 
            } 
        }

        #endregion

        #region Constructors

        public Game(TrueFalse database)
        {
            if (database.Count == 0)
                throw new InvalidDataException("База пустая");

            random = new Random();
            this.database = database;
            usedQuestions = new List<int>();

            Rounds = Math.Min(5, database.Count);
            CurrentRound = 1;
            RightAnswers = 0;

            NextQuestion();
        }

        #endregion

        #region Methods

        public void Answer(bool answer)
        {
            if (answer == currentQuestion.TrueFalse)
                RightAnswers++;

            CurrentRound++;
            if (!IsGameOver)
                NextQuestion();
        }

        private void NextQuestion()
        {
            int index;
            do
            {
                index = random.Next(database.Count);
            }
            while (usedQuestions.Contains(index));

            usedQuestions.Add(index);
            currentQuestion = database[index];
        }

        #endregion
    }
}
