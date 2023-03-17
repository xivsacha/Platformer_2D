using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door1 : MonoBehaviour
{

    private bool _openCondition1 = false;
    private bool _openCondition2 = false;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite; 
    }

    void Open1()
    {
        _openCondition1 = true;
    }

    void Open2()
    {
        _openCondition2 = true;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>() && _openCondition1 && _openCondition2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void Update()
    {
        if (_openCondition1 && _openCondition2)
        {
            ChangeSprite();
        }
    }
}