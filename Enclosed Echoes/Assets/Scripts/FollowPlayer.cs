using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = player.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position - offset;
    }
}
