using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class main : MonoBehaviour
{
    public TMP_Text PV;
    public TMP_Text phases;
    private float mavariable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.player == 0)
        {
            mavariable = GameManager.Instance.PV1;
        }
        else
        {
            mavariable = GameManager.Instance.PV0;
        }
        string montext = mavariable.ToString();
        PV.text = montext;
        int phase = GameManager.Instance.phase;
        if (phase == 0)
        {
            phases.text = "Degagement";
            //debut desengagement
            //fin desengagement
            phase = 1;
        }

        if (phase == 1)
        {
            phases.text = "Pioche";
            //debut pioche
            GameManager.Instance.pioche = true;
            //fin pioche
        }
        if (phase == 2)
        {
            phases.text = "MP1";
        }
        if (phase == 3)
        {
            phases.text = "Combat";
        }
        if (phase == 4)
        {
            phases.text = "MP2";
        }

    }
}
