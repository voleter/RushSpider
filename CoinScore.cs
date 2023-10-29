using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    private void Start()
    {
        scoreText.text = "Score: " + score;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            CollectCoin(other.gameObject);
        }
    }

    private void CollectCoin(GameObject coin)
    {
        score++;
        UpdateScoreUI();
        Destroy(coin); // Destroy the collected coin.
    }

    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }
}
