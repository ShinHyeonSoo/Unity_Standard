using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultQuestSO", menuName = "Unity_Standard/Quests/Defalut", order = 0)]
public class QuestDataSO : ScriptableObject
{
    [Header("Quest Info")]
    public string QuestName;
    public int QuestRequiredLevel;
    public int QuestNPC;
    public List<int> QuestPrerequisites;
}
