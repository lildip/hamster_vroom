using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carwheel : MonoBehaviour
{

    public WheelCollider targetwheel;

    private Vector3 wheelPosition = new Vector3();
    private Quaternion wheelRotation = new Quaternion();


    // Update is called once per frame
    void Update()
    {
        targetwheel.GetWorldPose(out wheelPosition, out wheelRotation);
        transform.position = wheelPosition;
        transform.rotation = wheelRotation;
    }
}
