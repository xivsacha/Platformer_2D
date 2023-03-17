using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Modifieddoor : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite; 
    }

    public void Open()
    {
        ChangeSprite();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>())
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
