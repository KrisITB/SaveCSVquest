using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data
{
    [SerializeField] public string ID;

    public Data()
    {
        ID = "1,2,3";
    }
}
