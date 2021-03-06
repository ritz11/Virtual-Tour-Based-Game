﻿/// <header>
/// Module : Task Allocation
/// Author : Sparsh Bansal, Ritik Agrawal, Mohit Singh
/// Date of creation : 15/04/18
/// Synopsis :  This module allots the task to the user by giving initial position and destination to the user.
///             It also starts the timer once the game has been started.
/// Global variables :
///     public Text Timer
///     public static float timeCalculator
///     public float startTime
///     public static Vector3 startPosition
///     public static Vector3 finalPosition
///     public Text scoreFinal
///     public Text destinationName
///     public Static bool isEnded
/// Functions :
/// void Start( )
/// </header>

// imports required from the UnityEngine and System modules
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class TaskAllocation : MonoBehaviour {

	public Text timer;      //Timer shows the time left on the screen
	public static float timeCalculator;     //It stores the time left on the screen
	public float startTime;                 //Starting time of the game
	public static Vector3 startPosition;
	public static Vector3 finalPosition;
	int index;          //variable for the getting the random index for the position
	public Text destinationName;
	int minDistance = 2;
	public static bool isEnded = false;

	// Use this for initialization
	void Start () {
		Spawn ();
		isEnded = false;
	}


	/// <summary>
	///     Update is called once per frame
	///     Ends the game if the task is completed
	///     Also shows timer at the top right 
	/// </summary>
	void Update () {
		//checks if the destination is reached
		if ((transform.position - finalPosition).magnitude < minDistance)
		{
			isEnded = true;
		}
		//timeCalculator tells the time left 
		timeCalculator = 60 - (Time.time - startTime);
		timer.text = "Time Left: " + timeCalculator.ToString("####0.00");

	}
	/// <summary>
	///     It gives random start position and final position
	///     It shows the name of the destination at the top
	/// </summary>
	void Spawn()
	{
		timer.text = "";
		//Index gives the random position number in the database
		index = Random.Range (0, 4);
		startPosition = Database.positions [index];
		finalPosition = Database.positions [(index + 1) % 5];
		transform.position = startPosition;
		startTime = Time.time;
		//the following text is displayed on the screen
		destinationName.text = "Destination : " + Database.locations[(index + 1) % 5];
	}
}
