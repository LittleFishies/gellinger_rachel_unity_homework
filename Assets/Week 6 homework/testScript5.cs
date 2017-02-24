using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// defines a class of stuff? called testScript5, it can be edited in the Unity editor
public class testScript5 : MonoBehaviour {
    // editable parameter that is set to an initial value of 0.1 - this decides how bright the sky gets
    public float parameter1 = 0.1f;
    // literally the same as above just with a different name, but probably used for something different. same as before, but for darkness
    public float parameter2 = 0.1f;
    // another editable variable, but this time it's set to 10. sets how long it takes to reach max brightness
    public float parameter3 = 10;
    // yet another variable, set to negative 10. sets how long it takes to reach max darkness
    public float parameter4 = -10;
    // an uneditable variable that is set to be true.
    private bool parameter5 = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // if statement that asks if parameter1 is greater than, but not equal to, parameter3
        if(parameter1 > parameter3)
        {
            // if the above condition is met, parameter5 is set to false. 
            parameter5 = false;
        }
        // if statement asking if parameter5... with no other condition. I'm assuming this is just asking if it's true.
        if (parameter5)
        {
            // if the condition is met, then it adds parameter1 to parameter2? (I had to look up what += meant and that's what I got)
            parameter1 += parameter2;
            // opens up the skybox, and sets its exposure/brightness to whatever parameter1 is?
            RenderSettings.skybox.SetFloat("_Exposure", parameter1);
            //otherwise, if either of the previous conditions aren't met, do this thing:
        } else
        {
            // subtract parameter1 from parameter2
            parameter1 -= parameter2;
            // then open up the skybox and set its exposure/brightness to whatever parameter1 is. 
            RenderSettings.skybox.SetFloat("_Exposure", parameter1);
        }
        // another conditional asking if parameter1 is less than, but not equal to, parameter4
        if(parameter1 < parameter4)
        {
            // if it is, then parameter5 is set to true.
            parameter5 = true;
        }

    }
}
