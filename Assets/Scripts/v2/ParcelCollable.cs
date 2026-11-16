using UnityEngine;

public class ParcelCollable : MonoBehaviour
{
    private float parcelWeight;
    public int minWeight = 5;
    public int maxWeight = 100;

    void Start()
    {
        // Generate a random parcel weight
        parcelWeight = Random.Range(minWeight, maxWeight);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Increase the van's weight
            other.attachedRigidbody.mass += parcelWeight;

            Debug.Log("Parcel collected" );

            // Remove the parcel
            Destroy(gameObject);
        }
    }
}

