using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HD.Pooling;

public class TestPool : MonoBehaviour
{
    public int capacity;
    public IPool<GameObject> Pool { get; private set; }
    public GameObject Prototype;
    public enum PoolType { Queue, List };
    public PoolType Pooltype = PoolType.Queue;
    public bool Expandable = true;

    void Awake()
    {
        switch (Pooltype)
        {
            case PoolType.Queue:
                Pool = new QueuePool<GameObject>(() => Instantiate(Prototype), capacity);
                Debug.Log(Pool);
                break;
            case PoolType.List:
                Pool = new ListPool<GameObject>(() => Instantiate(Prototype), capacity, g => g.activeInHierarchy, Expandable);
                Debug.Log(Pool);
                break;
            default:
                break;
        }
    }
}
