using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourTest : MonoBehaviour
{
    // Before awake, all objects are created and initialized.
    // Use this to initialize the current object's properties or variables, which do note depend 
    // upon other object's property or variable value.
    // The scipt dont need to be enable for this to work.
    private void Awake()
    {
        Debug.Log("Awake");
    }

    // Best for resetting object properties / variables or executing some code
    // whenever a script gets enabled.
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    // OnApplicationPause is called when application comes to foreground after OnEnable (false).
    // Is also called everytime the application pauses(true).
    // To pause when application goes to background and resume when application returns to foreground:
    // Edit>projectsettings>player>Resolution and Presentation>uncheck run in background.
    // The application goes to background whenever user clicks outside game window.
    // The scipt dont need to be enable for this work.
    private void OnApplicationPause(bool pause)
    {
        Debug.Log("ApplicationHasPaused: " + pause);
    }

    // Called when application comes to resumes (true) and pauses(false).
    // The scipt dont need to be enable for this to work.
    private void OnApplicationFocus(bool focus)
    {
        Debug.Log("ApplicationHasFocused: " + focus);
    }

    // First frame of the scene is created.
    // Use to initialize the current object's properties and values which depends on
    // other objects properties and values (called after all awake methods).
    private void Start()
    {
        Debug.Log("Start");
    }

    // Frames continuarly updated and rendered.
    // Called after every predetermined fixed time interval:
    // Edit - Project Settings - Time - Fixed Time Step - 0.02.
    // Best for physics based updates.
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    // Called once for frame.
    // Best for non physics based updates, receiving user inputs, etc.
    private void Update()
    {
        Debug.Log("Update");
    }

    // Called after every update method call.
    // Can be used for keep track of current game object or other game object update.
    // For instance, move camera with respect to player movement, player will be moved  
    // first and then, the camera.
    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    // Best for for drawing GUI elements and handling GUI events.
    // Ex: Drawing a UI button, handling click event, etc.
    // Note: this is an old way for creating and handling UI for games
    // using Canvas is better.
    private void OnGUI()
    {
        Debug.Log("OnGUI");
        bool isButtonClicked = GUI.Button(new Rect(0f, 0f, 100f, 30f), "Button");
        if (isButtonClicked == true)
        {
            Debug.Log("Button Clicked");
        }
    }

    // When user quits application or stops play mode in Unity Editor.
    // Note: first loses the focus and then quits.
    // Best for saving / persisting any data.
    // Ex: Saving how much time user has played the game.
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }

    // Called whenever the script is disabled.
    // Scipt is disabled after application quit.
    // Best for cleanup code. 
    // Ex: System.GC.Collect() used to free up unused memory locations.
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    // Called when object is about to destroy, when current scene ends or unloaded,
    // after game application quits, when user stops play mode in the unity editor.
    // Best for coding when object is about to destroy.
    // Ex: Instantiating a blast effect when granade is about to destroy.
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
