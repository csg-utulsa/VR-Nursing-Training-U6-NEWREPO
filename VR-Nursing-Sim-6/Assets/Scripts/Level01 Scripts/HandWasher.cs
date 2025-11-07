using UnityEngine;
using UnityEngine.InputSystem;

public class HandWasher : MonoBehaviour
{
    private bool canWashHands = false;
    [SerializeField]
    private InputActionReference interactK; //For Keyboard Interaction
        [SerializeField]
    private InputActionReference interactVR; //For VR Interaction

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            canWashHands = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            canWashHands = false;
        }
    }
    void Update()
    {
        
    }
}
