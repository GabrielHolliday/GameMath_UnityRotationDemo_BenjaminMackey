using UnityEngine;

public class WASDControlls : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow)) transform.position += Vector3.right * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow)) transform.position += Vector3.left * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.A)| Input.GetKey(KeyCode.LeftArrow)) transform.position += Vector3.forward * Time.deltaTime * speed;
        if(Input.GetKey(KeyCode.D)| Input.GetKey(KeyCode.RightArrow)) transform.position += Vector3.back * Time.deltaTime * speed;
    }
}
