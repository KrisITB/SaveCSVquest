using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class Save
{
    public static void SaveFile(Data d)
    {
        string path = GetPath();
        //FileStream fs = new FileStream(path, FileMode.Create);
        //fs.Close();
        
        StreamWriter sw = new StreamWriter(path);
        sw.WriteLine(d.ID);
        //sw.WriteLine("second line");
        sw.Close();
    }

    private static string GetPath()
    {
        string fileName = "data.csv";
        return Path.Combine(Application.persistentDataPath, fileName);
    }
}
