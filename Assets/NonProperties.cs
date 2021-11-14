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

        // ��v���`��
        print("��v�����`�סG" + cam.depth);

        // �Ϥ����C��
        print("�Ϥ��C��G" + spr.color);

        // ��v�����I���C��(�H���C��)
        bgc.backgroundColor = Color.black;

        // �Ϥ��W�U�A��
        if (updown)
        {
            updown.flipY = true;
        }

    }
}
