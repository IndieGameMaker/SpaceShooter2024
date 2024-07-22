using UnityEngine;

[CreateAssetMenu(fileName = "BarrelDataSO", menuName = "Scriptable Objects/BarrelDataSO")]
public class BarrelDataSO : ScriptableObject
{
    public GameObject expEffect;
    public AudioClip expSfx;
    public Texture[] textures;
}
