using System;

namespace GuessNumber
{
    class Game
    {
        private Random random;

        private int guessNumber;
        public int Tries { private set; get; }

        public Game()
        {
            random = new Random();
        }

        public void Start()
        {
            guessNumber = 1 + random.Next(100);
            Tries = 0;
        }

        public Answer Guess(int n)
        {
            Tries++;

            if (n == guessNumber)
                return Answer.EXACTLY;
            else if (guessNumber < n)
                return Answer.LESS;
            else
                return Answer.MORE;
        }
    }
}
