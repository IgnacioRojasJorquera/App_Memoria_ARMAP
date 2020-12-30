using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericObject : MonoBehaviour
{
    public int money;
    private int item;

    private void Awake()
    {
        //LoadData();
    }
    // Start is called before the first frame update
    void Start()
    {
        LoadData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void onDestroy()
    {
        SaveData();
    }

    private void SaveData()
    {
        DatosentreEscenas.inst.money = money;
        DatosentreEscenas.inst.SetItems(item);
    }

    private void LoadData()
    {
        money = DatosentreEscenas.inst.money;
        //item = DatosentreEscenas.inst.GetItems();
    }
}
