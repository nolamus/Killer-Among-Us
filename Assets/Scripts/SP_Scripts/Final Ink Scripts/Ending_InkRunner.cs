﻿using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using Ink.Runtime;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Collections.Specialized;
using UnityEngine.SceneManagement;
using System.ComponentModel.Design;

// Script for running "Ending_Dialogue" scene, which uses Ink stories

public class Ending_InkRunner : MonoBehaviour
{
	public static event Action<Story> OnCreateStory;
	private string text = "";
	public Camera blankCam;
	public Camera cam1;
	public Camera cam2;
	public Camera cam3;
	public Camera cam4;
	public Camera cam5;
	public Camera cam6;
	public Camera cam7;
	public Camera cam8;
	public Camera cam9;
	public Camera cam10;

	bool clicked = false;

	void Awake()
	{
		// Remove the default message
		RemoveChildren();
		StartStory();

		// Make sure game status is not paused
		je_PauseMenu.isPaused = false;
	}

	// Creates a new Story object with the compiled story which we can then play!
	void StartStory()
	{
		story = new Story(inkJSONAsset.text);
		if (OnCreateStory != null) OnCreateStory(story);
		RefreshView();
	}

	// This is the main function called every time the story changes. It does a few things:
	// Destroys all the old content and choices.
	// Continues over all the lines of text, then displays all the choices. If there are no choices, the story is finished!
	void RefreshView()
	{
		// Remove all the UI on screen
		RemoveChildren();

		// Read all the content until we can't continue any more
		while (story.canContinue)
		{
			// Continue gets the next line of the story
			text = story.Continue();
			// This removes any white space from the text.
			text = text.Trim();
			// Display the text on screen!
			CreateContentView(text);
		}

		// Display all the choices, if there are any!
		if (story.currentChoices.Count > 0)
		{
			for (int i = 0; i < story.currentChoices.Count; i++)
			{
				Choice choice = story.currentChoices[i];
				Button button = CreateChoiceView(choice.text.Trim());
				// Tell the button what to do when we press it
				button.onClick.AddListener(delegate {
					OnClickChoiceButton(choice);
				});
			}
		}
		// If we've read all the content and there's no choices, the story is finished!
		else
		{
			if (Menu_Story.IsStoryMode)
			{
				Button choice = CreateChoiceView("Level Select");
				choice.onClick.AddListener(delegate
				{
					// Since we are in story mode and the story is finished, return to level selection
					SceneManager.LoadScene("tv_LevelSelect");
				});
			}
			else
			{
				Button choice = CreateChoiceView("Level Select");
				choice.onClick.AddListener(delegate
				{
					// Load level selection scene once dialogue scene is done
					SceneManager.LoadScene("tv_LevelSelect");
				});
			}
		}
	}

	// When we click the choice button, tell the story to choose that choice!
	void OnClickChoiceButton(Choice choice)
	{
		// Do not allow the player to choose choices if the game is paused
		if (je_PauseMenu.isPaused)
			return;

		story.ChooseChoiceIndex(choice.index);
		RefreshView();
	}

	// Creates a textbox showing the the line of text
	void CreateContentView(string text)
	{
		// METHODS FOR SWITCHING ALL CAMERAS
		if (text == "DUMMY TEXT SCENE 1.")
		{
			// Switch cameras
			blankCam.enabled = false;

			cam1.enabled = true;
			cam2.enabled = false;
			cam3.enabled = false;
			cam4.enabled = false;
			cam5.enabled = false;
			cam6.enabled = false;
			cam7.enabled = false;
			cam8.enabled = false;
			cam9.enabled = false;
			cam10.enabled = false;

			// Create button
			Button choice = CreateChoiceView("FIRST, CLICK ME!");

			choice.onClick.AddListener(delegate
			{
				// Switch back cameras
				blankCam.enabled = true;

				cam1.enabled = false;
				cam2.enabled = false;
				cam3.enabled = false;
				cam4.enabled = false;
				cam5.enabled = false;
				cam6.enabled = false;
				cam7.enabled = false;
				cam8.enabled = false;
				cam9.enabled = false;
				cam10.enabled = false;
				// Set boolean value
				clicked = true;
				// Destroy button after it's clicked
				Destroy(choice.gameObject);
			});

			// Check against boolean value to see if button was clicked
			if (!clicked)
				return;
		}
		else if (text == "DUMMY TEXT SCENE 2.")
		{
			// Switch cameras
			blankCam.enabled = false;

			cam1.enabled = false;
			cam2.enabled = true;
			cam3.enabled = false;
			cam4.enabled = false;
			cam5.enabled = false;
			cam6.enabled = false;
			cam7.enabled = false;
			cam8.enabled = false;
			cam9.enabled = false;
			cam10.enabled = false;

			// Create button
			Button choice = CreateChoiceView("FIRST, CLICK ME!");

			choice.onClick.AddListener(delegate
			{
				// Switch back cameras
				blankCam.enabled = true;

				cam1.enabled = false;
				cam2.enabled = false;
				cam3.enabled = false;
				cam4.enabled = false;
				cam5.enabled = false;
				cam6.enabled = false;
				cam7.enabled = false;
				cam8.enabled = false;
				cam9.enabled = false;
				cam10.enabled = false;
				// Set boolean value
				clicked = true;
				// Destroy button after it's clicked
				Destroy(choice.gameObject);
			});

			// Check against boolean value to see if button was clicked
			if (!clicked)
				return;
		}
		else if (text == "DUMMY TEXT SCENE 3.")
		{
			// Switch cameras
			blankCam.enabled = false;

			cam1.enabled = false;
			cam2.enabled = false;
			cam3.enabled = true;
			cam4.enabled = false;
			cam5.enabled = false;
			cam6.enabled = false;
			cam7.enabled = false;
			cam8.enabled = false;
			cam9.enabled = false;
			cam10.enabled = false;

			// Create button
			Button choice = CreateChoiceView("FIRST, CLICK ME!");

			choice.onClick.AddListener(delegate
			{
				// Switch back cameras
				blankCam.enabled = true;

				cam1.enabled = false;
				cam2.enabled = false;
				cam3.enabled = false;
				cam4.enabled = false;
				cam5.enabled = false;
				cam6.enabled = false;
				cam7.enabled = false;
				cam8.enabled = false;
				cam9.enabled = false;
				cam10.enabled = false;
				// Set boolean value
				clicked = true;
				// Destroy button after it's clicked
				Destroy(choice.gameObject);
			});

			// Check against boolean value to see if button was clicked
			if (!clicked)
				return;
		}
		else if (text == "DUMMY TEXT SCENE 4.")
		{
			// Switch cameras
			blankCam.enabled = false;

			cam1.enabled = false;
			cam2.enabled = false;
			cam3.enabled = false;
			cam4.enabled = true;
			cam5.enabled = false;
			cam6.enabled = false;
			cam7.enabled = false;
			cam8.enabled = false;
			cam9.enabled = false;
			cam10.enabled = false;

			// Create button
			Button choice = CreateChoiceView("FIRST, CLICK ME!");

			choice.onClick.AddListener(delegate
			{
				// Switch back cameras
				blankCam.enabled = true;

				cam1.enabled = false;
				cam2.enabled = false;
				cam3.enabled = false;
				cam4.enabled = false;
				cam5.enabled = false;
				cam6.enabled = false;
				cam7.enabled = false;
				cam8.enabled = false;
				cam9.enabled = false;
				cam10.enabled = false;
				// Set boolean value
				clicked = true;
				// Destroy button after it's clicked
				Destroy(choice.gameObject);
			});

			// Check against boolean value to see if button was clicked
			if (!clicked)
				return;
		}
		else if (text == "DUMMY TEXT SCENE 5.")
		{
			// Switch cameras
			blankCam.enabled = false;

			cam1.enabled = false;
			cam2.enabled = false;
			cam3.enabled = false;
			cam4.enabled = false;
			cam5.enabled = true;
			cam6.enabled = false;
			cam7.enabled = false;
			cam8.enabled = false;
			cam9.enabled = false;
			cam10.enabled = false;

			// Create button
			Button choice = CreateChoiceView("FIRST, CLICK ME!");

			choice.onClick.AddListener(delegate
			{
				// Switch back cameras
				blankCam.enabled = true;

				cam1.enabled = false;
				cam2.enabled = false;
				cam3.enabled = false;
				cam4.enabled = false;
				cam5.enabled = false;
				cam6.enabled = false;
				cam7.enabled = false;
				cam8.enabled = false;
				cam9.enabled = false;
				cam10.enabled = false;
				// Set boolean value
				clicked = true;
				// Destroy button after it's clicked
				Destroy(choice.gameObject);
			});

			// Check against boolean value to see if button was clicked
			if (!clicked)
				return;
		}
		else if (text == "DUMMY TEXT SCENE 6.")
		{
			// Switch cameras
			blankCam.enabled = false;

			cam1.enabled = false;
			cam2.enabled = false;
			cam3.enabled = false;
			cam4.enabled = false;
			cam5.enabled = false;
			cam6.enabled = true;
			cam7.enabled = false;
			cam8.enabled = false;
			cam9.enabled = false;
			cam10.enabled = false;

			// Create button
			Button choice = CreateChoiceView("FIRST, CLICK ME!");

			choice.onClick.AddListener(delegate
			{
				// Switch back cameras
				blankCam.enabled = true;

				cam1.enabled = false;
				cam2.enabled = false;
				cam3.enabled = false;
				cam4.enabled = false;
				cam5.enabled = false;
				cam6.enabled = false;
				cam7.enabled = false;
				cam8.enabled = false;
				cam9.enabled = false;
				cam10.enabled = false;
				// Set boolean value
				clicked = true;
				// Destroy button after it's clicked
				Destroy(choice.gameObject);
			});

			// Check against boolean value to see if button was clicked
			if (!clicked)
				return;
		}
		else if (text == "DUMMY TEXT SCENE 7.")
		{
			// Switch cameras
			blankCam.enabled = false;

			cam1.enabled = false;
			cam2.enabled = false;
			cam3.enabled = false;
			cam4.enabled = false;
			cam5.enabled = false;
			cam6.enabled = false;
			cam7.enabled = true;
			cam8.enabled = false;
			cam9.enabled = false;
			cam10.enabled = false;

			// Create button
			Button choice = CreateChoiceView("FIRST, CLICK ME!");

			choice.onClick.AddListener(delegate
			{
				// Switch back cameras
				blankCam.enabled = true;

				cam1.enabled = false;
				cam2.enabled = false;
				cam3.enabled = false;
				cam4.enabled = false;
				cam5.enabled = false;
				cam6.enabled = false;
				cam7.enabled = false;
				cam8.enabled = false;
				cam9.enabled = false;
				cam10.enabled = false;
				// Set boolean value
				clicked = true;
				// Destroy button after it's clicked
				Destroy(choice.gameObject);
			});

			// Check against boolean value to see if button was clicked
			if (!clicked)
				return;
		}
		else if (text == "DUMMY TEXT SCENE 8.")
		{
			// Switch cameras
			blankCam.enabled = false;

			cam1.enabled = false;
			cam2.enabled = false;
			cam3.enabled = false;
			cam4.enabled = false;
			cam5.enabled = false;
			cam6.enabled = false;
			cam7.enabled = false;
			cam8.enabled = true;
			cam9.enabled = false;
			cam10.enabled = false;

			// Create button
			Button choice = CreateChoiceView("FIRST, CLICK ME!");

			choice.onClick.AddListener(delegate
			{
				// Switch back cameras
				blankCam.enabled = true;

				cam1.enabled = false;
				cam2.enabled = false;
				cam3.enabled = false;
				cam4.enabled = false;
				cam5.enabled = false;
				cam6.enabled = false;
				cam7.enabled = false;
				cam8.enabled = false;
				cam9.enabled = false;
				cam10.enabled = false;
				// Set boolean value
				clicked = true;
				// Destroy button after it's clicked
				Destroy(choice.gameObject);
			});

			// Check against boolean value to see if button was clicked
			if (!clicked)
				return;
		}
		else if (text == "DUMMY TEXT SCENE 9.")
		{
			// Switch cameras
			blankCam.enabled = false;

			cam1.enabled = false;
			cam2.enabled = false;
			cam3.enabled = false;
			cam4.enabled = false;
			cam5.enabled = false;
			cam6.enabled = false;
			cam7.enabled = false;
			cam8.enabled = false;
			cam9.enabled = true;
			cam10.enabled = false;

			// Create button
			Button choice = CreateChoiceView("FIRST, CLICK ME!");

			choice.onClick.AddListener(delegate
			{
				// Switch back cameras
				blankCam.enabled = true;

				cam1.enabled = false;
				cam2.enabled = false;
				cam3.enabled = false;
				cam4.enabled = false;
				cam5.enabled = false;
				cam6.enabled = false;
				cam7.enabled = false;
				cam8.enabled = false;
				cam9.enabled = false;
				cam10.enabled = false;
				// Set boolean value
				clicked = true;
				// Destroy button after it's clicked
				Destroy(choice.gameObject);
			});

			// Check against boolean value to see if button was clicked
			if (!clicked)
				return;
		}
		else if (text == "DUMMY TEXT SCENE 10.")
		{
			// Switch cameras
			blankCam.enabled = false;

			cam1.enabled = false;
			cam2.enabled = false;
			cam3.enabled = false;
			cam4.enabled = false;
			cam5.enabled = false;
			cam6.enabled = false;
			cam7.enabled = false;
			cam8.enabled = false;
			cam9.enabled = false;
			cam10.enabled = true;

			// Create button
			Button choice = CreateChoiceView("FIRST, CLICK ME!");

			choice.onClick.AddListener(delegate
			{
				// Switch back cameras
				blankCam.enabled = true;

				cam1.enabled = false;
				cam2.enabled = false;
				cam3.enabled = false;
				cam4.enabled = false;
				cam5.enabled = false;
				cam6.enabled = false;
				cam7.enabled = false;
				cam8.enabled = false;
				cam9.enabled = false;
				cam10.enabled = false;
				// Set boolean value
				clicked = true;
				// Destroy button after it's clicked
				Destroy(choice.gameObject);
			});

			// Check against boolean value to see if button was clicked
			if (!clicked)
				return;
		}
		else
		{
			Text storyText = Instantiate(textPrefab) as Text;
			storyText.text = text;
			storyText.transform.SetParent(canvas.transform, false);
		}
	}

	// Creates a button showing the choice text
	Button CreateChoiceView(string text)
	{
		// Creates the button from a prefab
		Button choice = Instantiate(buttonPrefab) as Button;
		choice.transform.SetParent(canvas.transform, false);

		// Gets the text from the button prefab
		Text choiceText = choice.GetComponentInChildren<Text>();
		choiceText.text = text;

		// Make the button expand to fit the text
		HorizontalLayoutGroup layoutGroup = choice.GetComponent<HorizontalLayoutGroup>();
		layoutGroup.childForceExpandHeight = false;

		return choice;
	}

	// Destroys all the children of this gameobject (all the UI)
	void RemoveChildren()
	{
		int childCount = canvas.transform.childCount;
		for (int i = childCount - 1; i >= 0; --i)
		{
			GameObject.Destroy(canvas.transform.GetChild(i).gameObject);
		}
	}

	[SerializeField]
	private TextAsset inkJSONAsset = null;
	public Story story;

	[SerializeField]
	private Canvas canvas = null;

	// UI Prefabs
	[SerializeField]
	private Text textPrefab = null;
	[SerializeField]
	private Button buttonPrefab = null;
}
