using UnityEngine;

public class TransformController : MonoBehaviour
{
    public Transform ChildTransform;

    public float speed = 1;
    public int pingAmount = 3;
    // Update is called once per frame
    void Update()
    {
        // Move the target Gameobject
        var x = Mathf.PingPong(Time.time * speed, pingAmount);
        var p = new Vector3(0, x, 0);
        ChildTransform.position = p;

        //Rotate the target Gameobject
        ChildTransform.Rotate(new Vector3(0, 30, 0) * Time.captureDeltaTime);
    }
}
