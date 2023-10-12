using System.Collections.Generic;
using UnityEngine;

public class PoolManager : Singletone<PoolManager>
{
    public GameObject Spawner;
    public GameObject Prefabs;
    public int size;

    Queue<GameObject> objectPool = new Queue<GameObject>();

    private void Awake()
    {
        for (int i = 0; i < size; i++)
        {
            GameObject obj = Instantiate(Prefabs, Spawner.transform);
            obj.SetActive(false);
            objectPool.Enqueue(obj);
            Debug.Log(" Enqueue(obj);");
        }
    }

    public void SpawnFromPool()
    {
        Debug.Log(" SpawnFromPool()");
        if (objectPool.Count > 0)
        {
            Debug.Log(" Dequeue();");
            GameObject obj = objectPool.Dequeue();
            obj.SetActive(true);
          
        }
      
    }

    public void ReturnToPool(GameObject obj)
    {
        obj.SetActive(false);

        objectPool.Enqueue(obj); // 사용한 오브젝트를 객체 풀에 반환
    }
}
