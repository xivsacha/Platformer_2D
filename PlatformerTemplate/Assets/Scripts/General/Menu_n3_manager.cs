using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_n3_manager : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene(3);
    }

    public void Next_Level()
    {
        SceneManager.LoadScene(4);
    }

    public void Prev_Level()
    {
        SceneManager.LoadScene(2);
    }
}
