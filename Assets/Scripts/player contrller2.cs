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
        //���������Ɛ��������̓��͂��擾���A���ꂼ��̈ړ����x��������B
        float Xvalue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float Yvalue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;

        //���݂�X,Z�x�N�g���ɏ�̏����Ŏ擾�����l��n���B
        Vector3 movedir = new Vector3(Xvalue, 0, Yvalue);

        //���ݒn�ɏ�Ŏ擾�������l�𑫂��Ĉړ�����B
        transform.position += movedir;
    }
}