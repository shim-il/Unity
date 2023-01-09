using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    private int speed = 100;

    public GameObject doorIn;
    public GameObject doorOut;
    public GameObject doorTrigerIn;
    public GameObject doorTrigerOut;
    public int exitNum = 0;
    public bool doorClosing = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)        
    {
        if (exitNum < 1)
        {
            doorClosing = true;
            doorTrigerIn.GetComponent<OpenDoorI>().enterNum = 0;
            doorTrigerOut.GetComponent<OpenDoor2D>().enterNum = 0;
            StartCoroutine(DoorCloseH());
            Debug.Log("Colider working" + doorIn.transform.localEulerAngles.y);
        }
        exitNum++;
    }

    IEnumerator DoorCloseH()
    {
            if(doorTrigerOut.gameObject.activeSelf)
            {
                while(doorIn.transform.localEulerAngles.y > 0.8) 
                {
                    //Debug.Log("doorOut " + doorOut.transform.localEulerAngles.y + " || " + doorIn.transform.localEulerAngles.y);
                    doorIn.transform.Rotate(Vector3.up, Time.deltaTime * speed);
                    yield return null;
                }
            }
            Debug.Log("---test---");
            
            if(doorTrigerIn.gameObject.activeSelf)
            {
                while(doorOut.transform.localEulerAngles.y > 0.8) 
                {
                    //Debug.Log("doorOut " + doorOut.transform.localEulerAngles.y + " || " + doorIn.transform.localEulerAngles.y);
                    doorOut.transform.Rotate(Vector3.up, Time.deltaTime * -speed);
                    yield return null;
                }
            }

            doorTrigerIn.SetActive(true);
            doorTrigerOut.SetActive(true);

    
        doorClosing = false;
    }
}
