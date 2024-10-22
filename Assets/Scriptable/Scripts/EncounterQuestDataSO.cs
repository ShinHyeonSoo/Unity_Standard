using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EncounterQuestSO", menuName = "Unity_Standard/Quests/Encounter", order = 2)]

public class EncounterQuestDataSO : QuestDataSO
{
    [Header("Encounter Quest Data")]
    public string QuestTarget;
    public bool InteractionNPC;
}
