namespace AIBackendProject.RunGame;

public class BoardManager
{

    public Board Board { get; }

    public BoardManager()
    {
        Board = new Board();
    }

    public void AddMove((int column, int row) action, string currentPlayer)
    {
        if (ValidMove(action))
        {
            Board.State[action.column, action.row] = currentPlayer;
        }
        else
        {
            throw new Exception("An Illegal move was made somehow");
        }
    }

    public void ClearBoard()
    {
        for (var i = 0; i < 3; i++)
        {
            for (var l = 0; l < 3; l++)
            {
                Board.State[i, l] = null;
            }
        }
    }
    
    private bool ValidMove((int column, int row) action)
    {
        return Board.State[action.column, action.row] == null;
    }
    
    
}