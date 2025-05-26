using UnityEngine;
using TMPro;

public class SurvivalTimer : MonoBehaviour
{
    public float survivalTime = 30f;
    public TextMeshProUGUI timerText;

    void Update()
    {
        if (survivalTime > 0)
        {
            survivalTime -= Time.deltaTime;
            timerText.text = $"Survive: {Mathf.Ceil(survivalTime)}s";
        }
        else
        {
            timerText.text = "Survived!";
            Time.timeScale = 0; // Pause game
        }
    }
}
