using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishTrigger : MonoBehaviour
{
    public Text gameWon;

    private void OnTriggerStay(Collider other)
    {
        gameWon.text = "You escaped! Press F to go back to main menu";

        if(Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(0);
        }
    }
}
