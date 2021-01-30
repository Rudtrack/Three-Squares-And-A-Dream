using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumTrigger : MonoBehaviour
{
    public bool pressed;

    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("CubeM"))
        {
            pressed = true;
        }
    }
}
