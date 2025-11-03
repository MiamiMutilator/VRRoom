using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handEnable : MonoBehaviour
{
    public GameObject leftHand;
    public bool unlocked = false;

    // Start is called before the first frame update
    void Start()
    {
        leftHand.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (unlocked == true)
        {
            leftHand.SetActive(true);
        }
    }


}
