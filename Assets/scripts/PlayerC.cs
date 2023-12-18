using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC : MonoBehaviour
{

    private Rigidbody playerRB;
private float forwardInput;
public float speed;
private GameObject focalPoint;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();

        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");

        playerRB.AddForce(focalPoint.transform.forward * forwardInput * speed);
    }
}
