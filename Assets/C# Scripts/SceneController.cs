using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SceneController : MonoBehaviour
{
    private DialogueRunner dialogueRunner;
    private FadeLayer fadeLayer;

    private void Awake()
    {
        // get handles of utility objects in the scene that we need
        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
        fadeLayer = FindObjectOfType<FadeLayer>();
        dialogueRunner.AddCommandHandler<Location>("camera", MoveCamera);

        // <<camera NAME_OF_LOCATION>>

        // <<fadeIn DURATION>> and <<fadeOut DURATION>>
        dialogueRunner.AddCommandHandler<float>("fadeIn", FadeIn);
        dialogueRunner.AddCommandHandler<float>("fadeOut", FadeOut);

        Debug.Log("SceneConductor created.");
    }

    private void MoveCamera(Location location)
    {
        Transform destination = location.GetMarkerWithName("Camera");
        if (destination != null)
        {
            Camera.main.transform.position = destination.position;
            Camera.main.transform.rotation = destination.rotation;
            Debug.Log($"Main Camera moved to {location.name}>Camera.");
        }
    }

    private Coroutine FadeIn(float time = 1f)
    {
        Debug.Log($"Fading in from black over {time} seconds.");
        return StartCoroutine(fadeLayer.ChangeAlphaOverTime(0, time));
    }

    private Coroutine FadeOut(float time = 1f)
    {
        Debug.Log($"Fading out to black over {time} seconds.");
        return StartCoroutine(fadeLayer.ChangeAlphaOverTime(1, time));
    }
}
