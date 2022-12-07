using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Good
{
    /// <summary>
    /// ’e‚ğ¶¬A”­ËAÁ‹‚·‚é(ŠÇ—)
    /// </summary>
    public class BulletLauncher : MonoBehaviour, ILauncher
    {
        [SerializeField] private Bullet bulletPrefab;

        [SerializeField] private float lifeTime = 2f;

        /// <summary>
        /// ’eŠÛ‚ğ”­Ë‚·‚é
        /// </summary>
        /// <param name="weapon"></param>
        public void Launch(GoodWeapon weapon) {
            Bullet bullet = Instantiate(bulletPrefab);

            Destroy(bullet.gameObject, lifeTime);

            //  ’eŠÛ©‘Ì‚Ì§Œä‚ÍA‚±‚±‚Å‚Í‚â‚ç‚È‚¢(’PˆêÓ”CŒ´‘¥)
            bullet.Launch(weapon.transform.forward);
        }
    }
}
