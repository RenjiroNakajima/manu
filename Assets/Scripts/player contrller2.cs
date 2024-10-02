using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrller2 : MonoBehaviour
{
    float moveSpeed = 5f;
    float rotateSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //垂直方向と水平方向の入力を取得し、それぞれの移動速度をかける。
        float Xvalue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float Yvalue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        //現在のX,Zベクトルに上の処理で取得した値を渡す。
        Vector3 movedir = new Vector3(Xvalue, 0, Yvalue);

        //現在地に上で取得をした値を足して移動する。
        transform.position += movedir;
    }
}