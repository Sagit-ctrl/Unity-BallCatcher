using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    GameController m_gc;

    private void Start(){
        m_gc = FindObjectOfType<GameController>();

    }

    private void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.CompareTag("Player")){
            m_gc.IncrementScore();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.CompareTag("DeathZone")){
            m_gc.SetIsGameOver(true);
            Destroy(gameObject);
        }
    }
}
