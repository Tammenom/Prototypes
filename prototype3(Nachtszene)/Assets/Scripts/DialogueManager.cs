﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject dBox;
    public Text dText;
    public string[] dialogLines;
    public int currentLine;

    public bool dialogActive;
    private PlayerController thePlayer;

    

	// Use this for initialization
	void Start () {
        dBox.SetActive(false);
        dialogActive = false;
       
        thePlayer = FindObjectOfType<PlayerController>();

        
    }
	
	// Update is called once per frame
	void Update () {

        if (dialogActive && Input.GetKeyDown(KeyCode.Space))
        {

            //dBox.SetActive(false);
            //dialogActive = false;
            currentLine++;


            if (currentLine >= dialogLines.Length)
            {
                dBox.SetActive(false);
                dialogActive = false;

                currentLine = 0;
                thePlayer.canMove = true;
            }

            dText.text = dialogLines[currentLine];

        }
	}
    /*public void ShowBox(string dialogue)
    {
        dialogActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
    }*/

    public void ShowDialogue()
    {
        dialogActive = true;
        dBox.SetActive(true);
        thePlayer.canMove = false;
    }

}