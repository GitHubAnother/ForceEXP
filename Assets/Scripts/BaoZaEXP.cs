/*
作者名称:YHB

脚本作用:爆炸

建立时间:
*/

using UnityEngine;
using System.Collections;

public class BaoZaEXP : MonoBehaviour
{
    public float radious;

    public float force;
    public float uoward;
    public ForceMode forceMode;

    void FixedUpdate()
    {
        //得到当前物体为中心，radious为半径的球的范围内所有物体的Collider，进行遍历
        foreach (Collider c in Physics.OverlapSphere(this.transform.position, radious))
        {
            if (c.GetComponent<Rigidbody>() != null)
            {
                //给那些Collider物体添加爆炸的力
                c.GetComponent<Rigidbody>().AddExplosionForce(force, this.transform.position, radious, uoward, forceMode);
            }
        }
    }
}
