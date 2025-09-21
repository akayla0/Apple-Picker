using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TextMeshProUGUI restartText;
    private bool isGameOver = false;

    void Start()
    {
        gameOverPanel.SetActive(false);
        restartText.gameObject.SetActive(false);
    }

  
    void Update()
    {
        if (isGameOver)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                Restart();
            }
        }
        
    }

    private IEnumerator GameOverSequence()
    {
        gameOverPanel.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        restartText.gameObject.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f;
    }

    public void SetGameOver()
    {
        isGameOver = true;
        gameOverPanel.SetActive(true);
        restartText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
