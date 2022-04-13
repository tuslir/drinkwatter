using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuScript : MonoBehaviour
{

    public GameObject toffeSelect, tonjeSelect;
    public TextMeshProUGUI toffeText, tonjeText;

    public void ToffeSelect()
    {
        tonjeSelect.SetActive(false);
        toffeSelect.SetActive(true);
        toffeText.text = "Play as TOFFE?";
    }

    public void TonjeSelect()
    {
        toffeSelect.SetActive(false);
        tonjeSelect.SetActive(true);
        tonjeText.text = "Play as TONJE?";
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void NoPlay()
    {
        tonjeSelect.SetActive(false);
        toffeSelect.SetActive(false);
    }

    public void ToffePlay()
    {
        print("starting game as TOFFE");
        //add scene TOFFE
    }

    public void TonjePlay()
    {
        print("starting game as TONJE");
        //add scene TONJE
    }
}
