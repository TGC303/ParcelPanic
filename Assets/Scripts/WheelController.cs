using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class WheelController : MonoBehaviour
{
    public WheelCollider frontRight;
    public WheelCollider frontLeft;
    public WheelCollider backRight;
    public WheelCollider backLeft;

    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float maxTurnAngle = 25f;
    public float reverseSpeed = 1.5f;

    private float currentAcceleration = 0f;
    private float currentBreakForce = 0f;
    private float currentTurnAngle = 0f;



    private void FixedUpdate()
    {
        //Moves Forward / Backwards W & S
        currentAcceleration = acceleration * Input.GetAxis("Vertical");

        //Apply Acceleration to front wheels
        frontLeft.motorTorque = currentAcceleration;
        frontRight.motorTorque = currentAcceleration;
        backLeft.motorTorque = currentAcceleration;
        backRight.motorTorque = currentAcceleration;

        //Apply Breaking to wheels
        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;

        //Deals with steeering
        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;

        // Power to revering
        if (Input.GetAxis("Vertical") < 0)
        {
            currentAcceleration *= reverseSpeed;
        }

    }
}
