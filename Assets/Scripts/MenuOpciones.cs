using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOpciones : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void Jugar()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Update is called once per frame
    public void Salir()
    {
        Application.Quit();
    }
}
