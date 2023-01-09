using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTrigger : MonoBehaviour
{
    public GameObject wall;
    private bool wallOff = true;

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
        if(wallOff)
        {
            wallOff = false;
            Debug.Log("triggered");
            wall.SetActive(true);
        }
        
    }
}
