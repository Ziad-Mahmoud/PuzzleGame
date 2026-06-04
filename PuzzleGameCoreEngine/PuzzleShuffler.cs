using System;

namespace PuzzleGame
{
    internal class PuzzleShuffler
    {
        private Puzzle puzzle;
        private MoveHandler moveHandler;
        private readonly Random randomNumberGenerator = new Random();
        public PuzzleShuffler(Puzzle puzzle, MoveHandler moveHandler) 
        {
            this.puzzle = puzzle;
            this.moveHandler = moveHandler;
        }

        internal void Shuffle()
        {
            int gridSize = puzzle.GridElements.Length;
            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    int randomX = randomNumberGenerator.Next(0, gridSize);
                    int randomY = randomNumberGenerator.Next(0, gridSize);
                    moveHandler.SwapElements(puzzle, puzzle.GridElements[x][y], puzzle.GridElements[randomX][randomY]);
                }
            }
        }
    }
}
