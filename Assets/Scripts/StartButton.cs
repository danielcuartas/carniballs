using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartButton : MonoBehaviour
{
    // Don't forget UnityEngine.UI library!!!

    Button startButton;
    public bool isGameActive = false;

    [SerializeField] GameObject titleScreen;
    [SerializeField] GameObject scoreText;
    [SerializeField] GameObject timeText;
    [SerializeField] GameObject gameOverText;
    [SerializeField] TextMeshProUGUI gameOverScoreText;
    [SerializeField] GameObject cameraPosition;
    [SerializeField] GameObject goCameraPosition;
    [SerializeField] GameObject mainCamera;
    PlayerController playerController;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        startButton = GetComponent<Button>();
        startButton.onClick.AddListener(StartGame);
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
        isGameActive = true;
        titleScreen.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(true);
        timeText.gameObject.SetActive(true);
        mainCamera.transform.position = cameraPosition.transform.position;


    }

    public void GameOver()
    {
        score = playerController.counter;
        Debug.Log(score);
        isGameActive = false;
        gameOverText.SetActive(true);
        mainCamera.transform.position = goCameraPosition.transform.position;
        scoreText.gameObject.SetActive(false);
        timeText.gameObject.SetActive(false);
        gameOverScoreText.text = ("Score: " + score);
        Debug.Log("Show everything");
    }
}
