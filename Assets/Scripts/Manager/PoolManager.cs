using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : Singletone<PoolManager>
{

    public GameObject Spawner;
    public GameObject[] Prefabs;
    public int size;
    List<GameObject>[] Pools;


    private void Awake()
    {
        //foreach (var pool in pools)
        //{
        //    Queue<GameObject> objectPool = new Queue<GameObject>();
        //    for (int i = 0; i < pool.size; i++)
        //    {
        //        GameObject obj = Instantiate(pool.prefab);
        //        obj.SetActive(false);
        //        objectPool.Enqueue(obj);
        //    }
        //    poolDictionary.Add(pool.tag, objectPool);
        //}
    }





    //public GameObject Get(int index)
    //{
    //    GameObject select = null;

    //    foreach (GameObject item in Pools[index])
    //    {
    //        if (item.activeSelf)
    //        {
    //            select = item;
    //            select.SetActive(true);
    //            break;
    //        }
    //    }

    //    if (!select)
    //    {
    //        select = Instantiate(Prefabs[index], Spawner.transform);
    //        select.SetActive(true);
    //        Pools[index].Add(select);
    //    }

    //    return select;
    //}
}