using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyInteraction : MonoBehaviour
{
    public GameObject managerRef;
    public GameObject fakeHand;

    public GameObject[] keys;
    public GameObject[] files;

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

            Destroy(keys[6]);
            Destroy(keys[5]);
            Destroy(keys[4]);
            Destroy(keys[3]);
            Destroy(keys[2]);
            Destroy(keys[1]);
            Destroy(keys[0]);

            files[0].SetActive(true);
            files[1].SetActive(true);
            files[2].SetActive(true);
            files[3].SetActive(true);

            Destroy(this.gameObject);
        }
    }
}