using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// defines an class called testScript2? it can be edited in Unity
public class TestScript2 : MonoBehaviour {
    // makes the rigidbody rb non-editable in the Unity engine
    private Rigidbody rb;
    // makes parameter1 editable in Unity
    public float parameter1;
    // makes the rend - which I'm pretty sure is responsible for at least part of the material - uneditable in Unity.
    private Renderer rend;
	// Use this for initialization
	void Start () {
        // defines "rb" as the object's rigidbody component
        rb = GetComponent<Rigidbody>();
        // defines "rend" as the objects renderer, which I think is at least part of the material.
        rend = GetComponent<Renderer>();
	}
	
    // each frame, do a thing
    void Update()
    {
        // starts a conditional statement which initiates if we click the left mouse button
        if (Input.GetButtonDown("Fire1"))
        {
            // creates a new variable "color," defines it as a color, and randomizes each time the condition is met
            Color color = Random.ColorHSV();
            // sets rend's color to whatever "color" is at the moment. 
            rend.material.SetColor("_Color", color);
            
        }
    }
    // creates another function that uses collisions as a parameter (so like, if the object hits another thing, it does the function)
	void OnCollisionEnter(Collision collision)
    {
        // tells rb to add force upwards the amount specified in parameter1
        rb.AddForce(Vector3.up * parameter1);
    }
}
