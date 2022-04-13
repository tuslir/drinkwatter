using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkScript : MonoBehaviour
{

    public ParticleSystem part;
    

    void Start()
    {
        part = GetComponent<ParticleSystem>();              //Fetches Particle system on other object
    }

    private void OnParticleCollision(GameObject other)      //Detects collision from Particles
    {
        Debug.Log("water drank");                       
    }

   
}
