using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classCarte : MonoBehaviour
{
    public class Carte
    {
        public string name;
        public int[] cost = new int[6]; // white , red, black, green, blue, incolore
        public string type;
        public string sousType;
        public int[] stats = new int[2];
        public string[] capacity = new string[3];

        public void stat(string name, int[] cost, string type, string sousType, int[] stats, string[] capacity)
        {
            this.name = name;
            this.cost = cost;
            this.type = type;
            this.sousType = sousType;
            this.stats = stats;
            this.capacity = capacity;

        }
        
    }
    // Start is called before the first frame update
    void Awake()
    {
        Carte TerrainPlaine = new Carte();
        TerrainPlaine.stat("Plaine", new int [] { 0, 0, 0, 0, 0, 0}, "Terrain de base", "plaine", new int[] { 0, 0}, new string[] { "", "", ""});

        Carte TerrainMontagne = new Carte();
        TerrainMontagne.stat("Montagne", new int[] { 0, 0, 0, 0, 0, 0}, "Terrain de base", "montagne", new int[] { 0, 0}, new string[] { "", "", ""});

        Carte TerrainMarais = new Carte();
        TerrainMarais.stat("Marais", new int[] { 0, 0, 0, 0, 0, 0}, "Terrain de base", "marais", new int[] { 0, 0}, new string[] { "", "", ""});

        Carte TerrainForet = new Carte();
        TerrainForet.stat("Foret", new int[] { 0, 0, 0, 0, 0, 0}, "Terrain de base", "foret", new int[] { 0, 0}, new string[] { "", "", ""});

        Carte TerrainIle = new Carte();
        TerrainIle.stat("Île", new int[] { 0, 0, 0, 0, 0, 0}, "Terrain de base", "île", new int[] { 0, 0}, new string[] { "", "", ""});

        Carte RelieurAmes = new Carte();
        RelieurAmes.stat("Relieur D'âmes", new int[] { 1, 0, 0, 0, 0, 0}, "Créature", "humain et clerc", new int[] { 1, 1}, new string[] { "", "", ""});

        Carte EphemeropteresStoique = new Carte();
        EphemeropteresStoique.stat("Éphéméroptères stoïque", new int[] { 1, 0, 0, 0, 0, 2}, "Créature", "esprit", new int[] { 5, 5}, new string[] { "Defenseur", "Vol", ""});

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
