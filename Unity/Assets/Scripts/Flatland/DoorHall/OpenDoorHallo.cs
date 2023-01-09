using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorHallo : MonoBehaviour
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

    void Update()
    {
        isClosing = closingDoorScript.GetComponent<CloseDoorHall>().doorClosing; // Check if door is curently closing.
    }

    private void OnTriggerEnter(Collider other) // Open door to room. 
    {
        if (enterNum < 1) // Avoid command twice do to sesitivity.
        {
            openDoorColider.SetActive(false); // Avoid trigering open door on other side.
            closingDoorScript.GetComponent<CloseDoorHall>().exitNum = 0; // Enable door to close.
            closingDoorScript.GetComponent<CloseDoorHall>().doorClosing = false; // Now door is opening.
            StartCoroutine(OpenDoor());
            Debug.Log(" || " + doorIn.transform.localEulerAngles.y);
        }
        enterNum++;
    }

    IEnumerator OpenDoor()
    {
        while(!isClosing && ((doorIn.transform.localEulerAngles.y < 360 && doorIn.transform.localEulerAngles.y > 200) || (doorIn.transform.localEulerAngles.y >= 0 && doorIn.transform.localEulerAngles.y < 1.5)))
        {
            doorIn.transform.Rotate(Vector3.up, Time.deltaTime * -speed);
            yield return null;
        }
    }
}
