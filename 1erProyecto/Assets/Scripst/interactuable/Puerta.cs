using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : interactuable
{
    public override void Interact() {
       base.Interact();
       
       transform.Rotate(Vector3.up * 90);
   }
}
