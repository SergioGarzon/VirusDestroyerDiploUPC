using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{

    void Start()
    {
        //Se guarda en la memoria del dispositivo datos para despues cargarlo

    }


    public void SceneLoader(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);    
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
