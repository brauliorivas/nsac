using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartel1 :  interactuable
{   bool comprobador = true;
    public GameObject ObjetoaActivaroDesactivar ;
    public GameObject MovimientoJugador;
    public string Texto = "";
    
     void Start() {
    ObjetoaActivaroDesactivar.SetActive(false);  
    ;  
    }
    public void desactivar()
            { 
             comprobador = false;
            ObjetoaActivaroDesactivar.SetActive(true);
            MovimientoJugador.transform.GetComponent<playermove>().enabled = false;
             }
    public void activar()
          {
              comprobador = true;
            ObjetoaActivaroDesactivar.SetActive(false);
            MovimientoJugador.transform.GetComponent<playermove>().enabled = true;
           }


   public override void Interact() {
       base.Interact();
      if (comprobador == true) 
        {
            desactivar();
        } else 
        { activar();}
            }

}

