/// <header>
/// Module : Load Scene On Click
/// Author : Sparsh Bansal, Ritik Agrawal, Mohit Singh
/// Date of creation : 15/04/18
/// Synopsis :
///     The module is responsible for the change of scene when a button is clicked.
/// Global variables :
///     public int SceneIndex;
/// Functions :
///     public void LoadByIndex( )
/// </header>

// imports required from the UnityEngine and System modules
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class LoadSceneOnClick : MonoBehaviour {

	//this variable stores the index of scene to be opened when button is clicked
	public int SceneIndex;

	/// <summary>
	/// Load the new scene according to the Scene index.
	/// </summary>
	public void LoadByIndex(){

		SceneManager.LoadScene (SceneIndex);
	}
}
