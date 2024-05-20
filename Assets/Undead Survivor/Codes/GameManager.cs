using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public PoolManger pool;
    public Player player;

    void Awake()
    {
        instance = this;        
    }
}
