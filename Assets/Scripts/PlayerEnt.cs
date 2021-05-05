using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to play audio when the player triggers a collider.
public class PlayerEnt : MonoBehaviour
{
    //public GameObject Plane;
    //public Animator anim;
    public AudioSource audioSource;
    public AudioSource planecrash;
    public bool hasPlayed;

    public GameObject Plane;
    public Animator animatio;

    // Start is called before the first frame update

    void OnTriggerEnter(Collider other) 
    {

        if (hasPlayed == false) 
        {
        //Play sound. I actually made the background audio as well in FL Studio! 
             audioSource.Play();
             //Plane crash taken from youtube. 
             planecrash.Play();
             hasPlayed = true;

            Plane.GetComponent<Animator>().Play("Test");
        } else {
            //Dont play! This prevents player from running back over and replaying the sound.
        }
    }
}
