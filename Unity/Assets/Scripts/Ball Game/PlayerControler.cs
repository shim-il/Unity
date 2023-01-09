using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerControler : MonoBehaviour
{
    private Rigidbody playerRB;
    private Collider playerCol;
    private GameObject focalPoint;
    private float powerUpStrength = 10.0f;
    private GameManager gameManager;
    private AudioSource playerAudio;
    public float speed = 5.0f;
    public bool hasPowerUp = false;
    public bool lowHeight = true;
    public int timeOnGround;
    public GameObject powerUpIndecator;
    public float jumpForce = 5;
    public AudioClip jumpSound;
    public AudioClip sinkingSound;
    public AudioClip floatingSound;
    public AudioClip collitionSound;
    public AudioClip pickupSound;
    public AudioClip winSound;
    public AudioClip powerUpColSound;
    public AudioClip gamOverSound;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerAudio = GetComponent<AudioSource>();
        focalPoint = GameObject.Find("Focal Point");
        playerCol = GetComponent<Collider>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.gameIsActive ==  true)
        {
            //move back and forth
            float forwardInput = Input.GetAxis("Vertical");
            playerRB.AddForce(focalPoint.transform.forward * forwardInput * -speed);

            //power up indecater
            powerUpIndecator.transform.position = transform.position + new Vector3(0, 3.0f, 0);

            //jump
            if(Input.GetKeyDown(KeyCode.Space) && lowHeight == true)
            {
                playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                playerAudio.PlayOneShot(jumpSound, 0.8f);
            }

            // Disables gravity
            if (transform.position.y >= 4)
            {
                lowHeight = false;
                playerRB.useGravity = false;
                playerAudio.PlayOneShot(floatingSound, 0.2f);
            }
            
            //check if player jumped
            if (transform.position.y <= 0.1)
            {
                timeOnGround++;
            }
            else
            {
                timeOnGround = 0;
            }
            
            //player will be swolowed into the ground if stayed on ground for 10 sec
            if (timeOnGround >= 1000)
            {
                playerCol.isTrigger = true;
                playerAudio.PlayOneShot(sinkingSound, 0.2f);
            }

            if(transform.position.y < -5 || transform.position.y > 12 || transform.position.z > 50 || transform.position.x > 50)
            {
                gameManager.GameOver();
                playerAudio.PlayOneShot(gamOverSound, 0.8f);
            }

            if(gameManager.points>= 6000)
            {
                gameManager.YouWin();
                playerAudio.PlayOneShot(winSound, 0.8f);
            }
        }
        
    }

    

//option for light line
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Power Up"))
        {
            hasPowerUp = true;
            powerUpIndecator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            playerAudio.PlayOneShot(pickupSound, 0.8f);
            StartCoroutine(PowerUpCountdown());
        }

    }

    IEnumerator PowerUpCountdown()
    {
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        powerUpIndecator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            playerAudio.PlayOneShot(collitionSound, 0.8f);
        }
        
        if(other.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            Rigidbody enemyRigidbody = other.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = other.gameObject.transform.position - transform.position;

            enemyRigidbody.AddForce(awayFromPlayer * powerUpStrength , ForceMode.Impulse);
            playerAudio.PlayOneShot(powerUpColSound, 0.8f);

            Debug.Log("Collided with " + other.gameObject.name + "with power up set to " + hasPowerUp);
        }
    }


}
