using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public VanWeight vanWeight;
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
        if (other.CompareTag("SpeedBoost"))
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
        if (other.CompareTag("SpeedBoost"))
            {
                playerMovement.MoveSpeed = OriginalMoveSpeed;
                playerMovement.MaxSpeed = OriginalMaxSpeed;
            }    
    }
}