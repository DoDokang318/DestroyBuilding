using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform SpawnPoint;
    private void Awake()
    {
        SpawnPoint = GetComponent<Transform>();
       
    }
  
    private void Update()
    {
        Spawn();
        if ( GameManager.Instance.IsBlock == false)
        {                
            Spawn();
            
            GameManager.Instance.IsBlock = true;
        }
    }

    void Spawn()
    {
        GameObject Block = PoolManager.Instance.Get(0);

      
    }    

}
