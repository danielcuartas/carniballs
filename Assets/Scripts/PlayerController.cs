using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public int counter;
    float vInput;
    float hInput;

    float vSpeed = 3f;
    float hSpeed = 3f;

    [SerializeField] GameObject projectile;
    [SerializeField] TextMeshProUGUI counterText;

    AudioSource audioController;
    [SerializeField] AudioClip shootSound;
    
    bool ballInGame = false;

    StartButton startButton;
    

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        audioController = GetComponent<AudioSource>();
        startButton = GameObject.Find("Start Button").GetComponent<StartButton>();
    }

    // Update is called once per frame
    void Update()
    {
        vInput = Input.GetAxis("Vertical");
        hInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.up * vInput * vSpeed * Time.deltaTime + Vector3.left * hInput * hSpeed*Time.deltaTime);

        ballInGame = GameObject.Find("Projectile(Clone)");
        // timer += Time.deltaTime;

        // if (Input.GetKeyDown(KeyCode.Space) && (timer - splitTimer >= shootSeconds))
        if (Input.GetKeyDown(KeyCode.Space) && (!ballInGame) && startButton.isGameActive)
        {
            Instantiate(projectile, transform.position, projectile.transform.rotation);
            audioController.PlayOneShot(shootSound, 0.5f);
            // splitTimer = timer;
        }

        counterText.text = ("Score: " + counter);
    }
}
