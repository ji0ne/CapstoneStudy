using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int count =0;
    bool isSuccess;

    //카운트가 -5에서 5 사이일 때 성공판정

    //3. A or d를 뗀 시점에0과 5 차이면 성공 더 차이나면 실패_슬롯머신
    //뗀 시점에 함수 호출
    //키코드에서 뗀 시점에 if_-5에서 5 사이면 성공


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
            if(isSuccess==true) //문제_ 뭘 해도 true로 리턴되고 있음 >> 조건문이 안먹히고있다
            {
                Debug.Log(count + "성공!!!!");
            }
            if(isSuccess==false)
            {
                Debug.Log(count + "실패 !!!!!1");
            }
            
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            if (isSuccess == true) 
            {
                Debug.Log(count + "성공!!!!");
            }
            if (isSuccess == false)
            {
                Debug.Log(count + "실패 !!!!!1");
            }

        }



    }
 

}
