using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int phase = GameManager.Instance.phase;
        if (phase == 0)
        {
            //debut desengagement
            //fin desengagement
            phase = 1;
        }

        if (phase == 1)
        {
            //debut pioche
            GameManager.Instance.pioche = true;
            //fin pioche
        }

        if (phase == 2)
        {
            //debut main phase 1
            //fin main phase 1
        }

        if (phase == 3)
        {
            //debut battle
            //fin battle
        }

        if (phase == 4)
        {
            //debut main phase 2
            //fin main phase 2
        }
    }
}
