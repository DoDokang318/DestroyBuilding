public class GameManager : Singletone<GameManager>
{

    // 게임 승리했을시 

    //게임패배 ,승리등등
    //
    public bool IsBlock;
    public bool IsAttack;
    public bool Isdefence;

    private bool gameOver;

    public int Life = 3;


    public bool GameOver { get { return gameOver; } set { gameOver = value; } }

}
