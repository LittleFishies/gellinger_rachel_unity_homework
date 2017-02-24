using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// defines another class that can be edited in Unity
public class testScript3 : MonoBehaviour
{
    // makes parameter1 a gameobject that can be edited in unity
    public GameObject parameter1;
    // parameter2 is an editable float number set to 20
    public float parameter2 = 20;
    // a non Unity editable object called clone
    private GameObject clone;
    // Update is called once per frame
    void Update()
    {
        // another conditional statement which activates on left mouse click
        if (Input.GetButtonDown("Fire1"))
        {
            // defines the variable "clone," which creates a new object each time the condition is satisfied
            clone = Instantiate(parameter1, transform.position, transform.rotation) as GameObject;
            // calls the rigidbody of each clone and adds foreward force to the clone of whatever parameter2 is
            clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward * parameter2);
        }
    }
}
