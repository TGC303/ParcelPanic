using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private float OriginalMoveSpeed;
    private float OriginalMaxSpeed;
    public float Speedamount = 1200f;
    public float Maxamount = 1500;

void Start()
{
     OriginalMoveSpeed = playerMovement.MoveSpeed;  
     OriginalMaxSpeed = playerMovement.MaxSpeed;

}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            playerMovement.MoveSpeed = 200f;
        }

    }

       void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            playerMovement.MoveSpeed = Speedamount;
            playerMovement.MaxSpeed = Maxamount;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            playerMovement.MoveSpeed = OriginalMoveSpeed;
        }
        if (other.CompareTag("Finish"))
            {
                playerMovement.MoveSpeed = OriginalMoveSpeed;
                playerMovement.MaxSpeed = OriginalMaxSpeed;
            }    
    }
}