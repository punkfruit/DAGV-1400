using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scripting3labCollisionEnter : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision){
        Debug.Log("Collision detected with " + collision.gameObject.name);
    }
}
