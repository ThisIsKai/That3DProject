/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour {

	Camera mainCamera; //the main camera
	private GameObject ballObject; //the ball

	public float camPosLockX; // the fixed/locked-in x pos of the camera
	public float camPosLockZ; // the fixed/locked-in z poz of the camera

	[Range (9, 49)]
	[SerializeField]
	public float cam_fov; // the field of view

	public float cam_X_Min;// posistion parameters: x minimum
	public float cam_X_Max;// posistion parameters: x maximum
	public float cam_Y_Min;// posistion parameters: y minimum
	public float cam_Y_Max;// posistion parameters: y maximum
	public float cam_Z_Min;// posistion parameters: z minimum
	public float cam_Z_Max;// posistion parameters: z maximum




void Start () {
	mainCamera = Camera.main; //assigning the camera
	cam_fov = mainCamera.fieldOfView;
	cam_fov = 49.0f;
	ballObject = GameObject.FindGameObjectsWithTag ("Ball");//associates it with variables with the tag 'player'
	

}//END START FUNCTION

// Update is called once per frame
void Update () {
	Vector3 cam_pos = mainCamera.transform.position; //
		cam_pos.x = camPosLockX;
		cam_pos.z = camPosLockZ;
		cam_pos.y = ballObject.transform.position.y;//

		if (Input.GetKey(KeyCode.Equals) && (cam_fov>7.0f)){
			CamZoomIn ();

			}
			
		if (Input.GetKey(KeyCode.Minus) && (cam_fov<49.0f)) {
			CamZoomOut ();
		}

} //END UPDATE FUNCTION
	void CamZoomIn () {
		if (cam_fov < 10f) {
			cam_fov = cam_fov - 1f;
		}
		else if { cam_fov >= 9f;
			cam_fov =9f;
	}

		void CamZoomOut () {	
			if (cam_fov >= 9f) {
				cam_fov = cam_fov + 1f;
			}
		else if { cam_fov <= 9f;
			cam_fov =9f;
			}
} //END CAMERA SYESTEM SCRIPT*/


