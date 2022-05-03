using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SceneController : MonoBehaviour
{
    private DialogueRunner dialogueRunner;
    //private FadeLayer fadeLayer;
    private void Awake()
    {
        // get handles of utility objects in the scene that we need
        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
        //fadeLayer = FindObjectOfType<FadeLayer>();
        //dialogueRunner.AddCommandHandler<Location>("camera", MoveCamera);

        // <<camera NAME_OF_LOCATION>>

        // <<fadeIn DURATION>> and <<fadeOut DURATION>>
        //dialogueRunner.AddCommandHandler<float>("fadeIn", FadeIn);
        //dialogueRunner.AddCommandHandler<float>("fadeOut", FadeOut);

        Debug.Log("SceneConductor created.");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
