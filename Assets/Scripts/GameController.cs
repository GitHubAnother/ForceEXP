/*
作者名称:YHB

脚本作用:发射

建立时间:
*/

using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    #region 字段
    public GameObject sp;
    #endregion

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(sp, this.transform.position, this.transform.rotation);
        }
    }
}
