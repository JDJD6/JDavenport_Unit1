using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    private float turnSpeed = 15.0f;

    private float horizontalInput;
    private float verticalInput;
    
    // push correctly please
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        Debug.Log(Time.deltaTime);
        // Vector3, forward -- > (0, 0, 1)
        // (0, 0, 1) * Time.deltaTime = (0, 0, .016)
        transform.Translate(Vector3.forward * Time.deltaTime * 15);

        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
