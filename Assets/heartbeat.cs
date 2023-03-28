using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartbeat : MonoBehaviour
{
    public float amplitude = 1f;        // The amplitude of the sawtooth wave
    public float frequency = 1f;        // The frequency of the sawtooth wave
    public float speed = 1f;            // The speed of the animation
    public float scaleSpeed = 1f;       // The speed of the scaling animation

    private Vector3 initialScale;       // The initial scale of the object
    private float currentScale = 1f;    // The current scale of the object

    // Start is called before the first frame update
    void Start()
    {
        // Store the initial scale of the object
        initialScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the scaling factor based on a sawtooth wave
        float time = Time.time * speed;
        float period = 1f / frequency;
        float sawtooth = Mathf.Repeat(time, period) / period;
        float scale = Mathf.Lerp(-amplitude, amplitude, sawtooth) + 1f;

        // Animate the scale change
        currentScale = Mathf.Lerp(currentScale, scale, scaleSpeed * Time.deltaTime);

        // Set the new scale of the object
        transform.localScale = initialScale * currentScale;
    }
}