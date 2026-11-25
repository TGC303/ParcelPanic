using UnityEngine;

public class VanWeight : MonoBehaviour
{
        public PlayerMovement playerMovement;
    
       public void AddWeight(float weight)
    {
        playerMovement.VanWeight += weight;

        if (weight <= 25)
        {
            // Light parcel
            playerMovement.MoveSpeed -= weight * 0.05f;
            playerMovement.MaxSpeed -= weight * 0.05f;
        }
        else
        {
            // Heavy parcel - normal impact
            playerMovement.MoveSpeed -= weight * 0.5f;
            playerMovement.MaxSpeed -= weight * 0.5f;
        }

            //Mathf -- compares two numbers and returns the larger
                playerMovement.MoveSpeed = Mathf.Max(250f, playerMovement.MoveSpeed);
                playerMovement.MaxSpeed = Mathf.Max(300f, playerMovement.MaxSpeed);
    }  
            
}


