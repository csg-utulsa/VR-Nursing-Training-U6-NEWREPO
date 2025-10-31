using UnityEngine;

public class PillSplitter : MonoBehaviour
{
    [SerializeField]
    private GameObject halfPill_1;
    [SerializeField]
    private GameObject halfPill_2;
    [SerializeField]

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name.Equals("Pill(Clone)"))
        {
            Destroy(collision.gameObject);

            Instantiate(halfPill_1, collision.gameObject.transform.position, Quaternion.identity);
            Instantiate(halfPill_2, collision.gameObject.transform.position, Quaternion.identity);
        }
    }
}
