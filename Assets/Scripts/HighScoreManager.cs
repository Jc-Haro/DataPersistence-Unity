using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class HighScoreManager : MonoBehaviour
{
    public static HighScoreManager Instance { get; private set; }
    public Score HighScore {  get; private set; }
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            Load();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Load()
    {
        string filePath = Application.persistentDataPath + "/score.json";
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            HighScore = JsonUtility.FromJson<Score>(json);
        }
        else
        {
            HighScore = new Score(0, string.Empty);
        }
    }

    void Save()
    {
        string filePath = Application.persistentDataPath + "/score.json";
        string json = JsonUtility.ToJson(HighScore);
        File.WriteAllText(filePath, json);
    }

    public void RegistryScore(Score score)
    {
        if (score.score > HighScore.score)
        {
            HighScore = score;
            Save();
        }
    }
}
