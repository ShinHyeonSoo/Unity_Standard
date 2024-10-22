using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterQuestSO", menuName = "Unity_Standard/Quests/Monster", order = 1)]
public class MonsterQuestDataSO : QuestDataSO
{
    [Header("Monster Quest Data")]
    public string QuestTarget;
    public string QuestCounters;
    public int QuestRequiredQuantity;
}
