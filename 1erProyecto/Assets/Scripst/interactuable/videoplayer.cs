


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class videoplayer :  interactuable

{   bool comprobador = true;
    public GameObject ObjetoaActivaroDesactivar ;
    public GameObject MovimientoJugador;
    
    public VideoPlayer video;
    void Awake()
    {
       
        
    }
     void Start() {
    ObjetoaActivaroDesactivar.SetActive(false); 
    video = GetComponent<VideoPlayer>(); 
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
            video.Pause();
            desactivar();
        } else 
        {   video.Play();
            activar();}
            }

}

