using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {

	public void LoadByIndex(int sceneIndex)
	{
        if (sceneIndex == 0 && SceneManager.GetActiveScene().name != "Credits" && SceneManager.GetActiveScene().name != "About")
        {
            Destroy(GameObject.Find("MusicController"));
        }
        if (sceneIndex == 1)
        {
            Destroy(GameObject.Find("MusicController"));
        }
		SceneManager.LoadScene (sceneIndex);
	}
}
