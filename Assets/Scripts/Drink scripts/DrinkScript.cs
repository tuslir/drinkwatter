using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkScript : MonoBehaviour
{

    public ParticleSystem part;
    public AudioSource slurp;
    

    void Start()
    {
        part = GetComponent<ParticleSystem>();                                                      //Fetches Particle system on other object
        HydrationBarHandler.SetHealthBarValue(0f);                                                  //Sets start value to 0
        slurp = GetComponent<AudioSource>();
    }

    private void OnParticleCollision(GameObject other)                                              //Detects collision from Particles
    {
        HydrationBarHandler.SetHealthBarValue(HydrationBarHandler.GetHealthBarValue() +0.05f);     //Every time a particle hits, increase hydration by 0.05
        slurp.Play();
        Debug.Log("water drank, hydrationlevel currently" + HydrationBarHandler.GetHealthBarValue());                       
    }

   
}
