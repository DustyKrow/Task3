using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(1);
        }
    }


    public void Respawn()
    {
        SceneManager.LoadScene(0);
    }


    public void EndGame()
    {
        Application.Quit();
    }
}


