/// <header>
/// Module : Database
/// Author : Sparsh Bansal, Ritik Agrawal, Mohit Singh
/// Date of creation : 15/04/18
/// Synopsis :
///     The module stores the locations' coordinates with their names
/// Global variables :
///     public float Vector3[] positions
///     public static string[] locations
/// Functions :
///     void Awake()
///     void Update()
///     void MovePlayer()
/// </header>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class Database : MonoBehaviour
{

	public static Vector3[] positions = new Vector3[5];     //stores the coordinates of the locations
	public static string[] locations = new string[5];       //stores the names of the locations

	/// <summary>
	///     This function  is the first function to be called after the game has begun
	/// </summary>
	void Awake()
	{
		AddPositions();
		AddLocations();
	}

	/// <summary>
	///     This functions adds the coordinates of the locations into the Vector3 array
	///     This function is called by the Awake function
	/// </summary>
	void AddPositions()
	{

		positions[0] = new Vector3(193, 0, 213);
		positions[1] = new Vector3(188, 9, 213);
		positions[2] = new Vector3(144, 1, 228);
		positions[3] = new Vector3(198, 5, 213);
		positions[4] = new Vector3(157, 4, 232);

	}

	/// <summary>
	///     This functions adds the names of the locations into the string array
	///     This function is called by the Awake function
	/// </summary>
	void AddLocations()
	{

		locations[0] = "Seminar Hall";
		locations[1] = "BTech 2nd Year Lab";
		locations[2] = "Hardware Lab";
		locations[3] = "Library";
		locations[4] = "UCCN Lab";

	}




}
