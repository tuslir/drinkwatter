using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptHydration : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        HydrationBarHandler.SetHealthBarValue(1);
    }

    // Update is called once per frame
    void Update()
    {
        HydrationBarHandler.SetHealthBarValue(HydrationBarHandler.GetHealthBarValue() - 0.01f);
    }
}
