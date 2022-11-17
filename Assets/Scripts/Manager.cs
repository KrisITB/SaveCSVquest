using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Data dataToSave = new Data();
        Save.SaveFile(dataToSave);
        //string fileName = "data.csv";
        //string saveLocation = Path.Combine(Application.persistentDataPath, fileName);
        //Debug.Log("saved at = " + saveLocation);
    }

}
