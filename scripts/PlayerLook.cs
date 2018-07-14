/// <header>
/// Module : Player Look
/// Author : Sparsh Bansal, Ritik Agrawal, Mohit Singh
/// Date of creation : 15/04/18
/// Synopsis :
/// The module is responsible for the change of the camera view.
/// The rotational camera view is changed with the movement of the mouse and the linear view with the movement of the player.
/// Global variables :
/// public Transform playerBody;
/// public float mouseSensitivity;
/// Functions :
/// void Awake()
/// void Update()
/// void RotateCamera()
/// </header>

// imports required from the UnityEngine and System modules
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
	// Variable storing the player Whose movement changes the camera view.
	public Transform playerBody;
	// Variable for storing the sensitivity of the mouse.
    public float mouseSensitivity;
	// variable for storing the Clamping angle of the camera.
	float xAxisClamp = 0.0f;

	/// <summary>
	/// Awake is called at the beginning of the module
	/// locks the cursor in its position
	/// </summary>
    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

	/// <summary>
	/// Update is called once per frame
	/// It will call RotateCamera every time it is called
	/// </summary>
    void Update()
    {
        RotateCamera();       
    }

	/// <summary>
	/// Rotates the camera according to the inputs in x and y directions.
	/// Limits the camera movement upto the clamping angle.
	/// </summary>
    void RotateCamera()
    {
		// Variables for storing the mouse input in x and y directions.
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

		// Variables for storing the amount of camera rotation in both directions.
        float rotAmountX = mouseX * mouseSensitivity;
        float rotAmountY = mouseY * mouseSensitivity;

		// Clamping angle for the camera
        xAxisClamp -= rotAmountY;

		// Vectors for storing the transformes position of the camera and the player.
        Vector3 targetRotCam = transform.rotation.eulerAngles;
        Vector3 targetRotBody = playerBody.rotation.eulerAngles;

		// Change the amount of vectors according to amount of rotation
        targetRotCam.x -= rotAmountY;
        targetRotCam.z = 0;
        targetRotBody.y += rotAmountX;

		// Restrict rotation if rotation angle exceeds clamping angle
        if(xAxisClamp > 90)
        {
            xAxisClamp = 90;
            targetRotCam.x = 90;
        }
        else if(xAxisClamp < -90)
        {
            xAxisClamp = -90;
            targetRotCam.x = 270;
        }

        print(mouseY);

		// Rotate the camera and the player according to the euler angles of the ampount of rotation
        transform.rotation = Quaternion.Euler(targetRotCam);
        playerBody.rotation = Quaternion.Euler(targetRotBody);


    }



}
