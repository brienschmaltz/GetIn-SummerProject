using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onClick : MonoBehaviour
{
public GameObject Elevator;
public Animator anim;
public Button yourButton;
public AudioSource audioData;
	void Start () {

	}
	void Update () {
        if (Input.GetKey(KeyCode.E)) 
        {
            Elevator.GetComponent<Animator>().Play("New Animation");
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
        }
	}
}

/*	void Start () {
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(PlayAnimation);
	}
    public void PlayAnimation()
    {
        anim.Play("New Animation"); 
    }*/