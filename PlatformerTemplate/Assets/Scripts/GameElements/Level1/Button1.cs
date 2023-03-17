using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Button1 : MonoBehaviour
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
            objectB.SendMessage("Open1");
            Debug.Log("Button1 pressed");
        }
    }

    public void Open()
    {
        Debug.Log("Button pressed");
        ChangeSprite();
    }
}
