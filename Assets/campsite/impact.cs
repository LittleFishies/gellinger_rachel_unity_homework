using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impact : MonoBehaviour {

    private Rigidbody getPhysics;
    public float reactionSpeed = 10;
    private string startingOut = "Try hitting a tent!";
    private string hitHitHit = "ow,";
    public float objectDamage = 10;
    public float targetHealth = 100;

	// Use this for initialization
	void Start () {
        getPhysics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter (Collision collision)
    {
        if (collision.collider.name == "rock(Clone)")
        {
            getPhysics.AddForce(Vector3.up * reactionSpeed);
            print(hitHitHit);

            if ((gameObject.name == "Tent Side") || (gameObject.name == "Tent Side (1)") || (gameObject.name == "Tent Side (2)") || (gameObject.name == "Tent Side (3)"))
            {
                targetHealth = targetHealth - objectDamage;
                print(targetHealth);
            }

            else
            {
                print("That's not a tent.");
            }
        }

        if (targetHealth <= 0)
        {
            Destroy(gameObject);
            print("You ruined it. Great job.");
        }
    }
}
