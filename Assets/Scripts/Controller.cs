using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Controller : MonoBehaviour
{

    void Start()
    {
        //Forces cursor to be visible for the game over menu
        Cursor.visible = true;
        //Unlocks the cursor in the gameover menu
        Cursor.lockState = CursorLockMode.None;
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //Pulls up the game over menu when escape is pressed.
        {
            SceneManager.LoadScene(1);
        }
    }

}
