using UnityEngine;
using UnityEngine.InputSystem;

public class ParcelManager : MonoBehaviour
{
    public GameObject parcel;
    public InputAction spawnAction;

    private float spawnRangeX = 30f;
    private float spawnPosZ = 10f;

    void Start()
    {
        spawnAction.Enable();
    }

    void Update()
    {
        if (spawnAction.triggered)
        {
            // Generate a random X position
            Vector3 spawnPos = new Vector3(
                Random.Range(-spawnRangeX, spawnRangeX),
                0,
                spawnPosZ
            );
            // Create a new parcel at the random position
            Instantiate(parcel, spawnPos, parcel.transform.rotation);
        }
    }
}