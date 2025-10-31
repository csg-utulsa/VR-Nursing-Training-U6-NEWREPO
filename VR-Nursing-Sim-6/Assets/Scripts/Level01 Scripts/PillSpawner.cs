using UnityEngine;

public class PillSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject pill;
    [SerializeField]
    private GameObject patch;
    [SerializeField]
    private int cooldown = 3;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name.Equals("Pillbottle"))
        {
            //Destroy(collision.gameObject);

            Instantiate(pill, collision.gameObject.transform.position, Quaternion.identity);
            //mAKE IT WAIT
        }
        else if (collision.gameObject.name.Equals("Nitropatch"))
        {
            Instantiate(patch, collision.gameObject.transform.position, Quaternion.identity);
        }
    }
}
