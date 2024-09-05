using UnityEngine;

public class TransformController : MonoBehaviour
{
    public Transform ChildTransform;
    // Update is called once per frame
    void Update()
    {
        // Move the target Gameobject
        var x = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(0, x, 0);
        ChildTransform.position = p;

        //Rotate the target Gameobject
        ChildTransform.Rotate(new Vector3(0, 30, 0) * Time.captureDeltaTime);
    }
}
