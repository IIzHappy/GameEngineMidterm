using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance;
    List<Enemy_Base> _liveEnemies = new List<Enemy_Base>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (Instance == null)
        {

        }
        //spawn
    }

    // Update is called once per frame
    void Update()
    {
        
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
