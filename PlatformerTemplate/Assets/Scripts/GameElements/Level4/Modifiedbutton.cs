using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Modifiedbutton : MonoBehaviour
{
    public GameObject scriptToDisable;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>())
        {
            scriptToDisable.enabled = false;
        }
    }
}
