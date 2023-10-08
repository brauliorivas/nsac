using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interruptordeluz : interactuable
{
    private bool comprobador = true;
    public GameObject lucespsicodelicas;
    public GameObject lucestecho;
    void Start() {
        lucestecho.SetActive(false);
    }
    public void desactivar()
            { 
             comprobador = false;
            lucespsicodelicas.SetActive(false);
            lucestecho.SetActive(true);
             }
          public void activar()
          {
              comprobador = true;
            lucespsicodelicas.SetActive(true);
            lucestecho.SetActive(false);
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
