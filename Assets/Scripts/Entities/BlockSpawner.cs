using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform SpawnPoint;
    bool isSpawn = true;
    private void Awake()
    {
        SpawnPoint = GetComponent<Transform>();

    }

    private void Update()
    {
        if (isSpawn == true)
        {
            Spawn();
            isSpawn = false;
        }
    }

    void Spawn()
    {
        PoolManager.Instance.SpawnFromPool();     
        Debug.Log("Spawn");

    }
}
