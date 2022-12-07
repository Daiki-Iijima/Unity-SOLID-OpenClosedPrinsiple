using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Good
{
    public class MissileLauncher : MonoBehaviour,ILauncher
    {
        [SerializeField] private Missile missilePrefab;

        [SerializeField] private float lifeTime = 2f;

        [SerializeField] private GameObject targetGo;

        /// <summary>
        /// ƒ~ƒTƒCƒ‹‚ð”­ŽË‚·‚é
        /// </summary>
        /// <param name="weapon"></param>
        public void Launch(GoodWeapon weapon) {
            Missile missile = Instantiate(missilePrefab);

            Destroy(missile.gameObject, lifeTime);

            missile.SetTarget(targetGo);
        }
    }
}
