using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonDeck : MonoBehaviour
{
    private Button btn;
    private string[] img = new string[6] {"foret","ile","marais","montagne","plaine", "RelieurDAmes" };
    public Transform CardContaineur;
    public classCarte[] deck;

    void Start()
    {
        CardContaineur = GameObject.Find("CardContaineur").transform;
        btn = GameObject.Find("Button (Legacy)").GetComponent<Button>();
        btn.onClick.AddListener(ButtonSelected);
    }
    void ButtonSelected()
    {
        float pos = GameManager.Instance.posDeck;
        string random = img[Random.Range(0, 6)];
        // Crée un nouvel objet GameObject
        GameObject nouvelCarte = new GameObject(random);
        nouvelCarte.tag = "Card";
        nouvelCarte.transform.parent = CardContaineur;

        // Ajoute un SpriteRenderer au nouvel objet
        SpriteRenderer spriteRenderer = nouvelCarte.AddComponent<SpriteRenderer>();

        // Assigne un sprite au SpriteRenderer
        // Assurez-vous d'avoir un sprite dans votre projet que vous pouvez assigner ici
        Sprite sprite = Resources.Load<Sprite>(random);

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

    }
    void OnDisable()
    {
        btn.onClick.RemoveListener(ButtonSelected);
    }
}
