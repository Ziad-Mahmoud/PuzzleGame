using System;
namespace PuzzleGame
{
    internal class MoveHandler
    {
        public void SwapElements(Puzzle puzzle, GridElement element1, GridElement element2)
        {
            Vector2 temp1 = element1.currentIndex;
            Vector2 temp2 = element2.currentIndex;

            (puzzle.GridElements[temp2.x][temp2.y], puzzle.GridElements[temp1.x][temp1.y]) = 
                (puzzle.GridElements[temp1.x][temp1.y], puzzle.GridElements[temp2.x][temp2.y]);
             
            element1.UpdateCurrentPosition(temp2);
            element2.UpdateCurrentPosition(temp1);
        }

        public bool ElementsAdjacent(GridElement element1, GridElement element2)
        {
            int xDiff = Math.Abs(element1.currentIndex.x - element2.currentIndex.x);
            int yDiff = Math.Abs(element1.currentIndex.y - element2.currentIndex.y);
            return (xDiff == 1 && yDiff == 0) || (xDiff == 0 && yDiff == 1);
        }

    }
}