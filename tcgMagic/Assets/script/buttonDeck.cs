using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class buttonDeck : MonoBehaviour
{
    private Button btn;
    private float pos = -8f;

    void Start()
    {
        btn = GameObject.Find("Button (Legacy)").GetComponent<Button>();
        btn.onClick.AddListener(ButtonSelected);
    }
    void ButtonSelected()
    {
        // Crée un nouvel objet GameObject
        GameObject nouvelCarte = new GameObject("Carte");

        // Ajoute un SpriteRenderer au nouvel objet
        SpriteRenderer spriteRenderer = nouvelCarte.AddComponent<SpriteRenderer>();

        // Assigne un sprite au SpriteRenderer
        // Assurez-vous d'avoir un sprite dans votre projet que vous pouvez assigner ici
        Sprite sprite = Resources.Load<Sprite>("Forest");

        if (sprite != null)
        {
            spriteRenderer.sprite = sprite;
            spriteRenderer.size = sprite.bounds.size;
        }
        // Vous pouvez également définir d'autres propriétés du SpriteRenderer
        spriteRenderer.color = Color.white;
        spriteRenderer.flipX = false;
        spriteRenderer.flipY = false;

        // Vous pouvez positionner l'objet comme vous le souhaitez
        nouvelCarte.transform.position = new Vector2(pos, -3.48f);
        nouvelCarte.transform.localScale = new Vector2(0.2f, 0.2f);
        pos += 0.2f;

    }
    void OnDisable()
    {
        btn.onClick.RemoveListener(ButtonSelected);
    }
}
