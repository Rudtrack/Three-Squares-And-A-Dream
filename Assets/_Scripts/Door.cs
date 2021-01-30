using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public AudioSource sound;

    public SmallTrigger smallTrigger;
    public MediumTrigger mediumTrigger;
    public LargeTrigger largeTrigger;
    

    private void Awake()
    {
        //sound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(smallTrigger.pressed == true && mediumTrigger.pressed == true && largeTrigger.pressed)
        {
            sound.Play();
            Invoke("DisableDoor", 0.5f);
        }
    }

    private void DisableDoor()
    {
        gameObject.SetActive(false);
    }
}
