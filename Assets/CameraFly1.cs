using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFly1 : MonoBehaviour {

	public float mouseSensitivity = 3.0f;
	public float speed = 2.0f;
	private Vector3 transfer;
    public Camera cam;
    public Transform targetObject;
    public float orbitSpeed = 10f;

	public float minimumX = -360F;
	public float maximumX = 360F;
	public float minimumY = -60F;
	public float maximumY = 60F;
	float rotationX = 0F;
	float rotationY = 0F;
	Quaternion originalRotation;


	void Start() {
		originalRotation = transform.rotation;
	}

	void Update() {

        //cam.transform.LookAt(targetObject, Vector3.up);
 
        if (Input.GetMouseButton(1))
        {
            //float deltaX = Input.GetAxis("Mouse X");
            //float deltaY = Input.GetAxis("Mouse Y");
 
            //cam.transform.RotateAround(targetObject.transform.position, Vector3.up, deltaX * orbitSpeed);
            //cam.transform.RotateAround(targetObject.transform.position, cam.transform.right, deltaY * -orbitSpeed);
            rotationX += Input.GetAxis("Mouse X") * mouseSensitivity;
		rotationY += Input.GetAxis("Mouse Y") * mouseSensitivity;
		rotationX = ClampAngle (rotationX, minimumX, maximumX);
		rotationY = ClampAngle (rotationY, minimumY, maximumY);
		Quaternion xQuaternion = Quaternion.AngleAxis (rotationX, Vector3.up);
		Quaternion yQuaternion = Quaternion.AngleAxis (rotationY, Vector3.left);
		transform.rotation = originalRotation * xQuaternion * yQuaternion;
        }

		// Движения мыши -> Вращение камеры
		//rotationX += Input.GetAxis("Mouse X") * mouseSensitivity;
		//rotationY += Input.GetAxis("Mouse Y") * mouseSensitivity;
		//rotationX = ClampAngle (rotationX, minimumX, maximumX);
		//rotationY = ClampAngle (rotationY, minimumY, maximumY);
		//Quaternion xQuaternion = Quaternion.AngleAxis (rotationX, Vector3.up);
		//Quaternion yQuaternion = Quaternion.AngleAxis (rotationY, Vector3.left);
		//transform.rotation = originalRotation * xQuaternion * yQuaternion;
		// перемещение камеры
		transfer = transform.forward * Input.GetAxis("Vertical");
		transfer += transform.right * Input.GetAxis("Horizontal");
		transform.position += transfer * speed * Time.deltaTime;
	}

	public static float ClampAngle (float angle, float min, float max)
	{
		if (angle < -360F) angle += 360F;
		if (angle > 360F) angle -= 360F;
		return Mathf.Clamp (angle, min, max);
	}

}
