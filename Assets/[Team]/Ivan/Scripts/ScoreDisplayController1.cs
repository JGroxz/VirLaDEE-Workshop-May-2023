using TMPro;
using UnityEngine;

public class ScoreDisplayController1 : MonoBehaviour
{
    public CoinCollector coinCollector;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI completionText;

    private int totalCoins = -1;

    private void Start()
    {
        // calculate total number of coins
        CoinTag[] allCoins = FindObjectsOfType<CoinTag>();
        totalCoins = allCoins.Length;

        // hide the completion message
        completionText.gameObject.SetActive(false);
    }

    private void Update()
    {
        UpdateScoreText();
        CheckForGameCompletion();
    }

    private void UpdateScoreText()
    {
        int score = coinCollector.coinsCollected;

        scoreText.text = $"Coins collected: {score}/{totalCoins}";
    }

    private void CheckForGameCompletion()
    {
        bool isCompleted = coinCollector.coinsCollected >= totalCoins;

        if (isCompleted)
        {
            completionText.gameObject.SetActive(true);
        }
    }
}