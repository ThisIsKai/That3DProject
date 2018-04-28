using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour { // BALL SCRIPT : overrides z posistion if it hits a hole, 
										  // and sends stuff to the console when it collides with stuff
	
	public float ballMinZ; 							// the minimum Z coordinate for the ball
	private Rigidbody ballRB; 					// the ball's rigidbody
	public float suctionSpeed; 					// the speed of the z movement once the ballRB breaches the ballMinZ
	Transform ballTransform; 					// the ball's transform

	void Start () {													// START FUNCTION
		ballTransform = transform; 									// define ballTransform
		ballRB = GetComponent<Rigidbody>(); 						// get that rigidbody
	
	}//END START

	void FixedUpdate () {																	// FIXED UPDATE FUNCTION
		if (this.gameObject.transform.position.z > ballMinZ) { 								// if this game object (the ball)'s z posistion 
																							// is greater than the ballMinZ THEN
			ballRB.MovePosition (transform.position + new Vector3 (0, 0, suctionSpeed));	// the ball's rigidbody will move posistion 
																							// from it's current transform
																							// based on the Vector3 (x=0,y=0, z=suctionSpeed)
		} // END IF
	} // END FIXED UPDATE

	void OnCollisionEnter(Collision other) {														// ONCOLLISIONENTER FUNCTION
			Debug.Log ("The ball hit" + other.gameObject.tag + "at" + Time.time + "Time.time");	// debug.log telling us what the ball hit and when
	
	} //END ON COLLISION
 }// END SCRIPT "BALL SCRIPT"
