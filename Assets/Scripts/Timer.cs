using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    StartButton startButton;
    [SerializeField] float totalTime;
    int remainingTime;
    float timer = 0;
    float startingTime;
    bool isFirstTime = true;

    [SerializeField] TextMeshProUGUI timeText;


    // Start is called before the first frame update
    void Start()
    {
        startButton = GameObject.Find("Start Button").GetComponent<StartButton>();
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (startButton.isGameActive)
        {
            if (isFirstTime) startingTime = timer + 1 ;
            isFirstTime = false;
            remainingTime = (int)((startingTime + totalTime) - timer);
            timeText.text = "Time: " + remainingTime;
            if (remainingTime <= 0)
            {
                Debug.Log("Game Over");
                isFirstTime = true;
                startButton.GameOver();
            }
        }
    }
}
