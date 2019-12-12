using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerNameLabel: MonoBehaviour
{
    //Forzar a Unity a serializar un campo privado
    //Serializar significa codificar un objeto a un medio de almacenamiento
    [SerializeField] Text textoPersonaje;

    
    void Start()
    {
    
        if (PlayerPrefs.HasKey("nombrePersonaje") == true)
        {
            textoPersonaje.text = "" + PlayerPrefs.GetString("nombrePersonaje").ToUpper();
        }
    }


}
