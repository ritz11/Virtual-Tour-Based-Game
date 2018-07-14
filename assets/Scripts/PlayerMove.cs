/// <header>
/// Module : Player Move
/// Author : Sparsh Bansal, Ritik Agrawal, Mohit Singh
/// Date of creation : 15/04/18
/// Synopsis :
///     The module is responsible for the movement of the player.
///     The player moves when input is given through the keyboard.
/// Global variables :
///     public float walkSpeed
/// Functions :
/// void Awake()
/// void Update()
/// void MovePlayer()
/// </header>

// imports required from the UnityEngine and System modules
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	// Variable storing the First Person Character Controller
	CharacterController charControl;
	// Variable storing the walking speed of the player.
	public float walkSpeed;

	/// <summary>
	/// Awake is called at the beginning of the module.
	/// It assigns the Character controller component to the variable
	/// </summary>
	void Awake()
	{
		charControl = GetComponent<CharacterController>();
	}

	/// <summary>
	/// Update is called once per frame
	/// It will call MovePlayer every time it is called
	/// </summary>
	void Update()
	{
		MovePlayer();
	}

	/// <summary>
	/// Moves the player according to the input given.
	/// </summary>
	void MovePlayer()
	{
		// Variables for storing the horizontal and vertical movement of the player
		float horiz = Input.GetAxis("Horizontal");
		float vert = Input.GetAxis("Vertical");

		// Vectors storing the horizontal and vertical position of the player.
		Vector3 moveDirSide = transform.right * horiz * walkSpeed;
		Vector3 moveDirForward = transform.forward * vert * walkSpeed;

		// Move the players in directions of the vectors.
		charControl.SimpleMove(moveDirSide);
		charControl.SimpleMove(moveDirForward);

	}
}
