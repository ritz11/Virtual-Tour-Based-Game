/// <header>
/// Module : Show Label
/// Author : Sparsh Bansal, Ritik Agrawal, Mohit Singh
/// Synopsis :  This module is used to show the label of the current location of the user.
/// Date of creation : 15/04/18
/// Global variables : 
///     public Text Label
/// Functions :
///     void Start( )
///     void Update()
///     void displayLabel()
/// </header>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowLabels : MonoBehaviour {

	public Text Label;    //for showing the name of the current location
	int distance = 2;
	Vector3 spawnPosition = new Vector3 (202,0,215);  //spawn position of the user at the time of the tour

	/// <summary>
	/// Use this for initialization.
	/// Assign a spawn position to the user
	/// </summary>
	void Start () {
		transform.position = spawnPosition;
	}

	/// <summary>
	/// function for displaying current position of user
	/// </summary>
	// Update is called once per frame
	void Update () {
		int flag = 0;
		// loop checks for current position among all positions in database
		for (int i = 0; i < 5; i++)
		{
			if ((transform.position - Database.positions [i]).magnitude < distance) {
				// if location found display location
				Label.text = Database.locations [i];
				flag = 1;
			}

				
		}
		if (flag == 0) {
			Label.text = "";
		}
				
	}
}
