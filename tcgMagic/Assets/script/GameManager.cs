using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static classCarte;

public class GameManager : MonoBehaviour
{
    public float pos0 = -8f;
    public float posDeck0 = -8f;
    public int PV0 = 20;
    public float pos1 = -8f;
    public float posDeck1 = -8f;
    public int PV1 = 20;
    public bool pioche;
    public int phase = 0;
    public int player = 0;
    public GameObject CardContaineur0;
    public GameObject CardContaineur1;
    public classCarte[] deck1;
    public static GameManager Instance;

    void Awake()
    {
        Instance = this;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
