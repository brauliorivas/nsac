using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swicht : interactuable
{
    private bool comprobador = true;
    public GameObject ObjetoaActivaroDesactivar;
    public void desactivar()
            { 
             comprobador = false;
            ObjetoaActivaroDesactivar.SetActive(false);
             }
          public void activar()
          {
              comprobador = true;
            ObjetoaActivaroDesactivar.SetActive(true);
           }


   public override void Interact() {
       base.Interact();
      if (comprobador == true) 
        {
            desactivar();
        } else 
        {
            activar();
        }

    }

    
 
           
   
}
