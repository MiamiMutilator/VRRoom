using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyInteraction : MonoBehaviour
{
    public GameObject managerRef;
    public GameObject fakeHand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Key Item"))
        {
            managerRef.GetComponent<handEnable>().unlocked = true;
            Destroy(fakeHand.gameObject);
            Destroy(this.gameObject);
        }
    }
}
