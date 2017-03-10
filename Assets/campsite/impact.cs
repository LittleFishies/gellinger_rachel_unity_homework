using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impact : MonoBehaviour {

    private Rigidbody getPhysics;
    public Renderer matttttt;
    public float reactionSpeed = 500;
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
        if ((collider.gameObject.name == "rock(Clone)") && (gameObject.name == "tent side riggg" || gameObject.name == "tent side lef" || gameObject.name == "tent side lef (1)" || gameObject.name == "tent side riggg (1)"))
            {
            print(hitHitHit);
            getPhysics.AddForce(Vector3.up * reactionSpeed);
            Color randoColor = Random.ColorHSV();
            matttttt.material.SetColor("_Color", randoColor);
            }
        // I have no clue why this isn't working like it should - everything is doing this, even the tent sides. 
        // I have a hunch I'm messing up the operators, but I can't really think how. 
        if ((collider.gameObject.name == "rock(Clone)") && (gameObject.name != "tent side riggg" || gameObject.name != "tent side lef" || gameObject.name != "tent side lef (1)" || gameObject.name != "tent side riggg (1)"))
            {
            print("why though");
            Destroy(gameObject);
            }
        }
}
