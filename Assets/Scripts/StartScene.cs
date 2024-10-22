using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScene : MonoBehaviour
{
    [SerializeField] private ObjectPool pool;
    void Start()
    {
        QuestManager mgr = QuestManager.Instance;

        GameObject obj = pool.Get("test");

        mgr.PrintQuests();
    }
}
