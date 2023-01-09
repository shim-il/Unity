using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DiscoverContentSceneManager : MonoBehaviour
{
    public TextMeshProUGUI gameSumText;
    public TextMeshProUGUI conclution1;
    public TextMeshProUGUI conclution2;
    public TextMeshProUGUI conclution3;
    public GameObject gameRulesInput;
    public GameObject nextButton;
    public int scene = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ContentFlow()
    {
        if(scene == 1)
        {
            scene = 2;
            gameSumText.gameObject.SetActive(false);
            gameRulesInput.gameObject.SetActive(true);
        }
        else if( scene == 2)
        {
            scene = 3;
            gameRulesInput.gameObject.SetActive(false);
            conclution1.gameObject.SetActive(true);
        }
        else if( scene == 3)
        {
            scene = 4;
            conclution1.gameObject.SetActive(false);
            conclution2.gameObject.SetActive(true);
        }
        else if( scene == 4)
        {
            scene = 5;
            conclution2.gameObject.SetActive(false);
            conclution3.gameObject.SetActive(true);
        }
        /*else
        { 
            SceneManager.LoadScene("DiscoverGame");
        }*/
    }
}
