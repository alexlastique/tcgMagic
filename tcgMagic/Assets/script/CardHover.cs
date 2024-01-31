using UnityEngine;
using UnityEngine.UIElements;

public class CardHover : MonoBehaviour
{
    
    private SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void OnMouseOver()
    {
        sprite.sortingOrder = 99 + transform.GetSiblingIndex();
    }

    void OnMouseExit()
    {
        sprite.sortingOrder = 1 + transform.GetSiblingIndex();
    }

    void OnMouseDown()
    {
        if (tag== "Card")
        {
            float pos = GameManager.Instance.pos;
            float posInit = transform.position.x;
            transform.position = new Vector2(pos, -1.34f);
            tag = name;
            foreach (GameObject Card in GameObject.FindGameObjectsWithTag("Card"))
            {
                float posCardx = Card.transform.position.x;
                if (posCardx > posInit)
                {
                    Card.transform.position = new Vector2(posCardx - 0.5f, -3.48f);
                }
            }
            GameManager.Instance.pos += 1.4f;
            GameManager.Instance.posDeck -= 0.5f;

        }
    }
}
