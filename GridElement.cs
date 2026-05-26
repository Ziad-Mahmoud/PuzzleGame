using System;

namespace PuzzleGame
{
    internal class GridElement
    {
        public Vector2 solutionIndex;
        public Vector2 currentIndex;
        public int valuePiece;
        public GridElement(Vector2 solutionIndex, Vector2 currentIndex, int valuePiece)
        {
            this.solutionIndex = solutionIndex;
            UpdateCurrentPosition(currentIndex);
            this.valuePiece = valuePiece;
        }

        public void UpdateCurrentPosition(Vector2 currentIndex)
        {
            this.currentIndex = currentIndex;
        }
    }
}
