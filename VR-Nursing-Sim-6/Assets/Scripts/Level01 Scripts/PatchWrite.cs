using TMPro;
using Unity.VisualScripting;

//using Unity.VisualScripting;
using UnityEngine;

public class PatchWrite : MonoBehaviour
{
    public bool isWritten = false;
    private TMP_Text signature;

    private void Awake()
    {
        signature = this.gameObject.GetComponentInChildren<TMP_Text>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name.Equals("Sharpie"))
        {
            //Debug.Log("Is Written");
            isWritten = true;
            WriteSignature();
        }
    }
    
    public void WriteSignature()
    {
        signature.text = "Signed";
    }
    
}
