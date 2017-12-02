using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour {

	public GameObject panel;

	public void SetActivityPanel()
	{
		panel.SetActive (true);
		//EditorApplication.isPaused = true;
	}

	public void HidePanel()
	{
		panel.SetActive (false);
		//EditorApplication.isPaused = false;
	}

	public void ResetSinglGame()
	{
		//SceneManager.LoadScene ("SinglGame");
		SceneManager.LoadScene("SinglGame");
	}

	public void ResetMultiplayer()
	{
		SceneManager.LoadScene("MultiplayerGame");
	}

	public void LoadMenu()
	{
		SceneManager.LoadScene("Menu");
	}


}
