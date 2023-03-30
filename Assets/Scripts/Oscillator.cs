using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{/*
  * this component act as a Oscillator
  */

    public float frequency = 1f;  // Oscillation frequency
    public float amplitude = 1f;  // Oscillation amplitude
    public float speed = 1f;      // Horizontal movement speed

    private float timeElapsed = 0f; //timer that counts from the start
    private float startPositionX;   //starting position, so it will be centered

    void Start()
    {
        startPositionX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

        // Calculate the horizontal displacement based on the speed and time elapsed
        float x = Mathf.Cos(2f * Mathf.PI * frequency * timeElapsed) * amplitude * speed;

        // Update the x position based on the starting position
        transform.position = new Vector3(startPositionX + x, transform.position.y, transform.position.z);
    }

}
