using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    private static QuestManager _instance;

    [SerializeField] private QuestDataSO[] _quests;

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
            GameObject obj = new GameObject(nameof(QuestManager));
            //obj.name = typeof(QuestManager).Name;
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

    public void PrintQuests()
    {
        for(int i = 0; i < _quests.Length; i++)
        {
            string qusetStr = "";
            QuestDataSO questData = _quests[i];
            qusetStr = $"Quest {i + 1} - {questData.QuestName} (최소 레벨 {questData.QuestRequiredLevel})";
            Debug.Log(qusetStr);
            CheckQuestType(questData);
        }
    }

    private void CheckQuestType(QuestDataSO dataSO)
    {
        string questStr = "";

        if (dataSO as MonsterQuestDataSO)
        {
            MonsterQuestDataSO qusetSO = dataSO as MonsterQuestDataSO;
            questStr = $"{qusetSO.QuestTarget}를 {qusetSO.QuestRequiredQuantity}{qusetSO.QuestCounters} 소탕";
        }
        else if (dataSO as EncounterQuestDataSO)
        {
            EncounterQuestDataSO qusetSO = dataSO as EncounterQuestDataSO;
            questStr = $"{qusetSO.QuestTarget}과 대화하기";
        }

        Debug.Log(questStr);
    }
}
