using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private TMP_Text scoreText;
    public static GameManager Instance {  get; private set; }
    private int score;
    private float timer;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        score = 0;
    }

    void Update()
    {
        int scoreSeconds = 10;

        timer += Time.deltaTime;
        score = (int)(timer * scoreSeconds);

        scoreText.text = "Score: " + score.ToString("F");

    }

    public void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

}
