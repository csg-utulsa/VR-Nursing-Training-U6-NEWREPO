using UnityEngine;

public class Level02Progress : MonoBehaviour
{
    public bool hasProcessed = false;
    public bool hasGiven = false;
    public bool conversationReady = false;
    public bool conversationComplete = false;
    
    // Update is called once per frame
    void Update()
    {
        switch (LevelManager.Level01GameType) {
            case 1:
                //take pain rating
                //give pill
                conversationReady = true;
                break;
            case 2:
                //clean area
                //give patch
                conversationReady = true;
                break;
            case 3:
                //take vitals
                //give liquid
                conversationReady = true;
                break;
            default:
                Debug.LogWarning("INVALID GAME TYPE!");
                break;
        }
    }
}
