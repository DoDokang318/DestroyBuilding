using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager :Singletone<GameManager>
{
    // ���� ó������ ������ üũ 
    // ���� �¸������� 
    // �������� ���� �ٺμ������� 
    //�����й� ,�¸����
    //
    public bool IsBlock;

    private bool gameOver;

    public int Life = 3;


    public bool GameOver { get { return gameOver; } set { gameOver = value; } }

}
