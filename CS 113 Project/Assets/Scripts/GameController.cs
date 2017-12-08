﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public Boundary boundary;
	public int xSegments;
	public int zSegments;
	public GameObject[] walls;

	public GUIText gameOverText;
	private bool gameOver;
	private GameObject closedDoor;
	private GameObject openDoor;

	void Start () {
		gameOver = false;
		gameOverText.text = "";
		GameObject openDoorObject = GameObject.Find("Open Door");
		if (openDoorObject != null) {
			openDoor = openDoorObject;
			openDoor.SetActive (false);
		} else {
			Debug.Log ("Cannot find 'Open Door' object");
		}
	}

	void Update(){
		if (gameOver && Input.GetKey (KeyCode.R))
			Application.LoadLevel (Application.loadedLevel);
		if (Input.GetKey (KeyCode.Escape)) Application.Quit();
	}
	public void GameOver(){
		gameOver = true;
		gameOverText.text = "Press 'R' to restart";
	}
	public void RoomComplete(){
		GameObject closedDoorObject = GameObject.Find("Closed Door");
		if (closedDoorObject != null) {
			closedDoor = closedDoorObject;
			closedDoor.SetActive (false);
		} else {
			Debug.Log ("Cannot find 'Closed Door' object");
		}
		if(openDoor != null)
			openDoor.SetActive (true);
	}
}
