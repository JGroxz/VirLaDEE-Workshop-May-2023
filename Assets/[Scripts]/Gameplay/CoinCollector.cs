using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public int coinsCollected = 0;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Collided with {other}");

        bool hasCoinTag = other.gameObject.GetComponent<CoinTag>();

        if (hasCoinTag)
        {
            // hide the coin
            other.gameObject.SetActive(false);

            // increment the score
            coinsCollected++;
        }
    }
}