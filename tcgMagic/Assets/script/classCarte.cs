using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classCarte : MonoBehaviour
{
    public class GetCartesListe
    {
        public List<Carte> cartesListe = new List<Carte>();

        public void ListCartes(Carte carteCreate)
        {
            this.cartesListe.Add(carteCreate);
        }
    }

    public class Carte
    {
        public string name;
        //public int[] cost = new int[6]; // white , red, black, green, blue, incolore
        //public string type;
        //public string sousType;
        //public int[] stats = new int[2];
        //public string[] capacity = new string[3];
        //public bool engagement;

        //public void stat(string name, int[] cost, string type, string sousType, int[] stats, string[] capacity)
        //{
        //    this.name = name;
        //    this.cost = cost;
        //    this.type = type;
        //    this.sousType = sousType;
        //    this.stats = stats;
        //    this.capacity = capacity;
        //    this.engagement = false;
        //}
        
    }

    // Start is called before the first frame update
    void Awake()
    {
        //GetCartesListe cartesListe = new GetCartesListe(); //A sauvegarder !!!

        //Carte TerrainPlaine = new Carte();
        //TerrainPlaine.stat("Plaine", new int [] { 0, 0, 0, 0, 0, 0}, "Terrain de base", "plaine", new int[] { 0, 0}, new string[] { "", "", ""});
        //cartesListe.ListCartes(TerrainPlaine);

        //Carte TerrainMontagne = new Carte();
        //TerrainMontagne.stat("Montagne", new int[] { 0, 0, 0, 0, 0, 0}, "Terrain de base", "montagne", new int[] { 0, 0}, new string[] { "", "", ""});
        //cartesListe.ListCartes(TerrainMontagne);

        //Carte TerrainMarais = new Carte();
        //TerrainMarais.stat("Marais", new int[] { 0, 0, 0, 0, 0, 0}, "Terrain de base", "marais", new int[] { 0, 0}, new string[] { "", "", ""});
        //cartesListe.ListCartes(TerrainMarais);

        //Carte TerrainForet = new Carte();
        //TerrainForet.stat("Foret", new int[] { 0, 0, 0, 0, 0, 0}, "Terrain de base", "foret", new int[] { 0, 0}, new string[] { "", "", ""});
        //cartesListe.ListCartes(TerrainForet);

        //Carte TerrainIle = new Carte();
        //TerrainIle.stat("Île", new int[] { 0, 0, 0, 0, 0, 0}, "Terrain de base", "île", new int[] { 0, 0}, new string[] { "", "", ""});
        //cartesListe.ListCartes(TerrainIle);

        //Carte RelieurAmes = new Carte();
        //RelieurAmes.stat("Relieur D'âmes", new int[] { 1, 0, 0, 0, 0, 0}, "Créature", "humain et clerc", new int[] { 1, 1}, new string[] { "", "", ""});
        //cartesListe.ListCartes(RelieurAmes);

        //Carte EphemeropteresStoique = new Carte();
        //EphemeropteresStoique.stat("Éphéméroptères stoïque", new int[] { 1, 0, 0, 0, 0, 2}, "Créature", "esprit", new int[] { 5, 5}, new string[] { "Defenseur", "Vol", ""});
        //cartesListe.ListCartes(EphemeropteresStoique);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
