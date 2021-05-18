using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
   Player PixelMe;
   // Start is called before the first frame update
   void Start() {
       PixelMe = gameObject.transform.parent.gameObject.GetComponent<Player>();
   }

   // Método para detectar quando colide
   void OnCollisionEnter2D(Collision2D collisor) {
       if(collisor.gameObject.layer == 8) {
           PixelMe.isJumping = false;
       }
   }

    // Método para detectar quando para de colidir
   void OnCollisionExit2D(Collision2D collisor) {
       if(collisor.gameObject.layer == 8) {
           PixelMe.isJumping = true;
       }
   }
}

