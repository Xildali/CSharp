using System;
using System.Collections.Generic;

namespace Doubler
{
    class Game
    {
        private Random random;

        private Stack<int> history;

        public int CurrentNumber { private set; get; }
        public int GuessNumber { private set; get; }

        public int OperationsCount
        {
            get
            {
                return history.Count;
            }
        }

        public Game()
        {
            random = new Random();
            history = new Stack<int>();
        }

        public void Start()
        {
            CurrentNumber = 1;
            GuessNumber = 10 + random.Next(41);
            history.Clear();
        }

        public void Reset()
        {
            CurrentNumber = 1;
            history.Clear();
        }

        public void IncOperation()
        {
            history.Push(CurrentNumber);
            CurrentNumber++;
        }

        public void DoubleOperation()
        {
            history.Push(CurrentNumber);
            CurrentNumber *= 2;
        }

        public void Undo()
        {
            if (history.Count <= 0) 
                return;

            CurrentNumber = history.Pop();
        }

        public bool IsWin()
        {
            return CurrentNumber == GuessNumber;
        }
    }
}
