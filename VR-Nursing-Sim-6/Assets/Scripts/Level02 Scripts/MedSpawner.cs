using UnityEngine;

public class MedSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject pill;
    [SerializeField]
    private GameObject pillHalf;
    [SerializeField]
    private GameObject patch;
        [SerializeField]
    private GameObject liquid;
    [SerializeField]
    private GameObject cloth;
    [SerializeField]
    private GameObject vitalsMeter;

    public void Start()
    {
        if (LevelManager.level01GameType == 1)
        {
            Instantiate(pill, this.transform.position, Quaternion.identity);
            Instantiate(pillHalf, this.transform.position, Quaternion.identity);
            Instantiate(pillHalf, this.transform.position, Quaternion.identity);
        }
        else if (LevelManager.level01GameType == 2)
        {
           Instantiate(patch, this.transform.position, Quaternion.identity);
           Instantiate(cloth, this.transform.position, Quaternion.identity);
        //    PatchWrite sig = patch.GetComponent<PatchWrite>();
        //    sig.WriteSignature();
        }
        else if (LevelManager.level01GameType == 3)
        {
            Instantiate(liquid, this.transform.position, Quaternion.identity);
            Instantiate(vitalsMeter, this.transform.position, Quaternion.identity);
            // CupFill fill = patch.GetComponent<CupFill>();
            // fill.Fill();
        }
        else
        {
            Debug.Log("ERROR: NO GAME TYPE");
        }


    }
}
