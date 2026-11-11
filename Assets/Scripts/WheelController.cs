using UnityEngine;

public class WheelController : MonoBehaviour
{
    WheelCollider frontRight;
    WheelCollider frontLeft;
    WheelCollider backRight;
    WheelCollider backLeft;

    public float acceleration = 500f;
    public float breakingForce = 300f;

    private float currentAcceleration = 0f;
    private float currentBreakForce = 0f;

    private void FixedUpdate()
    {
        //Apply Acceleration to front wheels
        frontLeft.motorTorque = currentAcceleration;
        frontRight.motorTorque = currentAcceleration;

        //Apply Breaking to wheels
        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;

    }
}
