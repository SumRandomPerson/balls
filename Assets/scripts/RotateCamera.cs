using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{

    private float horizontal;
    public float rotationSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up, horizontal * Time.deltaTime * rotationSpeed);
    }
}
