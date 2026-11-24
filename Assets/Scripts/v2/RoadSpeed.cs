using UnityEngine;

public class RoadSpeed : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private float OriginalMoveSpeed;
    private float OriginalMaxSpeed;

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
            playerMovement.MoveSpeed = OriginalMoveSpeed + 1250f;
            playerMovement.MaxSpeed = playerMovement.MaxSpeed + 1250f;
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
