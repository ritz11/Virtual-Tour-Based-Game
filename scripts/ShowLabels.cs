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
/// 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowLabels : MonoBehaviour {

	public Text Label;      //for showing the name of the current location 
	int distance = 2;
	Vector3 SpawnPosition = new Vector3 (202,0,215);    //spawn position of the user at the time of the tour

	// Use this for initialization
	void Start () {
		transform.position = SpawnPosition;
	}

	// Update is called once per frame
	void Update () {
        //function call
        displayLabel();			
	}

    //function for displaying the label of the current location of the user
    void displayLabel()
    {
        //loop checks the current posiiton among all the locations stored in the database
        for (int i = 0; i < 5; i++)
        {
            if ((transform.position - Database.positions[i]).magnitude < distance)
            {   
                //if the location is found then display the name of the location
                Label.text = Database.locations[i];
            }
        }
        Label.text = "";
    }
}
