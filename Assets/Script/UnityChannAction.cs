using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChannAction : MonoBehaviour
{
    Animator animator;
    public CapsuleCollider capsuleCollider;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //���N���b�N�ōU���̃A�j���[�V�������o��
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("Attack", true);
        }
    }

    //�A�j���[�V�����C�x���g
    //�A�j���[�V�����̊J�n�Ɠ�����Collider���o��
    void Attack1Start()
    {
        capsuleCollider.enabled = true;
    }

    //�A�j���[�V�����C�x���g
    //�A�j���[�V�����̏I���Ɠ�����Collider������
    //�A�j���[�V�������U������ҋ@�֖߂�
    void Attack1End()
    {
        capsuleCollider.enabled = false;
        animator.SetBool("Attack", false);
    }
}
