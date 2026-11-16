using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 50f;
    private Vector3 MoveForce;

    // Update is called once per frame
    void Update()
    {
        // Moving
        MoveForce += transform.forward * MoveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position += MoveForce * Time.deltaTime;
    }
}
