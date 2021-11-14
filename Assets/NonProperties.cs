using System.ComponentModel;
using TMPro;
using UnityEngine;

public class NonProperties : MonoBehaviour
{
    public Camera cam;

    public SpriteRenderer spr;

    public Camera bgc;

    public SpriteRenderer updown;

    private void Start()
    {
        updown = GetComponent<SpriteRenderer>();

        // 攝影機深度
        print("攝影機的深度：" + cam.depth);

        // 圖片的顏色
        print("圖片顏色：" + spr.color);

        // 攝影機的背景顏色(隨機顏色)
        bgc.backgroundColor = Color.black;

        // 圖片上下顛倒
        if (updown)
        {
            updown.flipY = true;
        }

    }
}
