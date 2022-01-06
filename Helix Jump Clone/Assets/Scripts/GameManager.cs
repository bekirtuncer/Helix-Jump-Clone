using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool levelCompleted;

    public GameObject gameOverPanel;
    public GameObject levelCompletedPanel;

    private void Start()
    {
        Time.timeScale = 1;
        gameOver = levelCompleted = false;
    }
    private void Update()
    {
        LevelController();
    }

    private void LevelController()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);

            if (Input.GetButtonDown("Fire1"))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }

        if (levelCompleted)
        {
            levelCompletedPanel.SetActive(true);

            if (Input.GetButtonDown("Fire1"))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
