using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    public Text scoreText;
    public GameObject GameOverPanel;

    public void SetScoreText(string text){
        if (scoreText != null){
            scoreText.text = text;
        }
    }

    public void ShowGameOverPanel(bool show){
        if (GameOverPanel){
            GameOverPanel.SetActive(show);
        }
    }
}
