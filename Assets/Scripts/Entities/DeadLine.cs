using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadLine : MonoBehaviour
{



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Block")
        {
            GameManager.Instance.Life--;
            Debug.Log(GameManager.Instance.Life);
            if (GameManager.Instance.Life <=0)
            {
                GameManager.Instance.GameOver = true;
                if(GameManager.Instance.GameOver == true)
                {
                    Debug.Log("Die");
                }
            }
        }
    }
}
