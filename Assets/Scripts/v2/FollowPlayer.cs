using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Variables
    public GameObject player;
    private Vector3 offset = new Vector3(0f, 5f, -10f); // Cams position
    private Vector3 camrot = new Vector3(10, 0, 0); // Changes the cam rotation


    // Start is called when the porgram loads
    void Start()
    {
        transform.Rotate(camrot);
    }

    // Update is called once per frame | Constantly Checking
    // Late Update updates AFTER the update happens
    void LateUpdate()
    {

        // Position gets the X,Y,Z of the Camera's Current location
        transform.position = player.transform.position + player.transform.rotation * offset;

        transform.rotation = player.transform.rotation
                          * Quaternion.Euler(camrot);

    }
}
