using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("移動速度"), Range(1, 100)]
    public float speed = 10.5f;

    public Rigidbody2D Rig;

    public SpriteRenderer Spr;

    //水平值
    [Header("移動方向"), Range(0, 1)]
    public float H;

    // Start is called before the first frame update
    void Start()
    {
        Rig = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        Move();
        GetHorizontal();

    }

    public void Move()
    {
        //Spr.flipX = true;

        Rig.velocity = new Vector2(H * speed, Rig.velocity.y);



    }

    private void GetHorizontal()
    {
        H = Input.GetAxis("Horizontal");
        if (H == 0)
        {
            Spr.flipX = false;
        }
        else { Spr.flipX = true; }
        //取得玩家操控的水平值a/d



    }

}
