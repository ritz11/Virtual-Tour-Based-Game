/// <header>
/// Module : Calculate Score
/// Author : Sparsh Bansal, Ritik Agrawal, Mohit Singh
/// Date of creation : 15/04/18
/// Synopsis :
///    This module is used to calculate the score made by the user.
/// Global variables :
///      public float distance
///      public float score
/// Functions :
///     void Start()
///     void Update()
///     void calculateScore()
/// </header>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CalculateScore : MonoBehaviour {

	public static float distance;
	public static float score;

    /// <summary>
    ///     This function is used for intiliaziation
    ///     It initializes the value of the score and the distance
    /// </summary>
    void Start () {
        distance = 0;
        score = 0;
	}
	
	/// <summary>
    ///     This function is called per frame
    /// </summary>
	void Update () {
		calculateScore ();
	}
	
    /// <summary>
    ///     This function calculates the score 
    ///     It loads the EndGame scene if the task is completed or the time has ran out
    /// </summary>
	void calculateScore()
	{
        //it is the distance between final and the start position of the task
        distance = Vector3.Distance(playerScript.FinalPosition, playerScript.StartPosition);
		score = (distance * 10/ playerScript.timeCalculator) + 100;
        if (playerScript.IsEnded == true)
        {
            SceneManager.LoadScene("EndGame");
        }
        if (playerScript.timeCalculator > 60)
        {
            score = 0;
            SceneManager.LoadScene("EndGame");
        }
    }


}
