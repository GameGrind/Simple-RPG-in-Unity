using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class DialogueSystem : MonoBehaviour {
    public static DialogueSystem Instance { get; set; }
    public GameObject dialoguePanel;
    public string npcName;
    public List<string> dialogueLines = new List<string>();

    Button continueButton;
    TMPro.TextMeshProUGUI dialogueText, nameText;
    int dialogueIndex;

    // Use this for initialization
    void Awake () {
        continueButton = dialoguePanel.GetComponentInChildren<Button>();
        dialogueText = dialoguePanel.transform.GetChild(1).GetComponent<TMPro.TextMeshProUGUI>();
        nameText = dialoguePanel.transform.Find("Name").GetChild(0).GetComponentInChildren<TMPro.TextMeshProUGUI>();
        continueButton.onClick.AddListener(delegate { ContinueDialogue(); } );
        dialoguePanel.SetActive(false);


	    if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
	}
	
    public void AddNewDialogue(string[] lines, string npcName)
    {
        dialogueIndex = 0;
        dialogueLines = new List<string>();
        foreach(string line in lines)
        {
            dialogueLines.Add(line);
        }
        this.npcName = npcName;

        CreateDialogue();
    }

    public void CreateDialogue()
    {
        dialogueText.text = dialogueLines[dialogueIndex];
        nameText.text = npcName;
        dialoguePanel.SetActive(true);
    }

    public void ContinueDialogue()
    {
        if (dialogueIndex < dialogueLines.Count-1)
        {
            dialogueIndex++;
            dialogueText.text = dialogueLines[dialogueIndex];
        }
        else
        {
            dialoguePanel.SetActive(false);
        }

    }
}
