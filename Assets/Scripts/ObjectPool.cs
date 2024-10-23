using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [Serializable]
    public class Pool
    {
        public string name;
        public GameObject prefab;
        public int poolSize = 300;
    }

    public List<Pool> Pools;
    private Dictionary<string, List<GameObject>> _poolDic = new Dictionary<string, List<GameObject>>();

    void Awake()
    {
        // 미리 poolSize만큼 게임오브젝트를 생성한다.
        foreach (var pool in Pools)
        {
            List<GameObject> poolList = new List<GameObject>();

            for (int i = 0; i < pool.poolSize; ++i)
            {
                GameObject obj = Instantiate(pool.prefab, transform);
                obj.SetActive(false);
                poolList.Add(obj);
            }
            _poolDic.Add(pool.name, poolList);
        }
    }

    public GameObject Get(string key)
    {
        if (!_poolDic.ContainsKey(key))
            return null;

        // 꺼져있는 게임오브젝트를 찾아 active한 상태로 변경하고 return 한다.
        var poolList = _poolDic[key];

        foreach(var obj in poolList)
        {
            if(!obj.activeSelf)
            {
                obj.SetActive(true);
                return obj;
            }
        }

        return null;
    }

    public void Release(GameObject obj)
    {
        // 게임오브젝트를 deactive한다.
        obj.SetActive(false);
    }
}
