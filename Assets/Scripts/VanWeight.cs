using UnityEngine;

public class VanWeight : MonoBehaviour
{
    public Rigidbody rgbd;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rgbd = GetComponent<Rigidbody>();
    }

    public void AddWeight(float amount)
    {
        rgbd.mass += amount;

        Debug.Log("New Mass: " + rgbd.mass);
    }
}
