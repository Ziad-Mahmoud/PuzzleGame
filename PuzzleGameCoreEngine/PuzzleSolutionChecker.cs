namespace PuzzleGame
{
    internal class PuzzleSolutionChecker
    {
        public PuzzleSolutionChecker()
        {

        }

        public bool CheckWinCondition(Puzzle puzzle)
        {
            for (int x = 0; x < puzzle.GridElements.Length; x++)
            {
                for (int y = 0; y < puzzle.GridElements[x].Length; y++)
                {
                    if (!ElementInSolutionPosition(puzzle.GridElements[x][y]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool ElementInSolutionPosition(GridElement gridElement)
        {
            return gridElement.currentIndex.x == gridElement.solutionIndex.x && gridElement.currentIndex.y == gridElement.solutionIndex.y;
        }
    }
}