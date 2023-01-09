using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class AllSceneManager : MonoBehaviour
{
    public int scene = 1;
    public TextMeshProUGUI text_1;
    public TextMeshProUGUI text_2;
    public TextMeshProUGUI text_3;
    public TextMeshProUGUI text_4;
    public TextMeshProUGUI text_5;
    public TextMeshProUGUI text_6;
    public TextMeshProUGUI text_7;
    public TextMeshProUGUI text_8;
    public TextMeshProUGUI text_9;
    public TextMeshProUGUI text_10;
    public TextMeshProUGUI text_11;
    public TextMeshProUGUI text_12;
    public TextMeshProUGUI text_13;
    public TextMeshProUGUI text_14;
    public TextMeshProUGUI text_15;
    public TextMeshProUGUI text_16;
    public TextMeshProUGUI text_17;
    public TextMeshProUGUI text_18;
    public TextMeshProUGUI text_19;
    public TextMeshProUGUI text_20;
    public TextMeshProUGUI text_21;
    public TextMeshProUGUI text_22;
    public TextMeshProUGUI text_23;
    public TextMeshProUGUI text_24;
    public TextMeshProUGUI text_25;
    public TextMeshProUGUI text_26;
    public TextMeshProUGUI text_27;
    public TextMeshProUGUI text_28;
    public TextMeshProUGUI text_29;
    public TextMeshProUGUI text_30;
    public TextMeshProUGUI text_31;
    public TextMeshProUGUI text_32;
    public TextMeshProUGUI text_33;
    public TextMeshProUGUI text_34;
    public TextMeshProUGUI text_35;
    public TextMeshProUGUI text_36;
    public TextMeshProUGUI text_37;



    public void NextScene()
    {
        if (scene == 1 && text_2 != null)
        {
            scene = 2;
            text_1.gameObject.SetActive(false);
            text_2.gameObject.SetActive(true);
        }
        else if (scene == 2 && text_3 != null)
        {
            scene = 3;
            text_2.gameObject.SetActive(false);
            text_3.gameObject.SetActive(true);
        }
        else if (scene == 3 && text_4 != null)
        {
            scene = 4;
            text_3.gameObject.SetActive(false);
            text_4.gameObject.SetActive(true);
        }
        else if (scene == 4 && text_5 != null)
        {
            scene = 5;
            text_4.gameObject.SetActive(false);
            text_5.gameObject.SetActive(true);
        }
        else if (scene == 5 && text_6 != null)
        {
            scene = 6;
            text_5.gameObject.SetActive(false);
            text_6.gameObject.SetActive(true);
        }
        else if (scene == 6 && text_7 != null)
        {
            scene = 7;
            text_6.gameObject.SetActive(false);
            text_7.gameObject.SetActive(true);
        }
        else if (scene == 7 && text_8 != null)
        {
            scene = 8;
            text_7.gameObject.SetActive(false);
            text_8.gameObject.SetActive(true);
        }
        else if (scene == 8 && text_9 != null)
        {
            scene = 9;
            text_8.gameObject.SetActive(false);
            text_9.gameObject.SetActive(true);
        }
        else if (scene == 9 && text_10 != null)
        {
            scene = 10;
            text_9.gameObject.SetActive(false);
            text_10.gameObject.SetActive(true);
        }
        else if (scene == 10 && text_11 != null)
        {
            scene = 11;
            text_10.gameObject.SetActive(false);
            text_11.gameObject.SetActive(true);
        }
        else if (scene == 11 && text_12 != null)
        {
            scene = 12;
            text_11.gameObject.SetActive(false);
            text_12.gameObject.SetActive(true);
        }
        else if (scene == 12 && text_13 != null)
        {
            scene = 13;
            text_12.gameObject.SetActive(false);
            text_13.gameObject.SetActive(true);
        }
        else if (scene == 13 && text_14 != null)
        {
            scene = 14;
            text_13.gameObject.SetActive(false);
            text_14.gameObject.SetActive(true);
        }
        else if (scene == 14 && text_15 != null)
        {
            scene = 15;
            text_14.gameObject.SetActive(false);
            text_15.gameObject.SetActive(true);
        }
        else if (scene == 15 && text_16 != null)
        {
            scene = 16;
            text_15.gameObject.SetActive(false);
            text_16.gameObject.SetActive(true);
        }
        else if (scene == 16 && text_17 != null)
        {
            scene = 17;
            text_16.gameObject.SetActive(false);
            text_17.gameObject.SetActive(true);
        }
        else if (scene == 17 && text_18 != null)
        {
            scene = 18;
            text_17.gameObject.SetActive(false);
            text_18.gameObject.SetActive(true);
        }
        else if (scene == 18 && text_19 != null)
        {
            scene = 19;
            text_18.gameObject.SetActive(false);
            text_19.gameObject.SetActive(true);
        }
        else if (scene == 19 && text_20 != null)
        {
            scene = 20;
            text_19.gameObject.SetActive(false);
            text_20.gameObject.SetActive(true);
        }
        else if (scene == 20 && text_21 != null)
        {
            scene = 21;
            text_20.gameObject.SetActive(false);
            text_21.gameObject.SetActive(true);
        }
        else if (scene == 21 && text_22 != null)
        {
            scene = 22;
            text_21.gameObject.SetActive(false);
            text_22.gameObject.SetActive(true);
        }
        else if (scene == 22 && text_23 != null)
        {
            scene = 23;
            text_22.gameObject.SetActive(false);
            text_23.gameObject.SetActive(true);
        }
        else if (scene == 23 && text_24 != null)
        {
            scene = 24;
            text_23.gameObject.SetActive(false);
            text_24.gameObject.SetActive(true);
        }
        else if (scene == 24 && text_25 != null)
        {
            scene = 25;
            text_24.gameObject.SetActive(false);
            text_25.gameObject.SetActive(true);
        }
        else if (scene == 25 && text_26 != null)
        {
            scene = 26;
            text_25.gameObject.SetActive(false);
            text_26.gameObject.SetActive(true);
        }
        else if (scene == 26 && text_27 != null)
        {
            scene = 27;
            text_26.gameObject.SetActive(false);
            text_27.gameObject.SetActive(true);
        }
        else if (scene == 27 && text_28 != null)
        {
            scene = 28;
            text_27.gameObject.SetActive(false);
            text_28.gameObject.SetActive(true);
        }
        else if (scene == 28 && text_29 != null)
        {
            scene = 29;
            text_28.gameObject.SetActive(false);
            text_29.gameObject.SetActive(true);
        }
        else if (scene == 29 && text_30 != null)
        {
            scene = 30;
            text_29.gameObject.SetActive(false);
            text_30.gameObject.SetActive(true);
        }
        else if (scene == 30 && text_31 != null)
        {
            scene = 31;
            text_30.gameObject.SetActive(false);
            text_31.gameObject.SetActive(true);
        }
        else if (scene == 31 && text_32 != null)
        {
            scene = 32;
            text_31.gameObject.SetActive(false);
            text_32.gameObject.SetActive(true);
        }
        else if (scene == 32 && text_33 != null)
        {
            scene = 33;
            text_32.gameObject.SetActive(false);
            text_33.gameObject.SetActive(true);
        }
        else if (scene == 33 && text_34 != null)
        {
            scene = 34;
            text_33.gameObject.SetActive(false);
            text_34.gameObject.SetActive(true);
        }
        else if (scene == 34 && text_35 != null)
        {
            scene = 35;
            text_34.gameObject.SetActive(false);
            text_35.gameObject.SetActive(true);
        }
        else if (scene == 35 && text_36 != null)
        {
            scene = 36;
            text_35.gameObject.SetActive(false);
            text_36.gameObject.SetActive(true);
        }
        else if (scene == 36 && text_37 != null)
        {
            scene = 37;
            text_36.gameObject.SetActive(false);
            text_37.gameObject.SetActive(true);
        }
        else
        { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);        
        }
    }

    public void PrevScene()
    {
        if (scene == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); 
        }

        else if (scene == 2 && text_1 != null)
        {
            scene = 1;
            text_2.gameObject.SetActive(false);
            text_1.gameObject.SetActive(true);
        }
        else if (scene == 3 && text_2 != null)
        {
            scene = 2;
            text_3.gameObject.SetActive(false);
            text_2.gameObject.SetActive(true);
        }
        else if (scene == 4 && text_3 != null)
        {
            scene = 3;
            text_4.gameObject.SetActive(false);
            text_3.gameObject.SetActive(true);
        }
        else if (scene == 5 && text_4 != null)
        {
            scene = 4;
            text_5.gameObject.SetActive(false);
            text_4.gameObject.SetActive(true);
        }
        else if (scene == 6 && text_5 != null)
        {
            scene = 5;
            text_6.gameObject.SetActive(false);
            text_5.gameObject.SetActive(true);
        }
        else if (scene == 7 && text_6 != null)
        {
            scene = 6;
            text_7.gameObject.SetActive(false);
            text_6.gameObject.SetActive(true);
        }
        else if (scene == 8 && text_7 != null)
        {
            scene = 7;
            text_8.gameObject.SetActive(false);
            text_7.gameObject.SetActive(true);
        }
        else if (scene == 9 && text_8 != null)
        {
            scene = 8;
            text_9.gameObject.SetActive(false);
            text_8.gameObject.SetActive(true);
        }
        else if (scene == 10 && text_9 != null)
        {
            scene = 9;
            text_10.gameObject.SetActive(false);
            text_9.gameObject.SetActive(true);
        }
        else if (scene == 11 && text_10 != null)
        {
            scene = 10;
            text_11.gameObject.SetActive(false);
            text_10.gameObject.SetActive(true);
        }
        else if (scene == 12 && text_11 != null)
        {
            scene = 11;
            text_12.gameObject.SetActive(false);
            text_11.gameObject.SetActive(true);
        }
        else if (scene == 13 && text_12 != null)
        {
            scene = 12;
            text_13.gameObject.SetActive(false);
            text_12.gameObject.SetActive(true);
        }
        else if (scene == 14 && text_13 != null)
        {
            scene = 13;
            text_14.gameObject.SetActive(false);
            text_13.gameObject.SetActive(true);
        }
        else if (scene == 15 && text_14 != null)
        {
            scene = 14;
            text_15.gameObject.SetActive(false);
            text_14.gameObject.SetActive(true);
        }
        else if (scene == 16 && text_15 != null)
        {
            scene = 15;
            text_16.gameObject.SetActive(false);
            text_15.gameObject.SetActive(true);
        }
        else if (scene == 17 && text_16 != null)
        {
            scene = 16;
            text_17.gameObject.SetActive(false);
            text_16.gameObject.SetActive(true);
        }
        else if (scene == 18 && text_17 != null)
        {
            scene = 17;
            text_18.gameObject.SetActive(false);
            text_17.gameObject.SetActive(true);
        }
    }
}
