using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 50f;
    private Vector3 MoveForce;
    public float MaxSpeed = 15f;
    public float Drag= 0.98f;

    // Update is called once per frame
    void Update()
    {
        // Moving
        MoveForce += transform.forward * MoveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position += MoveForce * Time.deltaTime;

        // Drag
        MoveForce *= Drag;
        MoveForce = Vector3.ClampMagnitude(MoveForce,MaxSpeed);
    }
}
