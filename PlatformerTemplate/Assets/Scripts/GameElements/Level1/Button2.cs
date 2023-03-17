using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Button2 : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite; 
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>() || collision.GetComponent<Caisse>())
        {
            GameObject objectB = GameObject.Find("Door");
            objectB.SendMessage("Open2");
            ChangeSprite();
            Debug.Log("Button2 pressed");
        }
    }

    public void Open()
    {
        Debug.Log("Button pressed");
        ChangeSprite();
    }
}
