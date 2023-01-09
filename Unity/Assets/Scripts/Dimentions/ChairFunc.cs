using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairFunc : MonoBehaviour
{
    public GameObject textButtonsHide;
    public GameObject textMoveChair;
    public GameObject textMoveChairLeg;
    public GameObject textMoveWall;
    public GameObject chair;
    public GameObject chairLeg;
    public GameObject wall;
    public GameObject buttons;
    public float chairSpeed = .8f;
    private float speed = 25;
    private bool wallNotPlayed = true;
    private bool chairNotPlayed = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("angle = " + wall.transform.localEulerAngles.y);   
    }

    // Update is called once per frame
    void Update()
    {
        if(textButtonsHide.gameObject.activeSelf && !wall.gameObject.activeSelf)
        {
            buttons.SetActive(false);
        }
        else
        {
            buttons.SetActive(true);
        }

        if (textMoveWall.gameObject.activeSelf && wallNotPlayed)
        {
            wallNotPlayed = false;
            StartCoroutine(TurnWall());
        }
    }

    

    IEnumerator TurnWall()
    {
        while(wall.transform.localEulerAngles.y == 0 || wall.transform.localEulerAngles.y > 270)
        {
            wall.transform.Rotate(Vector3.up * Time.deltaTime * -speed, Space.World);
            Debug.Log("open = " + wall.transform.localEulerAngles.y);
            yield return null;
        }

        Debug.Log("close = " + wall.transform.localEulerAngles.y);
        yield return new WaitForSeconds(1.5f);

        while(wall.transform.localEulerAngles.y < 300 )
        {
            wall.transform.Rotate(Vector3.up * Time.deltaTime * speed, Space.World);
            yield return null;
        }

        yield return new WaitForSeconds(1f);

         Debug.Log("------Chair!------");
        while(chair.transform.position.y < 1.4)
        {
            chair.transform.Translate(Vector3.up * Time.deltaTime * chairSpeed, Space.Self);
            yield return null;
        }
    }
}
