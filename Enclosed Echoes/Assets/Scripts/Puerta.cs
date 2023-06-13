using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.openDoor && transform.position.y>0)
        {                  
            transform.position += Vector3.down*Time.deltaTime;            
        }
        if (!GameManager.openDoor && transform.position.y<4)
        {                  
            transform.position += Vector3.up*Time.deltaTime;            
        }
    }

    
}
