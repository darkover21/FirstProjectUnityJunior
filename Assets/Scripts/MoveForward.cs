using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f;
    public float topBound = 24.0f;
    public float lowBound = -100.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.z >= topBound) { 
            Destroy(this.gameObject); 
        }else if(transform.position.z <= lowBound) Destroy(this.gameObject);

    }
}
