using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private float spawnRange = 9.0f;
    private GameObject player;
    public GameObject playButton;
    public TextMeshProUGUI tryAnotherWayTXT;
    public TextMeshProUGUI findPattern;
    public TextMeshProUGUI pointsTXT;
    public TextMeshProUGUI youWinTXT;
    //public TextMeshProUGUI pointsUpTXT;
    public GameObject discoverTXT;
    public int points = 0;
    public Button restartButton;
    public bool gameIsActive = false;
    public GameObject enemyPrefab;
    public GameObject powerUpPrefab;
    public GameObject enemy;
    public int enemyCount;
    public int enemyWaveNum;
    public static int swallowedNum = 0;
    public static int attemptNum;
    public GameObject prevButton;
    public GameObject tryLoosingTXT;
    public GameObject tryUsingAllTXT;
    public GameObject tryJumpingHeightsTXT;
    public GameObject tryNotJumpingTXT;
    public GameObject whatEffectsPointsTXT;
    public TextMeshProUGUI pointsUpTXT;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        enemy = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
       if(enemy.transform.position.y < 5)
            {
                pointsUpTXT.gameObject.SetActive(true);
                Invoke("pointBounesTXT", 2.0f);
            }
    }

    void pointBounesTXT()
    {
        //pointsUpTXT.GameObject.SetActive(false);
    }

    IEnumerator SpawnEnemy()
    {
        while(gameIsActive)
        {
            yield return new WaitForSeconds(1);
            points += 5;
            pointsTXT.text = "Points: " + points;

            enemyCount = FindObjectsOfType<Enemy>().Length;

            if(enemyCount == 0)
            {
                enemyWaveNum++;
                SpawnEnemyWave(enemyWaveNum);
                Instantiate(powerUpPrefab, GenerateSpawnPosition() , powerUpPrefab.transform.rotation);
            }
        }
    }

    public void StartGame()
    {
        playButton.gameObject.SetActive(false);
        prevButton.gameObject.SetActive(false);
        discoverTXT.gameObject.SetActive(false);
        tryLoosingTXT.gameObject.SetActive(false);
        tryUsingAllTXT.gameObject.SetActive(false);
        tryNotJumpingTXT.gameObject.SetActive(false);
        tryJumpingHeightsTXT.gameObject.SetActive(false);
        whatEffectsPointsTXT.gameObject.SetActive(false);
        gameIsActive = true;
        attemptNum = Random.Range(0,5);
        StartCoroutine(SpawnEnemy());
    }


    public void GameOver()
    {
        gameIsActive = false;
        restartButton.gameObject.SetActive(true);

        if(player.transform.position.y < -0.2 && swallowedNum < 3 && player.transform.position.x > 14.2 && player.transform.position.x < -14.2 && player.transform.position.z > 12.2 && player.transform.position.z < -12.2) 
        {
            swallowedNum++;
            tryNotJumpingTXT.gameObject.SetActive(true);
        }
        else if(player.transform.position.y < -0.2 && swallowedNum >= 3)
            {
                tryUsingAllTXT.gameObject.SetActive(true);
            }
            else if(player.transform.position.y >= 4.2)
                {
                    tryJumpingHeightsTXT.gameObject.SetActive(true);
                }
                else if(points > 300)
                {
                    whatEffectsPointsTXT.gameObject.SetActive(true);
                }
                else if(attemptNum < 2)
                    {
                        tryLoosingTXT.gameObject.SetActive(true);
                    }
                    else if(attemptNum >= 2 && attemptNum < 4)
                        {
                            findPattern.gameObject.SetActive(true);
                        }
                        else
                        {
                            tryAnotherWayTXT.gameObject.SetActive(true);
                        }
    }

    public void RestartGame()
    {
        tryAnotherWayTXT.gameObject.SetActive(false);
        findPattern.gameObject.SetActive(false);
        SceneManager.LoadScene("DiscoverGame");
    }

    public void PrevScene()
    {
        SceneManager.LoadScene("DiscoverGameWelcome");
    }

    public void YouWin()
    {
        gameIsActive = false;
        youWinTXT.gameObject.SetActive(true);
    }

    void SpawnEnemyWave(int enemysToSpawn)
    {
        for(int i = 0; i < enemysToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition() , enemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange , spawnRange);
        float spawnPosZ = Random.Range(-spawnRange , spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX,0,spawnPosZ);

        return randomPos;
    }

    

}
