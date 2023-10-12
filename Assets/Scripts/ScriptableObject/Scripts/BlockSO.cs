using UnityEngine;

[CreateAssetMenu(
    fileName = " BlockData",
    menuName = "Scriptable Object/ BlockData",
    order = int.MaxValue
)]
public class BlockSO : ScriptableObject
{
    public string BlockName;
    public string BlockTag;

    public int BlockHp;

    public float BlockSpeed;


}
