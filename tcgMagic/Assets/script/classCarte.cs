using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Cartes/nouvelle carte")]
public class classCarte : ScriptableObject
{
        public string name;
        public int[] cost = new int[6]; // white , red, black, green, blue, incolore
        public string type;
        public string sousType;
        public int[] stats = new int[2];
        public string[] capacity = new string[3];
        public bool engagement;
}
