using UnityEngine;
using UnityEngine.InputSystem;

public class VanController : MonoBehaviour
{
    //Variabels
    public float speed = 5.0f;
    public float turnSpeed;
    public InputAction moveAction;
    public Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * moveInput.y);
        //Turns Vehicle
        transform.Translate(Vector3.right * Time.deltaTime * moveInput.x);
    }
}
