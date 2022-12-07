using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ����
/// Open : �U�镑���̒ǉ�(���˂��镐��̎�ނ̒ǉ�)�����̃N���X�̃R�[�h��ύX�����ɂł��邩�H
/// Closed : �U�镑���̕ύX(���˂��镐��̎�ނ̒ǉ�)�����Ă��A�����̏����ɉe����^����\�����Ȃ����H
/// �V���������ǉ�����ƁAFireWeapon���\�b�h��if��������(���Ă��Ȃ�)�A�ǉ���������̃X�N���v�g�̒�`��ǉ����Ă����K�v������(�J���Ă��Ȃ�)
/// </summary>
public class BadWeapon : MonoBehaviour
{
    /// <summary>
    /// �e�̃v���t�@�u
    /// </summary>
    [SerializeField] private Bullet bulletPrefab;

    /// <summary>
    /// �~�T�C���̃v���t�@�u
    /// </summary>
    [SerializeField] private Missile missilePrefab;
    /// <summary>
    /// �~�T�C���̃^�[�Q�b�g
    /// </summary>
    [SerializeField] private GameObject target;

    /// <summary>
    /// ���ˊԊu
    /// </summary>
    [SerializeField] private float fireRefreshRate = 1f;

    [SerializeField] private float lifeTime = 2f;

    /// <summary>
    /// ���̔��ˉ\�܂ł̎���
    /// </summary>
    private float nextFireTime;

    private void Update() {
        //  ���˂ł��邩�m�F
        if (CanFire()) {
            if (Input.GetButtonDown("Fire1")) {
                FireWeapon();
            }
        }
    }

    private bool CanFire() {
        return Time.time >= nextFireTime;
    }

    //  ����̔���
    private void FireWeapon() {
        //  ���̔��ˎ��ԉ\���Ԃ��Z�o
        nextFireTime = Time.time + fireRefreshRate;

        //  ���_1 : ����̎�ނ������邽�тɁAif���������Ă����A�����̃R�[�h��ύX����K�v������
        if (bulletPrefab != null) {
            Bullet bullet = Instantiate(bulletPrefab);
            //  �������Ԃ�ݒ�
            Destroy(bullet.gameObject, lifeTime);
            //  ����
            bullet.Launch(transform.forward);
        } else if (missilePrefab != null) {
            Missile missile = Instantiate(missilePrefab);
            //  �������Ԃ�ݒ�
            Destroy(missile.gameObject, lifeTime);
            missile.SetTarget(target);
        }
    }
}
