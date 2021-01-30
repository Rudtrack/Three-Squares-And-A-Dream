using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CubeM : MonoBehaviour
{
    private NavMeshAgent agent;
    private bool dead = false;
    private AudioSource sound;

    public Text gameOver;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agent.destination = hit.point;
                sound.Play();
            }
        }

        if (Input.GetKeyDown(KeyCode.F) && dead == true)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Death()
    {
        gameOver.text = "You died! Press F to go back to main menu";
        dead = true;
        Time.timeScale = 0;
    }
}
