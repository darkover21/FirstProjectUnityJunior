using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    Vector3 lastplayerPos;
    // Start is called before the first frame update
    void Start()
    {
        lastplayerPos = player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {   // Increase Camera position same as Player position
        transform.position += (player.transform.position-lastplayerPos);
        lastplayerPos = player.transform.position;
    }
}
