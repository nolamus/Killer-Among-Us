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
using UnityEngine;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UIElements;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

public class DialogueGraphView : GraphView
{
    //preset for scaling, readonly since not changing in runtime
    private readonly Vector2 defaultNodeSize = new Vector2();

    //constructor
    public DialogueGraphView()
    {
        //manipulators for graph
        this.AddManipulator(new ContentDragger());
        this.AddManipulator(new SelectionDragger());
        this.AddManipulator(new RectangleSelector());

        //call method for generating first node and add it to GraphView
        // (AddElement is inherited from the GraphView base class)
        AddElement(GenerateEntryPointNode());
    }

    public override List<Port> GetCompatiblePorts(Port startPort, NodeAdapter nodeAdapter)
    {
        var compatiblePorts = new List<Port>();
        ports.ForEach((port) =>
        {
            if (startPort != port && startPort.node != port.node)
                compatiblePorts.Add(port);
        });

        return compatiblePorts;
    }

    //method for generating ports for nodes, returns instantiated port
    //parameters: target node, direction of input/output port, how many nodes can be connected
    private Port GeneratePort(DialogueNode node, Direction portDirection, Port.Capacity capacity = Port.Capacity.Single)
    {
        //call InstantiatePort method on given node and parameters
        //the type parameter is arbitrary b/c no data is being transmitted between ports
        return node.InstantiatePort(Orientation.Horizontal, portDirection, capacity, typeof(float));
    }

    //method for generating first node, returns instantiated node
    private DialogueNode GenerateEntryPointNode()
    {
        //get new instance of the DialogueNode
        var node = new DialogueNode
        {
            //name of node
            title = "START",
            //generate a new GUID with default GUID class
            GUID = Guid.NewGuid().ToString(),
            //arbitrary text for DialogueText
            DialogueText = "ENTRYPOINT",
            //mark as EntryPoint node by marking boolean from "DialogueNode.cs" as true
            EntryPoint = true
        };

        //call GeneratePort method, pass in node, set direction as output
        var generatedPort = GeneratePort(node, Direction.Output);
        //change port name (important for when saving nodes)
        generatedPort.portName = "Next";
        //add port into the node
        node.outputContainer.Add(generatedPort);

        //call these methods after adding ports to output container
        //updates "visual look" and removes left-hand-side bar
        node.RefreshExpandedState();
        node.RefreshPorts();

        //set the position of the node (arbitrary)
        node.SetPosition(new Rect(100, 200, 100, 150));

        return node;
    }

    //method for adding node to GraphView
    public void CreateNode(string nodeName)
    {
        AddElement(CreateDialogueNode(nodeName));
    }

    //method for creating nodes, takes in node name & returns instantiated node
    public DialogueNode CreateDialogueNode(string nodeName)
    {
        //get new instance of the DialogueNode (just like in EntryPoint node creation)
        var dialogueNode = new DialogueNode
        {
            //set name of node
            title = nodeName,
            //set arbitrary text
            DialogueText = nodeName,
            //create a new & unique ID
            GUID = Guid.NewGuid().ToString()
        };

        //call GeneratePort method, pass in node, set direction as input
            //make capacity to be multiple to allow for branching to other nodes
        var inputPort = GeneratePort(dialogueNode, Direction.Input, Port.Capacity.Multi);
        //change port name
        inputPort.portName = "Input";
        //add inputPort into inputContainer
        dialogueNode.inputContainer.Add(inputPort);
        
        //update node visuals after modification
        dialogueNode.RefreshExpandedState();
        dialogueNode.RefreshPorts();

        //set position of node using preset variable
        dialogueNode.SetPosition(new Rect(Vector2.zero, defaultNodeSize));

        return dialogueNode;
    }
}
*/