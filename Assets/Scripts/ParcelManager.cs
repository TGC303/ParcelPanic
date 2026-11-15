using UnityEngine;
using UnityEngine.InputSystem;

public class ParcelManager : MonoBehaviour
{
    public GameObject parcel;
    private float spawnRangeX = 29;
    private float spawnPosZ = -160;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    private int maxParcels = 10;  // Maximum number of parcels allowed

    void Start()
    {
        InvokeRepeating("SpawnParcels", startDelay, spawnInterval);
    }

    void SpawnParcels()
    {
        // Count all parcels currently in the scene
        GameObject[] parcels = GameObject.FindGameObjectsWithTag("Parcel");

        // Only spawn if there are less than 15
        if (parcels.Length < maxParcels)
        {
            Vector3 spawnPos = new Vector3(
                Random.Range(-spawnRangeX, spawnRangeX),
                0,
                spawnPosZ
            );

            Instantiate(parcel, spawnPos, parcel.transform.rotation);
        }
    }

}