using System.ComponentModel.DataAnnotations.Schema;

namespace AIBackendProject.RunGame;

public class GameManager
{
    public BoardManager _boardManager = new BoardManager();
    //REMOVE board paramenter. NOBODY SHOULD HAVE ACCESS BESIDES GAME-MANAGER

    private string X = "X";
    private string O = "O";
    
    public string GetCurrentPlayer(Board board)
    {
        int playerXMoves = 0;
        int playerYMoves = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int l = 0; l < 3; l++)
            {
                if (board.State[i, l] == X)
                {
                    playerXMoves++;
                }
                else if (board.State[i, l] == O)
                {
                    playerYMoves++;
                }
            }
        }

        return playerXMoves < playerYMoves ? X : O;
    }

    public List<(int, int)> PossibleActions(Board board)
    {
        List<(int, int)> possibleActions = new List<(int, int)>();
        for (int i = 0; i < 3; i++)
        {
            for (int l = 0; l < 3; l++)
            {
                if (board.State[i, l] == null)
                {
                    possibleActions.Add((i, l));
                }
            }
        }
        return possibleActions;
    }

    public Board MoveResult(Board board, (int column, int row) action)
    {
        string[,] copiedBoard = {};
        Array.Copy(copiedBoard, board.State, board.State.Length);
        if (copiedBoard[action.column, action.row] == null)
        {
            _boardManager.AddMove(action, GetCurrentPlayer(copiedBoard));   
        }
        return null;
    }

    public void Winner(Board board)
    {
        
    }

    public bool Terminal(Board board)//is game over?
    {
        return false;
    }

    public int Utility(Board board)
    {
        return -10000;
    }
    
    
    
}