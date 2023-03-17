using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door1 : MonoBehaviour
{

    private bool _openCondition1 = false;
    private bool _openCondition2 = false;

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
}