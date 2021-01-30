using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeTrigger : MonoBehaviour
{
    public bool pressed;

    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("CubeL"))
        {
            pressed = true;
        }
    }
}
