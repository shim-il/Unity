using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExampleCtrl3D : MonoBehaviour
{
private Rigidbody playerRB;
    private bool gameStart;
    public float speed = 5.0f;
    public float rotateCamreraSpeed = 5.0f;
    public GameObject sceneScript;
    public GameObject changeCharectorTxt;
    public GameObject player2D;
    public GameObject player3D;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        gameStart = sceneScript.GetComponent<SpecialSceneManager>().gameOn;

        if(gameStart)
        {
            //change direction
            float horizantolInput = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.up, Time.deltaTime * rotateCamreraSpeed * horizantolInput);

            //move back and forth
            float forwardInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * forwardInput * speed * Time.deltaTime);
        }

        if (changeCharectorTxt.gameObject.activeSelf)
        {
            player2D.gameObject.SetActive(false);
            player3D.gameObject.SetActive(true);
        }
        else
        {
            player2D.gameObject.SetActive(true);
            player3D.gameObject.SetActive(false);
        }
    }
}
