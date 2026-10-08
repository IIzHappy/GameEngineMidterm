using UnityEngine;

public class Enemy_Base : MonoBehaviour
{
    public bool _trapped;
    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    void Move()
    {

    }

    public void Trap(float trapTime)
    {
        _trapped = true;
        //timer
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            if (_trapped)
            {
                
                //destroy
            }
            else
            {
                Debug.Log(collision.gameObject.name + " took damage");
            }
        }
    }
}
