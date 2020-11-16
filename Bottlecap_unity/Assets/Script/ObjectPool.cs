using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public float radius;
    public float probability;
    public int poolMax;
    GameObject objectToPool;
    List<GameObject> PoolofObject;
    // Start is called before the first frame update
    void Start()
    {
        PoolofObject = new List<GameObject>();
        for(int i = 0; i < poolMax; ++i)
        {
            //needs the prefab
            GameObject g = Instantiate(objectToPool, this.transform);
            g.SetActive(false);
            PoolofObject.Add(g);
        }
    }
}