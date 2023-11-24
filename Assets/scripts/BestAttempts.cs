using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BestAttempts : MonoBehaviour
{
    private int SC;
    private void Update()
    {
       SC = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>().score;
    }
    private void Aggiorna()
    {

    }
    //if (SC==20)
   // {
        //private int BS = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameControllerScript>().attempts;
    //private Aggiorna();
    //}
}
