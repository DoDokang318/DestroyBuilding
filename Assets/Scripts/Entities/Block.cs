using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public BlockSO blockSO;

    public int BlockHp { get; set; }
    private void Start()
    {
        BlockHp = blockSO.BlockHp;
    }

}

