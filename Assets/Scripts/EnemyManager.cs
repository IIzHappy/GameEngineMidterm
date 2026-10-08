using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance;
    List<Enemy_Base> _liveEnemies = new List<Enemy_Base>();
    public Dictionary<EnemyFactory, int> _enemySpawns = new Dictionary<EnemyFactory, int>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(this);
        }
        
        //spawns enemies
        foreach(KeyValuePair<EnemyFactory, int> factory in _enemySpawns)
        {
            for (int i = 0; i < factory.Value; i++)
            {
                factory.Key.SpawnEnemy();
            }
        }
    }

    public void AddEnemy(Enemy_Base enemy)
    {
        _liveEnemies.Add(enemy);
    }

    public void EnemyDeath(Enemy_Base enemy)
    {
        _liveEnemies.Remove(enemy);
        if (_liveEnemies.Count >= 0) EndGame();
    }

    void EndGame()
    {
        Debug.Log("Victory");
    }
}
