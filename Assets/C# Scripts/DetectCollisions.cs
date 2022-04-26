using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Yarn.Unity;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject text;
    public GameObject playerSprite;
    public GameObject NPCSprite;
    private DialogueRunner dialogueRunner;


    void Start()
    {
        //text.gameObject.SetActive(false);
        playerSprite.gameObject.SetActive(false);
        NPCSprite.gameObject.SetActive(false);
        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //text.gameObject.SetActive(true);
        playerSprite.gameObject.SetActive(true);
        NPCSprite.gameObject.SetActive(true);
    }
    
    private void StartText()
    {

    }
}
