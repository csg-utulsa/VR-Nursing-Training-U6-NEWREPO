using UnityEngine;

public class CupFill : MonoBehaviour
{
    public bool isFilled = false;
    public float amountFilled;
    [SerializeField]
    private Mesh filledCup;
    [SerializeField]
    private Material[] filledArray;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name.Equals("LiquidMeds"))
        {
            Debug.Log("Collided");
            MeshFilter filter = this.gameObject.GetComponent<MeshFilter>();
            MeshRenderer renderer = this.gameObject.GetComponent<MeshRenderer>();

            isFilled = true;
            filter.mesh = filledCup;
            renderer.materials = filledArray;
        }

    }
}
