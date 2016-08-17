﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO;

public class GameManagerScript : MonoBehaviour {
	
	#region Refrences For Simplicity

		/// <summary>
		/// The player. Used for grabbing information without having to keep calling GameObject.Find().
		/// </summary>
		PlayerControls Player;

		/// <summary>
		/// The ladder.
		/// </summary>
		GameObject Ladder;

	#endregion

	/// <summary>
	/// An array of sprites for each item.
	/// </summary>
	public Sprite[] ItemSprites;

	/// <summary>
	/// A list of all of the different types of enemies that could be spawned.
	/// </summary>
	public GameObject[] Enemies;

	/// <summary>
	/// This is an array that represents the different floors that the player must travel through.
	/// </summary>
	string[] Underground = {"Underground_1", "Underground_1_2", "Underground_2", "Underground_2_2", 
							"Underground_3", "Underground_3_2", "Underground_4", "Underground_4_2", 
							"Underground_Boss"};

	/// <summary>
	/// The current floor that the player is on by its index in the array above.
	/// </summary>
	int CurrentFloor;


	// Use this for initialization
	public void Start () {
		if (SceneManager.GetActiveScene().buildIndex != 0 && SceneManager.GetActiveScene().buildIndex != 1
		   && SceneManager.GetActiveScene().buildIndex != 2)
		{
			CurrentFloor = SceneManager.GetActiveScene().buildIndex;
		}

		Player = GameObject.FindWithTag("Player").GetComponent<PlayerControls>();
		Ladder = GameObject.Find("Ladder(Clone)");
	}
	
	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene().buildIndex != 0 && SceneManager.GetActiveScene().buildIndex != 1
		   && SceneManager.GetActiveScene().buildIndex != 2)
		{
			if (GetComponent<BoardCreator>().ladder != null)
			{
				if (Player.MyBoxCollider.IsTouching(Ladder.GetComponent<BoxCollider2D>()))
				{
					CurrentFloor++;
					SceneManager.LoadScene(Underground[CurrentFloor - 3]);
				}
			}
		}
		SecondaryUseItems.ResetCharges();
	}

}
