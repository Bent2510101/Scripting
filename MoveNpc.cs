using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNpc : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        //Creates a new position
        transform.position = newPosition;
    }
}

    
    
