using UnityEngine;

[CreateAssetMenu(fileName = "Pill", menuName = "Scriptable Objects/Pill")]
public class Pill : ScriptableObject
{
    public float value = 1f;
    public GameObject pillBody;
}
