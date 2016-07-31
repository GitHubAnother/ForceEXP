/*
作者名称:YHB

脚本作用:按下ESC退出游戏

建立时间:2016.7.31.16.13
*/

using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void OnGUI()
    {
        GUILayout.Label("按ESC键退出游戏！");
    }
}
