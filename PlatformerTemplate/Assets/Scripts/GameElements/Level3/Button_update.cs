using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Button_update : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    private int _isColliding = 0;

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite; 
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>() || collision.GetComponent<Caisse>())
        {
            _isColliding += 1;
            Debug.Log("Pressed");
            Debug.Log(_isColliding);
        }
    }

    void OntriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>() && collision.GetComponent<Caisse>())
        {
            _isColliding -= 1;
            Debug.Log("Released");
            Debug.Log(_isColliding);
        }
    }

    public void Open()
    {
        Debug.Log("Button pressed");
        ChangeSprite();
    }

    void Update()
    {
        if (_isColliding > 0)
        {
            GameObject objectB = GameObject.Find("Door");
            objectB.SendMessage("Open");
        }

        else {
            GameObject objectB = GameObject.Find("Door");
            objectB.SendMessage("Close");
        }
    }
}
