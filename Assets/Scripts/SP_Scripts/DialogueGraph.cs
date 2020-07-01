/*  SCRIPT COMMENTED OUT:
This method of creating a dialogue tree within Unity itself proved to be tedious.
Instead, Ink (a powerful scripting language), was used for the dialogue tree. This
script has been commented out in order to prevent it from affecting Editor settings
and increasing compile time.
*/

/*
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

public class DialogueGraph : EditorWindow
{
    //variable for tracking instance of GraphView
    private DialogueGraphView _graphView;

    //ability to call it statically from the editor
    [MenuItem("Graph/Dialogue Graph")]
    //static method for opening graph window
    public static void OpenDialogueGraphWindow()
    {
        var window = GetWindow<DialogueGraph>();
        window.titleContent = new GUIContent("Dialogue Graph");
    }

    //similar to regular Unity Start method
    private void OnEnable()
    {
        //call for initializing GraphView
        ConstructGraphView();
        //call for making toolbar for making new nodes
        GenerateToolbar();
    }

    //method for initializing GraphView
    private void ConstructGraphView()
    {
        //get new instance of GraphView
        _graphView = new DialogueGraphView
        {
            //pass in name of the graph
            name = "Dialogue Graph"
        };

        //stretch graph all over the area window
        _graphView.StretchToParentSize();
        //add to the editor window
        rootVisualElement.Add(_graphView);
    }

    //method for making toolbar for creating new nodes
    private void GenerateToolbar()
    {
        //get instance of toolbar (provided by Unity by default)
        var toolbar = new Toolbar();

        //button for triggering node creation w/ lambda expression by passing in the node name
        var nodeCreateButton = new Button(() => { _graphView.CreateNode("Dialogue Node"); });
        //name button
        nodeCreateButton.text = "Create Node";
        //add button name to toolbar as UI element
        toolbar.Add(nodeCreateButton);

        //add toolbar into editor window
        rootVisualElement.Add(toolbar);
    }

    //similar to regular Unity Destroy method
    private void OnDisable()
    {
        //remove window when disabled in order to prevent overlap
        rootVisualElement.Remove(_graphView);
    }
}
*/