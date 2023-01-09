using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LineDestroy : MonoBehaviour
{
    //public int scenNum;
    private GameObject circle_father;

    // Start is called before the first frame update
    void Start()
    {
        //sceneNum = GameObject.Find("Scene Manager");
        //scene = SceneManager.GetActiveScene();
        //circle_father = GameObject.Find("Circle Father");
    }

    // Update is called once per frame
    void Update()
    {
        circle_father = GameObject.Find("Circle Father");
        if(circle_father.gameObject.active)
        {
            Destroy(gameObject);
        }   
    }
}
