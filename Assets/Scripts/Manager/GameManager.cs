public class GameManager : Singletone<GameManager>
{

    // ���� �¸������� 

    //�����й� ,�¸����
    //
    public bool IsBlock;
    public bool IsAttack;
    public bool Isdefence;

    private bool gameOver;

    public int Life = 3;


    public bool GameOver { get { return gameOver; } set { gameOver = value; } }

}
