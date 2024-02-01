using UnityEngine;
using UnityEngine.UIElements;

public class CardHover : MonoBehaviour
{
    
    public int[] Cost = new int[6];
    public string[] Terrain = new string[5] {"Plaine","Montagne","Marais","Forêt","Île"};
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
        bool testCout = true;
        classCarte[] deck = GameManager.Instance.deck1;
        foreach (classCarte deck2 in deck)
        {
            if (deck2.name == name)
            {
                Cost = deck2.cost;
            }
        }
        foreach (int cout in Cost)
        {
            if (cout != 0)
            {
                testCout = false; break;
            }
        }
        if (tag == "Card" && testCout)
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
        int i = 0;
        testCout = true;
        int total = 0;
        foreach (int cout in Cost)
        {
            int j = 0;
            if (i < 5)
            {
                foreach (GameObject Card in GameObject.FindGameObjectsWithTag(Terrain[i]))
                {
                    j++;
                    total++;
                }
                if (j < cout)
                {
                    testCout = false;
                }
            }
            else
            {
                if (total < cout)
                {
                    testCout = false;
                }
            }
            i++;
        }
        if (tag == "Card" && testCout)
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
