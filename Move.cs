using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 begin, end;
    public float movingTime;
    public bool isPingpong;
    public bool easeIn,easeOut,easeInOut;

    private float timeCounter;

    void Start()
    {
        timeCounter = 0f;
    }

    void Update()
    {
        move(this.gameObject,begin,end,movingTime,isPingpong);
    }

    void move(GameObject myGameObject, Vector3 begin, Vector3 end, float time, bool pingpong) 
    {
        if (timeCounter >= 2 * time)
            timeCounter = 0;    //  完成一轮运动后重新计时
        else if(timeCounter>=time)
            if (pingpong)       // 如果在反向弹回过程中，则交换begin与end
            {
                Vector3 temp = begin;
                begin = end;end = temp;
            }
            else
                return;         // 如果不弹回，则停止

        float t = (timeCounter % time) / time;
        if (easeIn)                     //easeIn 效果的参数实现   
            t = t * t;
        else if(easeOut)                //easeOut 效果的参数实现   
            t = 1 - (1 - t) * (1 - t);
        else if(easeInOut)              //easeInOut 效果的参数实现
        {
            t = (t - 1) * (t - 1) * (t - 1) + 1;
            t *= t;
        }
        myGameObject.transform.position = Vector3.Lerp(begin, end, t);
        
        timeCounter += Time.deltaTime;  //更新计时
    }

}
