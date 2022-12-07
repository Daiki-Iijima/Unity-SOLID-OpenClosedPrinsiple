using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Good
{
    /// <summary>
    /// �e�𐶐��A���ˁA��������(�Ǘ�)
    /// </summary>
    public class BulletLauncher : MonoBehaviour, ILauncher
    {
        [SerializeField] private Bullet bulletPrefab;

        [SerializeField] private float lifeTime = 2f;

        /// <summary>
        /// �e�ۂ𔭎˂���
        /// </summary>
        /// <param name="weapon"></param>
        public void Launch(GoodWeapon weapon) {
            Bullet bullet = Instantiate(bulletPrefab);

            Destroy(bullet.gameObject, lifeTime);

            //  �e�ێ��̂̐���́A�����ł͂��Ȃ�(�P��ӔC����)
            bullet.Launch(weapon.transform.forward);
        }
    }
}
