namespace PuzzleGame
{
    internal class Puzzle
    {
        private GridElement[][] gridElements;
        public GridElement[][] GridElements
        {
            private set { gridElements = value; }
            get { return gridElements; }
        }
        public Puzzle(GridElement[][] gridElements)
        {
            this.GridElements = gridElements;
        }
    }
}
