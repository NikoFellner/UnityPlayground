using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _score = 0;

    public GameObject _loseScreen;
    public Text _scoreTxt;

    public void IncreaseScore(int increaseAmount)
    {
        _score += increaseAmount;
        if (_scoreTxt != null)
            _scoreTxt.text = "Score: " + _score;
    }

    public void LoseGame()
    {
        _loseScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
