using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static classCarte;

public class GameManager : MonoBehaviour
{
    public float pos = -8f;
    public float posDeck = -8f;
    public bool pioche;
    public int phase = 0;
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
