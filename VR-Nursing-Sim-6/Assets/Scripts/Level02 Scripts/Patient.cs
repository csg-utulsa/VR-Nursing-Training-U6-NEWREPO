using UnityEngine;

public class Patient : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (LevelManager.level01GameType == 1)
        {
            //take pain reading - conversation element TODO
            Level02Progress.hasProcessed = true;
            //wait for pill to be given
            if (other.gameObject.name.Equals("Pill"))
            {
               Level02Progress.hasGiven = true; 
            }
        }
        else if (LevelManager.level01GameType == 2)
        {
           //wait for area to be cleaned
           if (other.gameObject.name.Equals("Cloth"))
            {
                Level02Progress.hasProcessed = true;
            }
           //wait for patch to be given
           if (other.gameObject.name.Equals("Patch"))
            {
               Level02Progress.hasGiven = true; 
            }
        }
        else if (LevelManager.level01GameType == 3)
        {
            //wait for vitals to be taken
            if (other.gameObject.name.Equals("Vitals Meter"))
            {
                Level02Progress.hasProcessed = true;
            }
            //wait for cup to be given
            if (other.gameObject.name.Equals("LiqMedCup"))
            {
               Level02Progress.hasGiven = true; 
            }
        }
        else
        {
            Debug.Log("ERROR: NO GAME TYPE");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Level02Progress.conversationReady)
        {
            //TODO ADD STT-TTS
            Level02Progress.conversationComplete = true;
        }
    }
}
