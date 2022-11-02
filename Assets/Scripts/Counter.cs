using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{

    PlayerController playerControllerScript;

    AudioSource audioController;
    [SerializeField] AudioClip pointsSound;



    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        audioController = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("ColliderBox"))
        {
            
            playerControllerScript.counter++;
            audioController.PlayOneShot(pointsSound, 1f);
        }
            
    }
}
