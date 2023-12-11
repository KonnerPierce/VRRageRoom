using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference to the TMP Text component in the Inspector
    private int score = 0;
    public GameObject victorySign;
    // public GameObject restartButton;

    public Timer timer;

    public void Start()
    {
        UpdateScoreText();
       
    }

    public void Victory()
    {
        if (score == 1030) //1030
        {
            victorySign.SetActive(true);
            timer.StopTimer();
          //  restartButton.SetActive(true);
        }

    }
    public void IncreaseScore()
    {
        score += 10;
        UpdateScoreText();
        Victory();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void RestartScene()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
