using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

namespace HelixJump
{
    public class GameManager : MonoBehaviour
    {
        public static bool gameOver;
        public static bool levelCompleted;

        public GameObject gameOverPanel;
        public GameObject levelCompletedPanel;

        public static int currentLevelIndex;
        public Slider gameProgressSlider;
        public TextMeshProUGUI currentLevelText;
        public TextMeshProUGUI nextLevelText;

        public static int numberOfPassedRings;

        private void Awake()
        {
            currentLevelIndex = PlayerPrefs.GetInt("CurrentLevelIndex", 1);
        }

        private void Start()
        {
            Time.timeScale = 1;
            numberOfPassedRings = 0;
            gameOver = levelCompleted = false;
        }
        private void Update()
        {
            currentLevelText.text = currentLevelIndex.ToString();
            nextLevelText.text = (currentLevelIndex + 1).ToString();

            int progress = numberOfPassedRings * 100 / FindObjectOfType<HelixManagerData>().numberOfRings;
            gameProgressSlider.value = progress;

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
                    PlayerPrefs.SetInt("CurrentLevelIndex", currentLevelIndex + 1);
                    SceneManager.LoadScene("SampleScene");
                }
            }
        }
    }
}
