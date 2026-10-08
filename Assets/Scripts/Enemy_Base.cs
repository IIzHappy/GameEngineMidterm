using System.Collections;
using UnityEngine;

public class Enemy_Base : MonoBehaviour
{
    public bool _trapped;
    float _timer;
    float _trapTime;
    void Start()
    {
        
    }

    void Update()
    {
        if (_trapped) Timer();
        else Move();
    }

    void Move()
    {

    }

    public void Trap(float trapTime)
    {
        _trapped = true;
        _trapTime = trapTime;
        _timer = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            if (_trapped)
            {
                EnemyManager.Instance.EnemyDeath(this);
                Destroy(gameObject);
            }
            else
            {
                Debug.Log(collision.gameObject.name + " took damage");
            }
        }
    }

    void Timer()
    {
        _timer += Time.deltaTime;
        if (_timer >= _trapTime) _trapped = false;
    }
}
