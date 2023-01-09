using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class WelcomeSceneManager : MonoBehaviour
{
    public int scene = 1;
    public TextMeshProUGUI welcome;
    public TextMeshProUGUI welcome1;
    public TextMeshProUGUI welcome2;
    public TextMeshProUGUI welcome3;
    public GameObject nextButton;
    public GameObject prevButton;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WelcomeText()
    {
        if(scene == 1)
        {
            scene = 2;
            welcome.gameObject.SetActive(false);
            welcome1.gameObject.SetActive(true);
        }
        else if( scene == 2)
        {
            scene = 3;
            welcome1.gameObject.SetActive(false);
            welcome2.gameObject.SetActive(true);
        }
        else if( scene == 3)
        {
            scene = 4;
            welcome2.gameObject.SetActive(false);
            welcome3.gameObject.SetActive(true);
        }
        else
        { 
            SceneManager.LoadScene("DiscoverGame");
        }
    }

    public void PrevScene()
    {
        if (scene == 1)
        {
            SceneManager.LoadScene("Home");
        }

        else if (scene == 2)
        {
            scene = 1;
            welcome1.gameObject.SetActive(false);
            welcome.gameObject.SetActive(true);
        }

        else if( scene == 3)
        {
            scene = 2;
            welcome2.gameObject.SetActive(false);
            welcome1.gameObject.SetActive(true);
        }
        
         else if( scene == 4)
        {
            scene = 3;
            welcome3.gameObject.SetActive(false);
            welcome2.gameObject.SetActive(true);
        }
    }

}
