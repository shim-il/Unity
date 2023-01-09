using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRB;
    private GameObject player;
    private GameManager gameManager;
    public float speed = 3.0f;
    //public TextMeshProUGUI pointsUpTXT;

    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        //pointsUpTXT = GameObject.Find("PointsUp");
        //StartCoroutine(BounesPointsReview());
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = (player.transform.position - transform.position).normalized;
        enemyRB.AddForce(moveDirection * speed);

        if(transform.position.y < -8)
        {
            gameManager.points += 500;
            Destroy(gameObject);
            //pointsUpTXT.GameObject.SetActive(true);
            //Invoke("pointBounesTXT", 2.0f);
        }
    }

    /*void pointBounesTXT()
    {
        pointsUpTXT.GameObject.SetActive(false);
    }*/

}
