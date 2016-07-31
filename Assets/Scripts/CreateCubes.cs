/*
作者名称:YHB

脚本作用:生成大量1000个cube

建立时间:2016.7.31.14.32
*/

using UnityEngine;
using System.Collections;

public class CreateCubes : MonoBehaviour
{
    #region 字段
    public GameObject cube;

    private int x = 6;
    private int y = 6;
    private int z = 6;
    #endregion

    void Start()
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                for (int k = 0; k < z; k++)
                {
                    GameObject go = Instantiate(cube, transform.position + transform.right * i + transform.up * j + transform.forward * k, Quaternion.identity) as GameObject;
                    go.transform.parent = this.transform;
                }
            }
        }

    }
}
