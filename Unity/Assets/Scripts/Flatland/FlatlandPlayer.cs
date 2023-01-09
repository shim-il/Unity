using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlatlandPlayer : MonoBehaviour
{
    private Rigidbody playerRB;
    private GameObject camra;
    public float speed = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        camra = GameObject.Find("Camras");
    }

    // Update is called once per frame
    void Update()
    {
        //move back and forth
        float forwardInput = Input.GetAxis("Vertical");
        playerRB.AddForce(camra.transform.forward * forwardInput * speed, ForceMode.Impulse);
    }
}
