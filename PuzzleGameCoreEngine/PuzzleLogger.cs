using System;

namespace PuzzleGame
{
    internal class PuzzleLogger
    {
        public PuzzleLogger()
        {

        }

        internal void DrawPuzzle(Puzzle puzzle)
        {
            Console.WriteLine("Current puzzle state:");

            GridElement[][] gridElements = puzzle.GridElements;
            for (int x = 0; x < gridElements.Length; x++)
            {
                for (int y = 0; y < gridElements[x].Length; y++)
                {
                    GridElement gridElement = gridElements[x][y];
                    Console.Write($"[{gridElement.valuePiece}]" + " ");
                }
                Console.WriteLine();
            }
        }

        internal void LogWelcome()
        {
            Console.WriteLine("Welcome to the Puzzle Game!");
        }

        internal void LogInstructions()
        {
            Console.WriteLine("To play the game, you need to swap adjacent elements to arrange them in the correct order.");
            Console.WriteLine("The goal is to get all elements back to their original positions.");
        }

        internal void LogGameStarted()
        {
            Console.WriteLine("Game started! Good luck!");
        }

        internal void LogStartGameInput()
        {
            Console.WriteLine("Press Enter to start the game...");
        }

        internal void LogInvalidStartGameInput()
        {
            Console.WriteLine("Invalid input. Please press Enter to start the game.");
        }

        internal void LogSelectGuide()
        {
            Console.WriteLine("Enter element to select:");
        }

        internal void LogSwapGuide()
        {
            Console.WriteLine("Enter element to swap:");
        }

        internal void LogElementSelected(GridElement gridElement)
        {
            Console.WriteLine($"Selected element [{gridElement.valuePiece}]");
        }

        internal void LogElementSwapped(GridElement first, GridElement second)
        {
            Console.WriteLine($"Swapped element [{first.valuePiece}] with element [{second.valuePiece}]");
        }

        internal void LogPuzzleShuffled()
        {
            Console.WriteLine("Puzzle shuffled!");
        }

        internal void LogInvalidInputFormat()
        {
            Console.WriteLine("Invalid input format. Please enter two numbers separated by a space.");
        }

        internal void LogInvalidCoordinates(int gridLength)
        {
            Console.WriteLine("Invalid number Coordinates. Please enter valid numbers within the range 0 to " + (gridLength - 1) + ".");
        }

        internal void InvalidSelectElementInput()
        {
            Console.WriteLine("Invalid select element input. Please enter valid numbers.");
        }

        internal void LogNotAdjacent(GridElement firstElement, GridElement secondElement)
        {
            Console.WriteLine($"Attempting to swap elements at positions {firstElement.currentIndex.x},{firstElement.currentIndex.y} and {secondElement.currentIndex.x},{secondElement.currentIndex.y}");

            Console.WriteLine("Selected elements are not adjacent. Please select adjacent elements to swap.");
        }

        internal void LogPuzzleSolved()
        {
            Console.WriteLine("Congratulations! You've solved the puzzle!");
        }

        internal void LogWin()
        {
            Console.WriteLine("You win!");
        } 

        internal void LogPlayAgain()
        {
            Console.WriteLine("Do you want to play again?");
        }
    }
}
