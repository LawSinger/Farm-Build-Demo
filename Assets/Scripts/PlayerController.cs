using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //速度：每秒移动5个单位长度
    public float moveSpeed = 100;
    //角速度：每秒旋转135度
    public float angularSpeed = 5000;

    void FixedUpdate()
    {
        Move();
    }
    // Update is called once per frame
    void Move()
    {
        //获取竖直、水平轴的值，范围在-1到1
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * 3;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * 3;

        //按照矢量移动一段距离
        transform.Translate(Vector3.forward * v * Time.deltaTime * moveSpeed);
        //按照矢量进行一次旋转
        //这将改变transform组件中旋转字段的y值，y值控制以y为旋转轴，从z轴出发的旋转的角度
        transform.Rotate(Vector3.up * h * Time.deltaTime * angularSpeed);
    }
}
