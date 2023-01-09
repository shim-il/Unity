using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorI : MonoBehaviour
{
    private int speed = 100;

    public int enterNum = 0;
    public bool entered = false;
    public bool isClosing;
    public GameObject doorIn;
    public GameObject closingDoorScript;
    public GameObject openDoorColider;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isClosing =  closingDoorScript.GetComponent<CloseDoor>().doorClosing;
    }

    private void OnTriggerEnter(Collider other)          
    {
        if (enterNum < 1)
        {
            openDoorColider.SetActive(false);
            closingDoorScript.GetComponent<CloseDoor>().exitNum = 0;
            closingDoorScript.GetComponent<CloseDoor>().doorClosing = false;
            StartCoroutine(OpenDoor());
            Debug.Log(" || " + doorIn.transform.localEulerAngles.y);
        }
        enterNum++;
    }

    IEnumerator OpenDoor()
    {
        while(!isClosing && ((doorIn.transform.localEulerAngles.y < 121) || (doorIn.transform.localEulerAngles.y >= 0 && doorIn.transform.localEulerAngles.y < 1.5)))
        {
            doorIn.transform.Rotate(Vector3.up, Time.deltaTime * speed);
            Debug.Log(" *** " + doorIn.transform.localEulerAngles.y);
            yield return null;
        }
    }
}
