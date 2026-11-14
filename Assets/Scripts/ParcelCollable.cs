using UnityEngine;

public class ParcelCollable : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered by: " + other.name);
    }
}
