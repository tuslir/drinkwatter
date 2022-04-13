using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{

    public GameObject pauseText;
    bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame()
    {

        if (!isPaused)
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

    public void UnPause()
    {
        if (isPaused)
        {

        }
    }

}
