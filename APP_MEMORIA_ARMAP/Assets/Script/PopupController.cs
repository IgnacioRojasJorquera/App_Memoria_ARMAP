using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupController : MonoBehaviour
{
    public GameObject record;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Record()
    {
        record.SetActive(true);
    }

    public void closeRecord()
    {
        record.SetActive(false);

    }
}
