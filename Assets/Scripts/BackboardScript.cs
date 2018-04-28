using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackboardScript : MonoBehaviour {

	void OnCollisionEnter(Collision other) {						// collision function,for when ball hits this goal
		if(other.gameObject.tag == "Ball") {						// if the other object (the one hitting this object) has a tag that is "Ball" THEN
			SceneManager.LoadScene("RestartScreen");				// load the restart screen
		} // END DESTROY

	} // END ON TRIGGER

} // END SCRIPT "GOALSCRIPT"
