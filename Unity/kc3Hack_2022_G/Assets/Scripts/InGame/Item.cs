using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// �A�C�e���̓����p�X�N���v�g
public class Item : MonoBehaviour
{

    Rigidbody2D rb; // Rigidbody2D�R���|�[�l���g���X�N���v�g�ő��삷��ׂ̕ϐ�
    bool moved;     // �u���ɑ��삳�ꂽ���ǂ����v
    int itemScore;  // �i�e��A�C�e�������A�ŗL�̃X�R�A�@�̗\��j


    // �ŏ��Ɏ��s�����
    private void Start()
    {
        // ���̃X�N���v�g���A�^�b�`����Ă���GameObject�́ARigidbody2D�R���|�[�l���g��������
        rb = GetComponent<Rigidbody2D>();

        // Rigidbody2D �� bodyType �� Kinematic �ɕύX����
        rb.bodyType = RigidbodyType2D.Kinematic;

        // �u�ŏ��͂܂����삳��Ă��Ȃ��v
        moved = false;
    }


    // �}�E�X�i�������͎w�j�Ńh���b�O����Ă���ԁA���t���[������
    void OnMouseDrag()
    {
        // ��������ς݂łȂ��Ȃ��
        if (moved == false)
        {
            // ��ʏ�̃}�E�X�̍��W�����o��
            Vector2 pointScreen = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

            // �}�E�X�̍��W���A�Q�[�����̍��W�ɕϊ�����
            Vector2 pointWorld = Camera.main.ScreenToWorldPoint(pointScreen);

            // �ϊ��������W�̈ʒu�ɁA�A�C�e���𓮂���
            this.transform.position = pointWorld;
        }
    }


    // �����h���b�O����I�������
    private void OnMouseUp()
    {
        // ��������ς݂łȂ��Ȃ��
        if (moved == false)
        {
            // Rigidbody2D �� bodyType �� Dynamic �ɕύX����
            rb.bodyType = RigidbodyType2D.Dynamic;

            // �u����ς݁v
            moved = true;
        }
    }

}
