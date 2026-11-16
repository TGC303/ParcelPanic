using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 50f;
    private Vector3 MoveForce;
    public float MaxSpeed = 15f;
    public float Drag= 0.98f;
    public float SteerAngle = 20;


    // Update is called once per frame
    void Update()
    {
        Moving();
        Steering();

    
    }

    void Moving()
    {
       // Moving
        MoveForce += transform.forward * MoveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position += MoveForce * Time.deltaTime;

        // Drag
        MoveForce *= Drag;
        MoveForce = Vector3.ClampMagnitude(MoveForce,MaxSpeed);
    }

    void Steering()
    {
        float steerInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * steerInput * MoveForce.magnitude * SteerAngle * Time.deltaTime);
    }
}
