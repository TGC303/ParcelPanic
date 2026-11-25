using UnityEngine;
using UnityEngine.InputSystem;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class ParcelManager : MonoBehaviour
{
    public GameObject parcel;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    private float minX = -24;
    private float maxX = 24;

    private float minZ = -68f;
    private float maxZ = 10f;


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
            Vector3 spawnPos = new Vector3(Random.Range(minX, maxX),0,Random.Range(minZ, maxZ)
);

            Instantiate(parcel, spawnPos, parcel.transform.rotation);
        }
    }

}