using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject text;
    public GameObject playerSprite;
    public GameObject NPCSprite;
    void Start()
    {
        text.gameObject.SetActive(false);
        playerSprite.gameObject.SetActive(false);
        NPCSprite.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        text.gameObject.SetActive(true);
        playerSprite.gameObject.SetActive(true);
        NPCSprite.gameObject.SetActive(true);
    }
}
