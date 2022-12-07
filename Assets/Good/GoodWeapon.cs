using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Good
{
    /// <summary>
    /// IWeapon���������Ă���N���X�𔭎˂ł���悤�ɂ��Ă���
    /// </summary>
    public class GoodWeapon : MonoBehaviour
    {
        /// <summary>
        /// ���˂��镐��
        /// Interface��Inspector����n���Ȃ��̂ŁAAwake�ŏE���Ă���K�v������
        /// </summary>
        private ILauncher launcher;

        /// <summary>
        /// ���ˊԊu
        /// </summary>
        [SerializeField] private float fireRefreshRate = 1f;

        /// <summary>
        /// ���̔��ˉ\�܂ł̎���
        /// </summary>
        private float nextFireTime;

        private void Awake() {
            launcher = GetComponent<ILauncher>();
            if(launcher == null) {
                Debug.LogError("ILauncher�����������N���X���擾�ł��܂���ł����B");
            }
        }

        void Start() {

        }

        void Update() {
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

            launcher.Launch(this);
        }
    }
}
