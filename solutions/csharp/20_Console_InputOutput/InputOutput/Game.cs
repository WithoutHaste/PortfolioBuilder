using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("InputOutputTest")]

namespace InputOutput
{
    public enum HotColdResponse
    {
        InvalidInput = 0,
        Correct,
        Hot,
        Warm,
        Cold,
        Warmer,
        WarmerGettingHot,
        Colder,
        RepeatGuess,
    };

    internal class Game
    {
        public readonly int Min;
        public readonly int Max;
        private int targetNumber;
        private int? lastGuess;

        public Game(int min, int max) : this(min, max, new Random().Next(min, max + 1)) { }

        internal Game(int min, int max, int targetNumber)
        {
            if (min >= max) throw new ArgumentException("Min must be less than Max");

            Min = min;
            Max = max;
            this.targetNumber = targetNumber;
        }

        internal HotColdResponse GetResponse(string guess)
        {
            int validGuess;
            if (!TryParseGuess(guess, out validGuess))
            {
                return HotColdResponse.InvalidInput;
            }

            var response = GetResponse(validGuess);
            lastGuess = validGuess;
            return response;
        }

        private HotColdResponse GetResponse(int validGuess)
        {
            if (validGuess == targetNumber) return HotColdResponse.Correct;
            if (validGuess == lastGuess) return HotColdResponse.RepeatGuess;

            if (lastGuess == null || Distance(lastGuess.Value) == Distance(validGuess))
            {
                if (Distance(validGuess) <= 5) return HotColdResponse.Hot;
                if (Distance(validGuess) <= 20) return HotColdResponse.Warm;
                return HotColdResponse.Cold;
            }
            if (Distance(validGuess) > Distance(lastGuess.Value)) return HotColdResponse.Colder;
            if (Distance(validGuess) <= 5) return HotColdResponse.WarmerGettingHot;
            return HotColdResponse.Warmer;
        }

        private int Distance(int guess)
        {
            return Math.Abs(targetNumber - guess);
        }

        /// <param name="result">Will be set to the valid value guess, if there is one</param>
        /// <returns>
        /// True if the guess is a valid value.
        /// False if the guess is an invalid value.
        /// </returns>
        private bool TryParseGuess(string guess, out int result)
        {
            if (Int32.TryParse(guess, out result))
            {
                if (result < Min || result > Max) 
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
