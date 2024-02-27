using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrimitive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-1, 1, 3);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-1, 5, 3);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-1, 5, 8);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-1, 1, 8);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-1, 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
