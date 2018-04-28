using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}//END START FUNCTION
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){ //if the spacebar is pressed, THEN
			SceneManager.LoadScene("MyScene"); //load the scene assigned as number 1 in the build (should be the main game scene)
		}// END LOAD GAME

	}//END UPDATE
}// END CHANGE SCENE SCRIPT