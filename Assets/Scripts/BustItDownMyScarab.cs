using UnityEngine;

public class BustItDownMyScarab : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, Mathf.Sin(Time.time) * 100, 0);
    }
}
