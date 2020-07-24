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

// Script for running "L2_Dialogue" scene, which uses Ink stories

public class L2_InkRunner : MonoBehaviour
{
	public static event Action<Story> OnCreateStory;
	private string text = "";
	public Camera blankCam;
	public Camera cam1;
	public Camera cam2;
	public Camera cam3;

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
				Button choice = CreateChoiceView("Continue Story");
				choice.onClick.AddListener(delegate
				{
					// Since we are in story mode, load next dialogue scene
					SceneManager.LoadScene("L3_Dialogue");
				});
			}
			else
			{
				Button choice = CreateChoiceView("Return to Level Select");
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
		// Method for switching cameras
		if (text == "This is dummy text.")
		{
			// Switch cameras
			blankCam.enabled = false;
			cam1.enabled = true;

			// Create button
			Button choice = CreateChoiceView("CLICK ME!");

			choice.onClick.AddListener(delegate
			{
				// Switch back cameras
				blankCam.enabled = true;
				cam1.enabled = false;
				// Set boolean value
				clicked = true;
				// Destroy button after it's clicked
				Destroy(choice.gameObject);
			});

			// Check against boolean value to see if button was clicked
			if (!clicked)
				return;
		}

		Text storyText = Instantiate(textPrefab) as Text;
		storyText.text = text;
		storyText.transform.SetParent(canvas.transform, false);
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
