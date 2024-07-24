using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10;
    public GameObject pizzaPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (transform.position.x <= -18) transform.position = new Vector3(-18, transform.position.y, transform.position.z);
        if (transform.position.x >= 18) transform.position = new Vector3(18, transform.position.y, transform.position.z);
        transform.Translate(Time.deltaTime * horizontalInput * Vector3.right*speed);
        if (Input.GetKeyDown(KeyCode.Space)) Instantiate(pizzaPrefab, transform.position, pizzaPrefab.transform.rotation);
    }
}
