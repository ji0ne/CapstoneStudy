using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int count =0;
    bool isSuccess;

    //ī��Ʈ�� -5���� 5 ������ �� ��������

    //3. A or d�� �� ������0�� 5 ���̸� ���� �� ���̳��� ����_���Ըӽ�
    //�� ������ �Լ� ȣ��
    //Ű�ڵ忡�� �� ������ if_-5���� 5 ���̸� ����


    void Update()
    {
        //Debug.Log(Input.anyKey);
        if(Input.GetKey(KeyCode.A))
        {
            count++;
        }
        if(Input.GetKey(KeyCode.D))
        {
            count--;       
        }


        if (Input.GetKeyUp(KeyCode.A) && count > -11 && count < 11)
        {
            isSuccess = true;
        }
        if (Input.GetKeyUp(KeyCode.A) && count < -11 || count > 11)
        {
            isSuccess = false;
        }
        if (Input.GetKeyUp(KeyCode.D) && count > -11 && count < 11)
        {
            isSuccess = true;
        }
        if (Input.GetKeyUp(KeyCode.D) && count < -11 || count > 11) 
        {
            isSuccess = false;
        }


        if (Input.GetKeyUp(KeyCode.A))
        {
            if(isSuccess==true) //����_ �� �ص� true�� ���ϵǰ� ���� >> ���ǹ��� �ȸ������ִ�
            {
                Debug.Log(count + "����!!!!");
            }
            if(isSuccess==false)
            {
                Debug.Log(count + "���� !!!!!1");
            }
            
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            if (isSuccess == true) 
            {
                Debug.Log(count + "����!!!!");
            }
            if (isSuccess == false)
            {
                Debug.Log(count + "���� !!!!!1");
            }

        }



    }
 

}
