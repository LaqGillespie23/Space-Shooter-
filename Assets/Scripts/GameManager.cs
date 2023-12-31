using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool _isGameOver;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && _isGameOver == true) //if R key was pressed //restart the current game scene
        {
            SceneManager.LoadScene(1); // Current Game Scene
        }

    
        //if escape key is pressed 
        //quit application 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }


    public void GameOver()
    {
        _isGameOver = true;
    }
}
