using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManu : MonoBehaviour {

	public void StartMultiplayer()
	{
		SceneManager.LoadScene ("MultiplayerGame");
	}

	public void StartSingGame()
	{
		SceneManager.LoadScene ("SinglGame");
	}
}
