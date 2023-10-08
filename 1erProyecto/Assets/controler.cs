using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controler : MonoBehaviour
{
    // Start is called before the first frame update
   public void boton(string nombre)
   
   {
    SceneManager.LoadScene(nombre);
    }
}
