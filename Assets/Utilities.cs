using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Utilities : MonoBehaviour
{
    private int Score = 1;
    public Text txtScore;
    public GameObject GameOverScreen;

    [ContextMenu("Add Score")]
    public void addScore()
    {
        txtScore.text = Score++.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
