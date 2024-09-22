using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripting3ChallengeBouncyBall : MonoBehaviour
{
    public float bounceForce = 3f;

    void OnCollisionEnter2D(Collision2D collision){
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);
    }
}
