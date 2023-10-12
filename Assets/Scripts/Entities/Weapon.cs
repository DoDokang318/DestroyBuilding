using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int NuckBackForce = -10;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Block")
        {
            if (other.TryGetComponent(out Block block))
            {

                if (GameManager.Instance.IsAttack == true && GameManager.Instance.Isdefence == false)
                {
                    block.BlockHp--;
                    Debug.Log(block.BlockHp);
                }

                if (GameManager.Instance.IsAttack == false && GameManager.Instance.Isdefence == true)
                {
                    Rigidbody2D rb2d = other.gameObject.GetComponent<Rigidbody2D>();
                    if (rb2d != null)
                    {
                        Vector2 force = new Vector2(0, NuckBackForce);  // Y 방향으로 반대 방향 힘을 정의
                        rb2d.AddForce(force, ForceMode2D.Impulse);  // 힘을 적용
                    }

                }


                if (block.BlockHp <= 0)
                {

                    PoolManager.Instance.ReturnToPool(other.gameObject);
                }
            }

        }

    }
}
