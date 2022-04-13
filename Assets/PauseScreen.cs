using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{

    public GameObject pauseText;
    bool isPaused;
    public static bool gameWon;

    // Start is called before the first frame update
    void Start()
    {
        gameWon = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {


            if(!isPaused&&!gameWon)
            {
            isPaused = true;
            print("paused");
            Time.timeScale = 0;
            pauseText.SetActive(true);
            }
        else
        {
            isPaused = false;
            print("unpaused");
            Time.timeScale = 1;
            pauseText.SetActive(false);
        }
        }

    }

    public void PauseGame()
    {


    }

    public void UnPause()
    {
        if (isPaused)
        {

        }
    }

}
