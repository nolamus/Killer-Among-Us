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

// Script for running "L1_Dialogue" scene, which uses Ink stories

public class L1_InkRunner : MonoBehaviour
{
	public static event Action<Story> OnCreateStory;
	private string text = "";
	public Camera blankCam;
	public Camera cam1;
	public Camera cam2;
	public Camera cam3;
	public Camera cam4;

	void Awake()
	{
		// Remove the default message
		RemoveChildren();
		StartStory();
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

		// Method for switching cameras
		if (text == "Concierge: You're stronger than you look.")
		{
			cam1.enabled = false;
			cam2.enabled = true;

			Button choice = CreateChoiceView("Change Camera");
			bool clicked = false;

			choice.onClick.AddListener(delegate
			{
				UnityEngine.Debug.Log("Button pressed");
				cam1.enabled = true;
				cam2.enabled = false;
				clicked = true;

				Destroy(choice.gameObject);
			});
		}
		
		
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
			Button choice = CreateChoiceView("Return to Level Select");
			choice.onClick.AddListener(delegate {
				// Load level selection scene once dialogue scene is done
				SceneManager.LoadScene("tv_LevelSelect");
			});
		}
	}

	// When we click the choice button, tell the story to choose that choice!
	void OnClickChoiceButton(Choice choice)
	{
		story.ChooseChoiceIndex(choice.index);
		RefreshView();
	}

	// Creates a textbox showing the the line of text
	void CreateContentView(string text)
	{
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
