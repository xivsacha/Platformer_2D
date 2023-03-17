using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Modifiedbutton : MonoBehaviour
{
    public GameObject objectToDisappear;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>())
        {
            objectToDisappear.SetActive(false);
        }
    }
}
