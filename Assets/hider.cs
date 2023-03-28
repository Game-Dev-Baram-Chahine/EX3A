using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class hider : MonoBehaviour
{
    public KeyCode hideKey = KeyCode.H;   // The key to press to hide the entity
    public KeyCode showKey = KeyCode.S;   // The key to press to show the entity

    private Renderer renderer;            // The renderer component of the entity
    private bool isHidden = false;        // Whether the entity is currently hidden

    // Start is called before the first frame update
    void Start()
    {
        // Get the renderer component of the entity
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Hide the entity when the hide key is pressed
        if (Input.GetKeyDown(hideKey))
        {
            renderer.enabled = false;
            isHidden = true;
        }

        // Show the entity when the show key is pressed
        if (Input.GetKeyDown(showKey))
        {
            renderer.enabled = true;
            isHidden = false;
        }
    }

    // Reset the entity to its default state
    public void Reset()
    {
        // Show the entity if it was hidden
        if (isHidden)
        {
            renderer.enabled = true;
            isHidden = false;
        }
    }
}
