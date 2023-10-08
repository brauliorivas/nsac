using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camarainteraction : MonoBehaviour
{
    private new Transform camera;
    public float distanciaderayo = 2.25f;
    void Start()
    {
        camera = transform.Find("Camera");
    }


    void Update()
    {
        Debug.DrawRay(camera.position, camera.forward * distanciaderayo, Color.red);
        
        if (Input.GetKeyDown(KeyCode.E))
        { 
        RaycastHit objeto;
        if (Physics.Raycast(camera.position, camera.forward, out objeto, distanciaderayo, 
        LayerMask.GetMask("interactuable")))
        {
            objeto.transform.GetComponent<interactuable>().Interact();
        }
        }
    }
}
