using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class ParcelWeight : MonoBehaviour
{
    private float parcelWeight;

    public int minWeight = 5;
    public int maxWeight = 100;

    void Start()
    {
        parcelWeight = Random.Range(minWeight, maxWeight + 1);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponentInParent<VanWeight>().AddWeight(parcelWeight);

            Debug.Log("Parcel collected: " + parcelWeight + "kg");
            Destroy(gameObject);
        }
    }
}
