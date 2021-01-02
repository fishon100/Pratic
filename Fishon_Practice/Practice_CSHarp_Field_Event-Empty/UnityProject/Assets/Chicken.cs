using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("移動速度"), Range(1f, 100f)]
    public float speed;

    [Header("跳躍高度"), Range(1, 1000)]
    public int jump;

    [Header("對話內容")]
    public string talk;

    [Header("是否取得雞蛋")]
    public bool isegg;

    public void Start()
    {
        //使用欄位名稱
        //取得
        print("對話:" + talk);

    }







}
