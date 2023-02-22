using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // This is the speed variable 
    // It is public so you can see it and change it from editor
    public float speed = 10.0f;

    public float turnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // We'll make the vehicle turn right or left.
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
