using UnityEngine;

public class ParcelWeight : MonoBehaviour
{
    private float parcelWeight;
    public int minWeight = 5;
    public int maxWeight = 900;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         // Generate a random parcel weight
        parcelWeight = Random.Range(minWeight, maxWeight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        other.GetComponentInParent<PlayerMovement>().AddWeight(parcelWeight);

        Debug.Log("Parcel collected: " + parcelWeight + "kg");

        Destroy(gameObject);
    }
}
}
