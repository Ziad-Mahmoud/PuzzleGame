using System;

namespace PuzzleGame
{
    internal class ConsoleInputHandler
    {
        private Puzzle puzzle;
        private PuzzleLogger logger;
        public ConsoleInputHandler(Puzzle puzzle, PuzzleLogger logger)
        {
            this.puzzle = puzzle;
            this.logger = logger;
        }

        public bool GetStartGameInput()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                return true;
            }
            else
            {
                logger.LogInvalidStartGameInput();
                return GetStartGameInput();
            }
        }
        public Vector2 SelectElement()
        {
            string input = Console.ReadLine();
            if(int.TryParse(input, out int selectedValue))
            {
                int gridLength = puzzle.GridElements.Length;
                for (int x = 0; x < gridLength; x++)
                {
                    for (int y = 0; y < gridLength; y++)
                    {
                        if (puzzle.GridElements[x][y].valuePiece == selectedValue)
                        {
                            return new Vector2(x, y);
                        }
                    }
                }
            }

            logger.InvalidSelectElementInput();
            return SelectElement();
        }
    }
}
