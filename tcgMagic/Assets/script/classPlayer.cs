using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static classCarte;

public class classPlayer : MonoBehaviour
{
    public class Player
    {
        public int PV;
        public List<classCarte.Carte> main = new List<classCarte.Carte>();
        public List<classCarte.Carte> deck = new List<classCarte.Carte>();
        public List<classCarte.Carte> terrain = new List<classCarte.Carte>();
        public List<classCarte.Carte> creature = new List<classCarte.Carte>();
        public List<classCarte.Carte> permanent = new List<classCarte.Carte>();
        public List<classCarte.Carte> cimetiere = new List<classCarte.Carte>();
        public List<classCarte.Carte> exil = new List<classCarte.Carte>();

        public void stat(int PV, string[] mainArray, string[] deckArray)
        {
            this.PV = PV;

            classCarte.GetCartesListe maListe = new classCarte.GetCartesListe();
            Debug.Log("test");
            Debug.Log(maListe.cartesListe);

            // Ajouter des éléments à la liste 'main' à partir du tableau 'mainArray'
            foreach (classCarte.Carte cardName in maListe.cartesListe)
            {
                Debug.Log(cardName);
            }

            // Ajouter des éléments à la liste 'deck' à partir du tableau 'deckArray'
            //foreach (string cardName in deckArray)
            //{
            //    classCarte.Carte carte = new classCarte.Carte();
            //    carte.name = cardName;
            //    deck.Add(carte);
            //}

            // Ajouter des éléments à la liste 'deck' à partir du tableau 'deckArray'
            //foreach (string cardName in deckArray)
            //{
            //    classCarte.Carte carte = new classCarte.Carte();
            //    carte.name = cardName;
            //    deck.Add(carte);
            //}
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        Player player1 = new Player();
        player1.stat(20, new string[] { "fef", "fe", "fef" }, new string[] { "x", "xv", "cv" });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
