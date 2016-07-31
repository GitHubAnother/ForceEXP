/*
作者名称:YHB

脚本作用:球运动

建立时间:2016.7.31.15.15
*/

using UnityEngine;
using System.Collections;

public class Sphere : MonoBehaviour
{
    public float speed;

    void Update()
    {
        this.transform.position += transform.forward * Time.deltaTime * speed;
    }
}
