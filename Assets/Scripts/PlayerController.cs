using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�ٶȣ�ÿ���ƶ�5����λ����
    public float moveSpeed = 100;
    //���ٶȣ�ÿ����ת135��
    public float angularSpeed = 5000;

    void FixedUpdate()
    {
        Move();
    }
    // Update is called once per frame
    void Move()
    {
        //��ȡ��ֱ��ˮƽ���ֵ����Χ��-1��1
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * 3;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * 3;

        //����ʸ���ƶ�һ�ξ���
        transform.Translate(Vector3.forward * v * Time.deltaTime * moveSpeed);
        //����ʸ������һ����ת
        //�⽫�ı�transform�������ת�ֶε�yֵ��yֵ������yΪ��ת�ᣬ��z���������ת�ĽǶ�
        transform.Rotate(Vector3.up * h * Time.deltaTime * angularSpeed);
    }
}
