using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : Singletone<PoolManager>
{

    public GameObject Spawner;
    public GameObject[] Prefabs;

    List<GameObject>[] Pools;


    private void Awake()
    {
        Pools = new List<GameObject>[Prefabs.Length];


        for (int index = 0; index < Pools.Length; index++)
        {
            Pools[index] = new List<GameObject>();
        }
    }


    public GameObject Get(int index)
    {
        GameObject select = null;

        foreach (GameObject item in Pools[index])
        {
            if (item.activeSelf)
            {
                select = item;
                select.SetActive(true);
                break;
            }
        }

        if (!select)
        {
            select = Instantiate(Prefabs[index], Spawner.transform);
            select.SetActive(true);
            Pools[index].Add(select);
        }

        return select;
    }
}