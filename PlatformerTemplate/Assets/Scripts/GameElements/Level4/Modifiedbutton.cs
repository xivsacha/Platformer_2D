using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Modifiedbutton : MonoBehaviour
{
    public GameObject otherObject;

    private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.GetComponent<PlayerController>())
    {
        // Détruit complètement l'objet "laser"
        Destroy(otherObject);
    }
}
}