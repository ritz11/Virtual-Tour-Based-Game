/// <header>
/// Module : Quit On Click
/// Author : Sparsh Bansal, Ritik Agrawal, Mohit Singh
/// Date of creation : 15/04/18
/// Synopsis :
///     The module is responsible for the qitting of the game when the desired button is clicked.
/// Functions :
///     public void Quit( )
/// </header>

// imports required from the UnityEngine and System modules
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnClick : MonoBehaviour {

	/// <summary>
	/// Quit the application when the quit button is clicked.
	/// </summary>
	public void Quit()
	{
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
	}
}
