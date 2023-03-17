using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_n2_manager : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene(6);
    }

    public void Next_Level()
    {
        SceneManager.LoadScene(3);
    }

    public void Prev_Level()
    {
        SceneManager.LoadScene(1);
    }
}
