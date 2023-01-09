using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class staticValue : MonoBehaviour
{
    public TextMeshProUGUI pointsStatic; //asigned in view
    //public TextMeshProUGUI playerName; //asigned in view

    
    // Start is called before the first frame update
    void Start()
    {
        MainManager.Instance.score += 30;
        pointsStatic.text = "" + MainManager.Instance.score;
        //playerName.text = MainManager.Instance.name;
    }


}
