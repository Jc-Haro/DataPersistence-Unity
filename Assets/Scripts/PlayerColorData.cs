using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class PlayerColorData : MonoBehaviour
{

    public static PlayerColorData Instance {  get; private set; }
    public Color currentColor {  get; private set; }    

    string savePath;

    private void Awake()
    {
        if(Instance == null)
        { 
            Instance = this;
            DontDestroyOnLoad(gameObject);
            savePath = Application.persistentDataPath + "/color.json";
            Load();
        }
        else
        {
            Destroy(this);
        }
    }

    public void ChangeColor(Color color)
    {
        currentColor = color;
        Save();
    }


    void Load()
    {
        if (File.Exists(savePath))
        {
            string json  = File.ReadAllText(savePath);
            currentColor = JsonUtility.FromJson<Color>(json);
        }
        else
        {
            currentColor = Color.red;
        }
    }

    void Save()
    {
        string json = JsonUtility.ToJson(currentColor);
        File.WriteAllText(savePath, json);
    }
}
