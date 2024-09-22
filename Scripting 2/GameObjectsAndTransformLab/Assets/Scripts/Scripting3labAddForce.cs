using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scripting3labAddForce : MonoBehaviour
{
   private Rigidbody2D rb;

   void Start()
   {
        rb = GetComponent<Rigidbody2D> ();
        rb.AddForce(Vector2.right * 500);
   }
}
