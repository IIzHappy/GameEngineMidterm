using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public GameObject _prefab;
    public GameObject _spawn;
    public void SpawnEnemy()
    {
        Enemy_Base enemy = Instantiate(_prefab, _spawn.transform).GetComponent<Enemy_Base>();
        EnemyManager.Instance.AddEnemy(enemy);
    }
}
