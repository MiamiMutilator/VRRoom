using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barDisable : MonoBehaviour
{
    public GameObject managerRef;

    public GameObject lockedFloor;
    public GameObject unlockedFloor;

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
        if (managerRef.GetComponent<handEnable>().unlocked == true)
        {
            if (collision.gameObject.CompareTag("Key Item"))
            {
                lockedFloor.SetActive(false);
                unlockedFloor.SetActive(true);
                Destroy(this.gameObject);
                Destroy(files[0]);
                Destroy(files[1]);
                Destroy(files[2]);
            }
        }
    }
}
