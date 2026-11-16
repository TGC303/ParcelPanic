using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 50f;
    private Vector3 MoveForce;
    public float MaxSpeed = 15f;
    private float Drag= 0.98f;
    public float SteerAngle = 20;
    public float Traction = 1f;


    // Update is called once per frame
    void Update()
    {
        Moving();
        Steering();
        GroundTraction();

    
    }

    void Moving()
    {
       // Moving
        MoveForce += transform.forward * MoveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position += MoveForce * Time.deltaTime;

    }

    void Steering()
    {
        float steerInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * steerInput * MoveForce.magnitude * SteerAngle * Time.deltaTime);
    }

    void GroundTraction()
    {
         // Drag
        MoveForce *= Drag;
        MoveForce = Vector3.ClampMagnitude(MoveForce,MaxSpeed);

        //Traction
        MoveForce = Vector3.Lerp(MoveForce.normalized, transform.forward, Traction * Time.deltaTime) * MoveForce.magnitude;
    }
}
