using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    /*
     * this element will rotate on itself
     */
    public float speed = 180f;  // Rotation speed in degrees per second

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its own center
        transform.Rotate(Vector3.forward, -speed * Time.deltaTime);
    }
}
