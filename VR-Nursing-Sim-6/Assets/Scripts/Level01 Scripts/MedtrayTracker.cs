using TMPro;
using UnityEngine;

public class MedtrayTracker : MonoBehaviour
{
    private bool isComplete = false;
    private float pillCounter = 0f;
    private TMP_Text winText;

     private void Awake()
    {
        winText = this.gameObject.GetComponentInChildren<TMP_Text>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (LevelManager.level01GameType == 1)
        {
            if (other.gameObject.name.Equals("Pill(Clone)") || other.gameObject.name.Equals("Pill"))
            {
                pillCounter++;
                CheckForWin();
            }
            else if (other.gameObject.name.Equals("PillHalf1") || other.gameObject.name.Equals("PillHalf2") || other.gameObject.name.Equals("PillHalf1(Clone)") || other.gameObject.name.Equals("PillHalf2(Clone)"))
            {
                pillCounter += 0.5f;
                CheckForWin();
            }
        }
        else if (LevelManager.level01GameType == 2)
        {
            if (other.gameObject.name.Equals("Patch(Clone)") || other.gameObject.name.Equals("Patch"))
            {
                PatchWrite sigCheck = other.gameObject.GetComponent<PatchWrite>();
                if (sigCheck.isWritten) CheckForWin();
            }
        }
        else if (LevelManager.level01GameType == 3)
        {
            if (other.gameObject.name.Equals("LiqMedCup(Clone)") || other.gameObject.name.Equals("LiqMedCup"))
            {
                CupFill medCheck = other.gameObject.GetComponent<CupFill>();
                if (medCheck.isFilled) CheckForWin();
            }
        }
        else
        {
            Debug.Log("NO GAME TYPE (TRIGGER)");
        }
    }

    private void CheckForWin()
    {
        if (LevelManager.level01GameType == 1)
        {
            if (pillCounter == 1.5) isComplete = true;
        }
        else if (LevelManager.level01GameType == 2 || LevelManager.level01GameType == 3)
        {
            isComplete = true;
        }
        else
        {
            Debug.Log("NO GAME TYPE (WIN CHECK)");
        }

        if (isComplete) ShowWin();

    }
    private void ShowWin()
    {
        winText.text = "Complete!";
        winText.color = new Color(0,1,0);
    }
}
