using UnityEngine;

public class RoadSpeed : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private float OriginalMoveSpeed;
    private float OriginalMaxSpeed;
    public float amount = 1000f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OriginalMoveSpeed = playerMovement.MoveSpeed;
        OriginalMaxSpeed = playerMovement.MaxSpeed;
    }
       void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
             playerMovement.MoveSpeed += amount;
            playerMovement.MaxSpeed += amount;
        }
    }
        void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                playerMovement.MoveSpeed = OriginalMoveSpeed;
            }
        }
}
