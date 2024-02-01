using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class buttonDeck : MonoBehaviour
{
    private Button btn;
    private Button btn2;
    public Transform CardContaineur;
    public classCarte[] deck;

    void Start()
    {
        CardContaineur = GameObject.Find("CardContaineur").transform;
        btn = GameObject.Find("Button (Legacy)").GetComponent<Button>();
        btn.onClick.AddListener(ButtonSelected);
        btn2 = GameObject.Find("Button Battle").GetComponent<Button>();
        btn2.onClick.AddListener(ButtonSelected2);
        GameManager.Instance.deck1 = deck;
    }
    void ButtonSelected()
    {
        if (GameManager.Instance.pioche)
        {
            float pos = GameManager.Instance.posDeck;
            int randomInt = Random.Range(0, deck.Length);
            string randomName = deck[randomInt].name;
            // Crée un nouvel objet GameObject
            GameObject nouvelCarte = new GameObject(randomName);
            nouvelCarte.tag = "Card";
            nouvelCarte.transform.parent = CardContaineur;

            // Ajoute un SpriteRenderer au nouvel objet
            SpriteRenderer spriteRenderer = nouvelCarte.AddComponent<SpriteRenderer>();

            // Assigne un sprite au SpriteRenderer
            // Assurez-vous d'avoir un sprite dans votre projet que vous pouvez assigner ici
            Sprite sprite = Resources.Load<Sprite>(randomName);

            if (sprite != null)
            {
                spriteRenderer.sprite = sprite;
                spriteRenderer.size = sprite.bounds.size;
            }

            BoxCollider2D boxCollider = nouvelCarte.AddComponent<BoxCollider2D>();

            // Ajoute le script CardHover à l'objet nouvellement créé
            CardHover cardHoverScript = nouvelCarte.AddComponent<CardHover>();

            // Vous pouvez également définir d'autres propriétés du SpriteRenderer
            spriteRenderer.color = Color.white;
            spriteRenderer.flipX = false;
            spriteRenderer.flipY = false;

            // Vous pouvez positionner l'objet comme vous le souhaitez
            nouvelCarte.transform.position = new Vector2(pos, -3.48f);
            nouvelCarte.transform.localScale = new Vector2(0.58f, 0.58f);
            spriteRenderer.sortingOrder = 1 + nouvelCarte.transform.GetSiblingIndex();
            GameManager.Instance.posDeck += 0.5f;
            GameManager.Instance.phase = 2;
            GameManager.Instance.pioche = false;
        }
    }
    
    void ButtonSelected2()
    {
        GameManager.Instance.phase = 3;
    }
    void OnDisable()
    {
        btn.onClick.RemoveListener(ButtonSelected);
        btn2.onClick.RemoveListener(ButtonSelected2);
    }
}
