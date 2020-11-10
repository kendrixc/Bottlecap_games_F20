using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public float radius;
    public float probability;

    // change the type to the object
    GameObject objectToPool;
    List<GameObject> PoolofObject;

    void Start()
    {
        PoolofObject = new List<GameObject>();
        for(int i = 0; i < poolMax; ++i)
        {
            //needs the prefab
            GameObject g = Instantiate(objectToPool, this.transform);
            g.SetActive(false);
            objects.Add(g);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
