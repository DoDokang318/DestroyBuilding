using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public BlockSO blockSO;

    int BlockHp;
    private void Start()
    {
        BlockHp = blockSO.BlockHp;

    }

}

