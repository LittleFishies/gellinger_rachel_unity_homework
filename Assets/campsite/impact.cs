using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impact : MonoBehaviour {

    private Rigidbody getPhysics;
    public Renderer matttttt;
    public float reactionSpeed = 25;
    private string startingOut = "Try hitting a tent!";
    private string hitHitHit = "ow,";

	// Use this for initialization
	void Start () {
        print(startingOut);
        getPhysics = GetComponent<Rigidbody>();
        matttttt = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void OnCollisionEnter (Collision collider) {
        if (collider.gameObject.name == "rock(Clone)")
            {
            print(hitHitHit);
            getPhysics.AddForce(Vector3.up * reactionSpeed);
            Color randoColor = Random.ColorHSV();
            matttttt.material.SetColor("_Color", randoColor);
            }
         }
}
