using UnityEngine;

public class GrassSlowdown : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private float OriginalMoveSpeed;

void Start()
{
     OriginalMoveSpeed = playerMovement.MoveSpeed;  
}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            playerMovement.MoveSpeed = 200f;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            Debug.Log("Works");
            playerMovement.MoveSpeed = OriginalMoveSpeed;
        }
    }
}