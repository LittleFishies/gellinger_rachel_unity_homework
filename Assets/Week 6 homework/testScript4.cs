using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// another editable class!
public class testScript4 : MonoBehaviour {

    // defines an editable variable called parameter1, set at 100
    public float parameter1 = 100;
    // same thing as above, except it's called parameter2 and set at 10
    public float parameter2 = 10;

	// Use this for initialization
	void Start () {
		// (gasp!) nothing
	}
	
    // defines a function whose parameter is a collision detection
	void OnCollisionEnter(Collision collision)
    {
        // prints the name of the collider, a.k.a., the thing that hit the object, or vise-versa
        print(collision.collider.name);
        // a conditional statement, which asks if the name of the collider is "Terrain," which just means, "did it hit the ground"
        if(collision.collider.name != "Terrain")
        {
            // if it hit the ground, subtract paramater2 from parameter1
            parameter1 = parameter1 - parameter2;
            // print parameter1
            print(parameter1);
        }
        // conditional asking if parameter1 is less than 0
        if(parameter1 < 0)
        {
            // if the condition is met, the object is destroyed/deleted
            Destroy(gameObject);
        }
    }
}
