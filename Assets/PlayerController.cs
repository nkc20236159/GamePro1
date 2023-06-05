using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�A�j���[�^�[�R���|�[�l���g��ۑ�����ϐ�
    Animator anim;

    void Start()
    {
        Application.targetFrameRate = 60;

        //�A�j���[�^�[�R���|�[�l���g��anim�ϐ��ɕۑ�
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(0, -0.2f, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0, 0.2f, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-0.2f, 0, 0);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0.2f, 0, 0);
        }
        float y = Input.GetAxisRaw("Vertical");

        if (y == 0)
        {
            anim.Play("Player");
        }
        else if (y == 1)
        {
            anim.Play("PlayerL");
        }
        else
        {
            anim.Play("PlayerR");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();;
        }
    }
}
