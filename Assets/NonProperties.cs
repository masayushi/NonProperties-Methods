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

        // ��v���`��
        print("��v�����`�סG" + cam.depth);

        // �Ϥ����C��
        print("�Ϥ��C��G" + spr.color);

        // ��v�����I���C��(�H���C��)
        bgc.backgroundColor = Color.black;

        // �Ϥ����W�U½��
        // if (Input.GetKeyDown(KeyCode.DownArrow))
        //    {
        //     fli = false;
        //    }
    }
}
