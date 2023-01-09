using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerInfo : MonoBehaviour
{
    public InputField iField;
    //public TextMeshProUGUI name;
    //public InputField playerAge;
    public string playerName;
    //public int Age;
    //public GameObject nameOfPlayer;

    // Start is called before the first frame update
    void Start()
    {
        playerName = iField.text;
        //playerAge = gameObject.Find("PlayerAge");
        //nameOfPlayer = playerName;
        Debug.Log(playerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
