using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour
{
    public void LoadAnimalsScene()
    {
        SceneManager.LoadScene("AnimalsScene");
    }

    public void LoadSeasonsScene()
    {
        SceneManager.LoadScene("SeasonsScene");
    }
}
