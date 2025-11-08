using Unity.Mathematics;
using UnityEngine;

public class LookinAtU : MonoBehaviour
{
    public GameObject lookAt;
    public GameObject upTarg;
    public float lookSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion targRot = Quaternion.Slerp(transform.rotation, quaternion.LookRotation(lookAt.transform.position - transform.position, upTarg.transform.position - transform.position), lookSpeed);
        transform.rotation = targRot;
    }
}
