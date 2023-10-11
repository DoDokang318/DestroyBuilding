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
    }

    void Spawn()
    {
        for (int i = 0; i < PoolManager.Instance.Prefabs.Length; i++)
        {
            GameObject Block = PoolManager.Instance.Get(i);
        }
    }    
}
