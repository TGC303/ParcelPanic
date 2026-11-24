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
       else if (other.CompareTag("SpeedBoost"))
{
    playerMovement.MoveSpeed = 1500;
}

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ground") || other.CompareTag("SpeedBoost") )
        {
            playerMovement.MoveSpeed = OriginalMoveSpeed;
        }
    }
}