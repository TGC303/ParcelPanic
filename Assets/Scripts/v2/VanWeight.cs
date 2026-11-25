using UnityEngine;
using System.Collections.Generic;

public class VanWeight : MonoBehaviour
{
    public PlayerMovement playerMovement;

    public List<float> collectedParcels = new List<float>();

    public void AddWeight(float weight)
    {
        collectedParcels.Add(weight);

        playerMovement.VanWeight += weight;

        if (weight <= 25)
        {
            // Light parcel
            playerMovement.MoveSpeed -= weight * 0.05f;
            playerMovement.MaxSpeed -= weight * 0.05f;
        }
        else
        {
            // Heavy parcel
            playerMovement.MoveSpeed -= weight * 0.5f;
            playerMovement.MaxSpeed -= weight * 0.5f;
        }

        // Minimum speed limits
        playerMovement.MoveSpeed = Mathf.Max(250f, playerMovement.MoveSpeed);
        playerMovement.MaxSpeed = Mathf.Max(300f, playerMovement.MaxSpeed);

        Debug.Log("Total weight: " + playerMovement.VanWeight + "kg");
    }

    public void RemoveWeight()
    {
        // Find parcels between 5kg and 100kg
        List<float> availableParcels = collectedParcels.FindAll(weight => weight >= 5 && weight <= 1000);

        if (availableParcels.Count > 0)
        {
            // Randomly select a collected parcel
            float weight = availableParcels[Random.Range(0, availableParcels.Count)];
            collectedParcels.Remove(weight);
            playerMovement.VanWeight -= weight;

            Debug.Log("Parcel delivered: " + weight + "kg");
            Debug.Log("Remaining weight: " + playerMovement.VanWeight + "kg");
        }
        else
        {
            Debug.Log("No suitable parcels to deliver");
        }
    }
}