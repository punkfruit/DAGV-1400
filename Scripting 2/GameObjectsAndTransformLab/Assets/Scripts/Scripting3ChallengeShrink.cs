using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripting3ChallengeShrink : MonoBehaviour
{
    public float shrinkFactor = 0.9f;

    void OnCollisionEnter2D(Collision2D collision){
        transform.localScale *= shrinkFactor;
    }
}
