using PuzzleGame;
using System;
internal class PuzzleGameManager
{
    PuzzleLogger logger;
    MoveHandler moveHandler;
    PuzzleSolutionChecker solutionChecker;

    int gridSize;

    GridElement[][] gridElements;

    Puzzle puzzle;

    ConsoleInputHandler inputHandler;
    PuzzleShuffler shuffler;
    public PuzzleGameManager()
    {
        StartMenu();
    }

    private void Initialize()
    {
        logger = new PuzzleLogger();
        moveHandler = new MoveHandler();
        solutionChecker = new PuzzleSolutionChecker();

        gridSize = 3;

        gridElements = new GridElement[gridSize][];
        for (int x = 0; x < gridElements.Length; x++)
        {
            gridElements[x] = new GridElement[gridSize];
            for (int y = 0; y < gridElements[x].Length; y++)
            {
                Vector2 currentIndex = new Vector2(x, y);
                gridElements[x][y] = new GridElement(currentIndex, currentIndex, x * gridSize + y + 1);
            }
        }

        puzzle = new Puzzle(gridElements);

        inputHandler = new ConsoleInputHandler(puzzle, logger);
        shuffler = new PuzzleShuffler(puzzle, moveHandler);
    }

    private void StartMenu()
    {
        Initialize();

        logger.LogWelcome();
        logger.LogInstructions();

        GameplayInput();
    }

    private void GameplayInput()
    {
        logger.LogStartGameInput();
        if (inputHandler.GetStartGameInput())
        {
            StartGameplay();
        }
    }

    private void StartGameplay()
    {
        logger.LogGameStarted();
        logger.DrawPuzzle(puzzle);

        shuffler.Shuffle();
        logger.LogPuzzleShuffled();

        do
        {
            logger.DrawPuzzle(puzzle);

            logger.LogSelectGuide();
            Vector2 input1 = inputHandler.SelectElement();
            GridElement firstElement = puzzle.GridElements[input1.x][input1.y];
            logger.LogElementSelected(firstElement);

            logger.LogSwapGuide();
            Vector2 input2 = inputHandler.SelectElement();
            GridElement secondElement = puzzle.GridElements[input2.x][input2.y];
            logger.LogElementSwapped(firstElement, secondElement);

            bool validMove = moveHandler.ElementsAdjacent(firstElement, secondElement);
            if (!validMove)
            {
                Console.WriteLine($"Attempting to swap elements at positions {firstElement.currentIndex.x},{firstElement.currentIndex.y} and {secondElement.currentIndex.x},{secondElement.currentIndex.y}");

                logger.LogNotAdjacent();
            }
            else
            {
                moveHandler.SwapElements(puzzle, firstElement, secondElement);
            }

        } while (!solutionChecker.CheckWinCondition(puzzle));

        logger.LogPuzzleSolved();
        logger.DrawPuzzle(puzzle);
        logger.LogWin();

        logger.LogPlayAgain();
        GameplayInput();
    }
}
