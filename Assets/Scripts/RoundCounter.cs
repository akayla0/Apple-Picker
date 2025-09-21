using TMPro;
using UnityEngine;

public class RoundCounter : MonoBehaviour
{
    public TextMeshProUGUI roundCounter;
    private int rounds = 0;
    float countdownTimer = 20f;

    void Start()
    {
        UpdateRoundText();
    }

    void Update()
    {
        if (rounds <= 4)
        {
            if (countdownTimer > 0)
            {
                countdownTimer -= Time.deltaTime;
            }
            else
            {
                ++rounds;
                UpdateRoundText();
                countdownTimer = 20f;
            }
        }
        else
        {
            GameOver Go = FindFirstObjectByType<GameOver>();
            Go.SetGameOver();
        }
    }
    void UpdateRoundText()
    {
        roundCounter.text = "Round: " + rounds.ToString();
    }
}
