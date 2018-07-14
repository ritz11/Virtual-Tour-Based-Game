/// <header>
/// Module : Display Score
/// Author : Sparsh Bansal, Ritik Agrawal, Mohit Singh
/// Date of creation : 15/04/18
/// Synopsis :
///     The module is responsible for the display of score at the end of the game.
/// Global variables :
///     public Text ScoreFinal
/// Functions :
///     void Start( )
///     void PrintScore()
/// </header>

// imports required from the UnityEngine and System modules
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayScore : MonoBehaviour {

	// Variable storing the text to be displayed.
	public Text scoreFinal;

	/// <summary>
	/// Use this for initialization
	/// Get the score from the TaskAllocation module
	/// </summary>
	void Start () {
		PrintScore ();
	}

	/// <summary>
	///     Prints the final score on the screen 
	/// </summary>
	void PrintScore()
	{
		scoreFinal.text = "   SCORE :         " + CalculateScore.score.ToString("####0.00"); // Limit the decimal places of the score to be displayed. 
	}
}
