using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firewoodSound : MonoBehaviour {
    
    private bool falling;
    private AudioSource wood;
    
    // Use this for initialization
    void Start () {
        wood = GetComponent<AudioSource>(); 
        falling = false;
	}
	
	// Update is called once per frame
	void Update () {
 
	}

    void OnCollisionEnter(Collision collision)
    {
        falling = true;
        if (falling == true)
        {
            wood.Play();
        }
    }
}
