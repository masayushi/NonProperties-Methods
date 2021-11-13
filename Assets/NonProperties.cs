using System.ComponentModel;
using UnityEngine;

public class NonProperties : MonoBehaviour
{
    public Camera cam;

    public SpriteRenderer spr;

    public Camera bgc;

    public bool fli;

    private void Start()
    {
        fli = GetComponent<SpriteRenderer>();

        // 攝影機深度
        print("攝影機的深度：" + cam.depth);

        // 圖片的顏色
        print("圖片顏色：" + spr.color);

        // 攝影機的背景顏色(隨機顏色)
        bgc.backgroundColor = Color.black;

        // 圖片的上下翻面
        // if (Input.GetKeyDown(KeyCode.DownArrow))
        //    {
        //     fli = false;
        //    }
    }
}
