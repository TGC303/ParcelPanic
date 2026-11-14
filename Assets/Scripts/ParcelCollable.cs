using UnityEngine;

public class ParcelCollable : MonoBehaviour
{

    public float parcelWeight = 1000f;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered by: " + other.name);
        Destroy(gameObject);
        }
    }


