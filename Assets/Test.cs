using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.IsolatedStorage;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Test : MonoBehaviour
{
    void Start()
    {
        //�v�f��5�̔z�������������
        int[] array = { 5, 10, 15, 20, 25 };

        //�z��̊e�v�f�̒l�����Ԃɕ\������
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //�z��̊e�v�f�̒l���t���ɕ\������
        for (int i = array.Length - 1; 0 <= i; i--) 
        {
            Debug.Log(array[i]);
        }

        //Boss�N���X�̕ϐ���錾���ăC���X�^���X��������
        Boss boss = new Boss();

        //Magic�֐���11��g��
        for (int i = 0; i < 11; i++)
        {
            boss.Magic();
        }

    }

    //Update is called once per frame
    private void Update()
    {
        
    }
}
public class Boss
{
    //mp��53�ŏ���������
    private int mp = 53;

    //���@�U���p�̊֐�
    public void Magic()
    {
        if (mp >= 5)
        {
            //mp��5�ȏ�̏ꍇ�́A5���炵�A"���@�U���������B�c��MP�́����B"�ƕ\������
            mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");
        }
        else
        {
            //����ȊO�̏ꍇ�imp��5�����̏ꍇ�j�́A"MP������Ȃ����߁A���@���g���Ȃ��B"�ƕ\������
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}