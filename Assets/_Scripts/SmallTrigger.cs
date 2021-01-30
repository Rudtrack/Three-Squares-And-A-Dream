using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallTrigger : MonoBehaviour
{
    public bool pressed;

    private FinishTrigger finishTrigger;

    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("CubeS"))
        {
            pressed = true;
        }
    }
}
