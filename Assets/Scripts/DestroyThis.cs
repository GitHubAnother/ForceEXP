/*
作者名称:YHB

脚本作用:自销毁

建立时间:2016.7.31.15.29
*/

using UnityEngine;
using System.Collections;

public class DestroyThis : MonoBehaviour
{
    public float timer;

    void Start()
    {
        Destroy(this.gameObject, timer);
    }
}
