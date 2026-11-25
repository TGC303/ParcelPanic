using UnityEditor;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
// Inspiration - https://youtu.be/BSybcKPQCnc?si=pk4Nr4ycdvG1pCYD

    private Vector3 MoveForce;
    public float MoveSpeed = 800;
    public float MaxSpeed = 900;
    private float OriginalMoveSpeed = 0f;
     private float OriginalMaxSpeed = 0f;

    private float Drag= 0.98f;
    public float SteerAngle = 12;
    public float Traction = 1f;

    public float VanWeight = 0f;
    public float accelerationReduction = 0.030f;
    public float speedReduction = 0.006f;

    void Start()
    {
        OriginalMoveSpeed = MoveSpeed;   
        OriginalMaxSpeed = MaxSpeed;
    }

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