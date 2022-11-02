using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject tutorialButton;
    [SerializeField] GameObject backButton;
    [SerializeField] GameObject tutorialScreen;

    Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        button.onClick.AddListener(ButtonClick);
    }

    void ButtonClick()
    {
        startButton.gameObject.SetActive(false);
        tutorialButton.gameObject.SetActive(false);
        backButton.gameObject.SetActive(true);
        tutorialScreen.gameObject.SetActive(true);
    }
}
