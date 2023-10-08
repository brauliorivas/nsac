using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mensajes : MonoBehaviour
{
    
    public Texture2D Imagen;
    public string mensaje ;
    bool entro = false;

void Update () {}
void  OnGUI() {
	if(entro == true){GUI.Label(new Rect(Screen.width/2-100,50,200,30),Imagen);}
}
void OnTriggerEnter() 
 {	entro = true;}

void OnTriggerExit() {	entro = false;}

}

