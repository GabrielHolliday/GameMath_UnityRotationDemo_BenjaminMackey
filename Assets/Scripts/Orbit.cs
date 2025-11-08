using Unity.Mathematics;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject saturn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = quaternion.LookRotation(saturn.transform.position - transform.position, transform.up);
        transform.Translate(transform.right * Time.deltaTime * 3, Space.World);
        //transform.position += transform.right * Time.deltaTime;
    }
}
