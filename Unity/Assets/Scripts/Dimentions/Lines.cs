using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Lines : MonoBehaviour
{
    public GameObject line;
    public GameObject arrow;
    public GameObject circle_father;
    public Transform linePos;
    public Transform arrowPos;
    public TextMeshProUGUI text_first;
    private int lineSize = 0;
    private float spawnPosX;
    private float spawnPosY;
    private float spawnPosZ;
    private Scene scene;


    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        spawnPosX = linePos.position.x;
        spawnPosY = linePos.position.y;
        spawnPosZ = linePos.position.z;
        StartCoroutine(CreateLine());
    }

    // Update is called once per frame
    void Update()
    {
        if (text_first.gameObject.active && scene.name == "Dimensions")
        {
            circle_father.gameObject.SetActive(true);
        }
    }

    IEnumerator CreateLine()
    {
        while(lineSize < 50)
        {
            Instantiate(line, GenerateLinePosition(), linePos.rotation);
            lineSize++;
            yield return null;
        }
    }

    private Vector3 GenerateLinePosition()
    {
        spawnPosX = spawnPosX + 0.01f;


        

        Vector3 newPos = new Vector3(spawnPosX,spawnPosY,spawnPosZ);

        return newPos;
    }
}
