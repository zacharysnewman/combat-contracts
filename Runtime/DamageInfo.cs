using UnityEngine;

[System.Serializable]
public struct DamageInfo
{
    public float Amount;
    public Vector3 Point;
    public Vector3 Direction;
    public GameObject Instigator;
    public string SourceTag;
}
