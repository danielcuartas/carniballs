using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Back : MonoBehaviour
{
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject tutorialButton;
    [SerializeField] GameObject backButton;
    [SerializeField] GameObject tutorialScreen;

    Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = gameObject.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        button.onClick.AddListener(BackAction);
    }

    void BackAction()
    {
        startButton.SetActive(true);
        tutorialButton.SetActive(true);
        backButton.SetActive(false);
        tutorialScreen.SetActive(false);
    }
}
