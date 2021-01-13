using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static UIController inst;

    public Transform MainCanvas;

    // Start is called before the first frame update
    void Start()
    {
        if(inst != null)
        {
            GameObject.Destroy(this.gameObject);
            return;
        }

        inst = this;
    }

   public Popup CreatePopup()
    {
        GameObject popUpGo = Instantiate(Resources.Load("UI/popup") as GameObject);
        return popUpGo.GetComponent<Popup>();
    }
}
