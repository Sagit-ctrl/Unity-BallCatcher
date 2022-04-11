using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject ball;
    public float spawnTime;
    float m_spawnTime;


    int m_score;
    bool m_isGameOver;

    UI m_ui;
    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
        m_ui = FindObjectOfType<UI>();
        m_ui.SetScoreText("Score: " + m_score);
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;
        if (m_spawnTime <= 0){
            Spawn();
            m_spawnTime = spawnTime;
        }
    }

    public void Spawn(){
        Vector2 spawnPos = new Vector2(Random.Range(-7, 7), 6);

        if (m_isGameOver)
        {   
            m_spawnTime = 0;
            m_ui.ShowGameOverPanel(true);
            return;
        }

        if (ball){
            Instantiate(ball, spawnPos, Quaternion.identity);
        }
    }

    public void Replay(){
        m_score = 0;
        m_isGameOver = false;
        m_ui.SetScoreText("Score: " + m_score);
        m_ui.ShowGameOverPanel(false);
    }

    public void SetScore(int score){
        m_score = score;
    }

    public int GetScore(){
        return m_score;
    }

    public void IncrementScore(){
        m_score++;
        m_ui.SetScoreText("Score: " + m_score);
    }

    public void SetIsGameOver(bool state){
        m_isGameOver = state;
    }

    public bool IsGameOver(){
        return m_isGameOver;
    }
}
