using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScenePlay : MonoBehaviour
{
    public InputField inputField;


    void Start()
    {
        //Primero buscamos componentes, primero en Canvas
        //QUEDE EN 1 HORA Y 5 MINUTOS

        //controller = GameObject.Find("Canvas").transform.Find("");
        PlayerPrefs.DeleteAll();
        
    }

    public void SceneLoader(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }

    public void Save()
    {
        if (PlayerPrefs.HasKey("nombrePersonaje") == true)
        {
            Debug.Log(PlayerPrefs.GetString("nombrePersonaje"));
        }
        else
        {
            //Acá podes guardar todas los datos que vos quieras, podes guardar
            //ranking de jugadores y demás...            
            PlayerPrefs.SetString("nombrePersonaje", inputField.text);

            //Tambien se puede usar para otras cosas...
            //PlayerPref la clase esta implementada para guardar preferencia de usuarios
            //PlayerPrefs.SetInt("Rangking1" , PlayerPrefs.GetString("Ranking1"), 9);

            PlayerPrefs.Save();
            Debug.Log("Boton Presinado");
        }
    }

}
