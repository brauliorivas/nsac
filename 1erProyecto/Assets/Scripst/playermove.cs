using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{

    public float RunSpeed = 5;
    public float SensivildadRotacionX = 66;
    private Rigidbody Fisica;
    public float JumpForce = 6;
    bool pisandosuelo;
    private new Transform camera;
     public float SensivildadRotacionY = 65;
     public float angulodevisionY = 35;


    // Start is called before the first frame update
    void Start()
    {
        camera = transform.Find("Camera");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        pisandosuelo = true;
        Fisica = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update() {
        // movimiento Jugador
        float MovimientoX = Input.GetAxis("Horizontal");
        float MovimientoY = Input.GetAxis("Vertical");

     transform.Translate(new Vector3(MovimientoX * RunSpeed, 0, MovimientoY * RunSpeed) * Time.deltaTime);
       
       //correr 
       
       if (Input.GetKey(KeyCode.LeftShift))
       {
           RunSpeed = 10;
       } else { RunSpeed = 5;}

       // rotacion Jugador X

       float rotacionx = Input.GetAxis("Mouse X");
       transform.Rotate(new Vector3(0,rotacionx * SensivildadRotacionX,0) * Time.deltaTime);
       
       // rotacion camara Y

        float rotaciony = Input.GetAxis("Mouse Y");
       
       float angulodecamara = (camera.localEulerAngles.x + rotaciony * -1 * SensivildadRotacionY * Time.deltaTime + 360) % 360 ;
       
       if ( angulodecamara > 180){ angulodecamara -= 360;}
       angulodecamara = Mathf.Clamp(angulodecamara,angulodevisionY * -1, angulodevisionY);
       camera.localEulerAngles = new Vector3(1,0,0) * angulodecamara;
       // Salto
    if (Input.GetKeyDown(KeyCode.Space) && pisandosuelo == true) 
    {
        
     Jump();
    }
    }
    public void Jump() 
    {

      pisandosuelo = false;
      Fisica.AddForce(new Vector3(0,JumpForce,0), ForceMode.Impulse);
    }
    void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.CompareTag("Suelo"))
    {
        pisandosuelo = true;
    } 

    }
    

    
}
