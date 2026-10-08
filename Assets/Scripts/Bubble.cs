using UnityEditor;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float _trapTime = 5;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy_Base enemy = collision.gameObject.GetComponent<Enemy_Base>();
        if (!enemy._trapped)
        {
            enemy.Trap(_trapTime);
            this.enabled = false;
        }
    }
}
