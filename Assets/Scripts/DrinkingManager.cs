using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkingManager : MonoBehaviour
{
    [Header("WinGame Screen goes here, must be inactive beforehand")]
    public GameObject youWonGame;

    private void Update()
    {
        if (HydrationBarHandler.GetHealthBarValue() == 1f)
        {
            win();
        }
    }

    private void win()
    {
        youWonGame.SetActive(true);
    }
}
