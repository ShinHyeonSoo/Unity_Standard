using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager _instance;

    public static QuestManager Instance 
    { 
        get 
        {
            if (_instance == null)
            {
                Init();
            }
            return _instance; 
        } 
    }

    private static void Init()
    {
        QuestManager instance = FindObjectOfType<QuestManager>();

        if(instance == null)
        {
            GameObject obj = new GameObject();
            obj.name = typeof(QuestManager).Name;
            obj.AddComponent<QuestManager>();
            DontDestroyOnLoad(obj);
        }
    }

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
