using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Good
{
    /// <summary>
    /// 弾を生成、発射、消去する(管理)
    /// </summary>
    public class BulletLauncher : MonoBehaviour, ILauncher
    {
        [SerializeField] private Bullet bulletPrefab;

        [SerializeField] private float lifeTime = 2f;

        /// <summary>
        /// 弾丸を発射する
        /// </summary>
        /// <param name="weapon"></param>
        public void Launch(GoodWeapon weapon) {
            Bullet bullet = Instantiate(bulletPrefab);

            Destroy(bullet.gameObject, lifeTime);

            //  弾丸自体の制御は、ここではやらない(単一責任原則)
            bullet.Launch(weapon.transform.forward);
        }
    }
}
