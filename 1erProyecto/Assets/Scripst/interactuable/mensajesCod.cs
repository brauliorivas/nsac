using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartel1 : MonoBehaviour
{
    public string mensaje ;
    bool entro = false;

void Update () {}
void  OnGUI() {
	if(entro == true){GUI.Label(new Rect(Screen.width/2-100,50,200,30),mensaje);}
}
void OnTriggerEnter() 
 {	entro = true;}

void OnTriggerExit() {	entro = false;}

}
