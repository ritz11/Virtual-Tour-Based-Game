/// <header>
/// Module : Change Music Volume
/// Author : Sparsh Bansal, Ritik Agrawal, Mohit Singh
/// Date of creation : 15/04/18
/// Synopsis :
///     The module is responsible for the change of background music volume.
///     It changes the volume according to the [position of the volume slider.
/// Global variables :
/// public Slider Volume;
/// public AudioSource MyMusic;
/// Functions :
/// void Update( )
/// </header>

// imports required from the UnityEngine and System modules
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMusicVolume : MonoBehaviour {

	// Variable for storing the slider for changing volume
	public Slider volume;
	// Variable for storing the audio source whos volume is to be changed.
	public AudioSource myMusic;

	/// <summary>
	/// Update is called once per frame.
	/// Changes the volume of the audio source according to the value of the volume slider.
	/// </summary>
	void Update () {
		myMusic.volume = volume.value;
	}
}
