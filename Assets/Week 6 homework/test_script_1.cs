using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// creates an class called test_script_1, which can be edited in Unity
public class test_script_1 : MonoBehaviour {

    private Rigidbody rb;
    // it looks like this defines the variable "parameter2" as a float number equal to 10.... which should be an int?
    public float parameter2 = 10;
	// Use this for initialization
	void Start () {
        // literally just tells the console to print the string on startup
        print("Never name your script something this stupid, ever!");
        // defines the variable "rb," which calls the relevant object's Rigidbody component which I guess is an object
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        // adds force onto the object if we're moving foreward, and gives it the force of parameter2 in a certain direction
        rb.AddRelativeForce(Vector3.up * parameter2 * Input.GetAxis("Vertical"));
        // seems to do the same as the previous line, just in the opposite direction, and only if we're going backwards.
        rb.AddTorque(Vector3.left * parameter2 * Input.GetAxis("Vertical"));
	}
}
