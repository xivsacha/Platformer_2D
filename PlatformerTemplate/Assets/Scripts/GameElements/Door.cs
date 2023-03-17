using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{

    private bool _openCondition = false;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite; 
    }

    void Open()
    {
        _openCondition = true;
        ChangeSprite();
    }

    void Close()
    {
        _openCondition = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>() && _openCondition)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}