using UnityEngine;

public class ParcelCollable : MonoBehaviour
{
    public float parcelWeight;
    public float minWeight = 5f;
    public float maxWeight = 100f;

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

            Debug.Log("Parcel collected" + " - Weight is" + parcelWeight);

            // Remove the parcel
            Destroy(gameObject);
        }
    }
}

