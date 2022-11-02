using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    Rigidbody ballRB;
    GameObject target;
    GameObject mainCamera;
    Vector3 targetPosition;
    Vector3 startPosition;
    Vector3 shootingVector;
    public float force = 10f;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player");
        mainCamera = GameObject.Find("Main Camera");

        ballRB = gameObject.GetComponent<Rigidbody>();
        targetPosition = target.transform.position;
        startPosition = mainCamera.transform.position;

        shootingVector = targetPosition - startPosition;
        ballRB.AddForce(shootingVector * force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
   
            

    }
}
