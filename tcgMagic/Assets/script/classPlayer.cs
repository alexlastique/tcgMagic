using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public class Player
    {
        public int PV;
        public List<classCarte.Carte> main = new List<classCarte.Carte>();
        public List<classCarte.Carte> deck = new List<classCarte.Carte>();

        public void stat(int PV, string[] main, string[] deck)
        {
            this.PV = PV;
            for (int i = 0; i < main.Length; i++)
            {
                Debug.log(i);
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
