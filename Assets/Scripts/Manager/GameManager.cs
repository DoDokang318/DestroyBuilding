using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager :Singletone<GameManager>
{
    // 게임 처음시작 했을시 체크 
    // 게임 승리했을시 
    // 내려오는 블럭이 다부서졌을시 
    //게임패배 ,승리등등
    //
    public bool IsBlock;

    private bool gameOver;

    public int Life = 3;


    public bool GameOver { get { return gameOver; } set { gameOver = value; } }

}
