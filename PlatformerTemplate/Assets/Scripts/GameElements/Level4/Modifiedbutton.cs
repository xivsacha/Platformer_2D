using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Modifiedbutton : MonoBehaviour
{
    public GameObject otherObject;

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite; 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>())
        {
            // Détruit complètement l'objet "laser"
            Destroy(otherObject);
            ChangeSprite();
            GameObject objectB = GameObject.Find("Door");
            objectB.SendMessage("Open");
        }
    }
}