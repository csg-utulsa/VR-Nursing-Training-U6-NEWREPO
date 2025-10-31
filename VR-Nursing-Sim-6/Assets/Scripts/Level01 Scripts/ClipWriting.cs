using UnityEngine;
using TMPro;
using System;
using System.Diagnostics;

public class ClipWriting : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private TMP_Text instructions;

    private String pillInstructions = "Please give the patient 1.5 pills of ibuprofen";
    private String patchInstructions = "Please sign and give the patient a patch of nitroglycerin";
    private String liquidInstructions = "Please prepare a cup of digoxin for the patient";

    private void Awake()
    {
        instructions = this.gameObject.GetComponentInChildren<TMP_Text>();
    }

    private void Start()
    {
        WriteInstructions(LevelManager.level01GameType);
    }


    private void WriteInstructions(int index)
    {
        switch (index)
        {
            case (1):
                instructions.text = pillInstructions;
                break;
            case (2):
                instructions.text = patchInstructions;
                break;
            case (3):
                instructions.text = liquidInstructions;
                break;
            default:
                instructions.text = "ERROR: NO GAME TYPE SET";
                break;
        }
    }
    
}
