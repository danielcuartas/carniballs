using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject boxPrefab;
    [SerializeField] GameObject boxCollider;
    [SerializeField] int boxCount = 0;

    StartButton startButton;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBox", 0, 2f);
        startButton = GameObject.Find("Start Button").GetComponent<StartButton>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnBox()
    {
        if (startButton.isGameActive)
        {
            Instantiate(boxPrefab);
            Instantiate(boxCollider);
            boxCount++;

            if (boxCount >= 5)
            {
                CancelInvoke();
            }
        }
    }
}
