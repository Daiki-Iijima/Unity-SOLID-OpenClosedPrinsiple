using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Good
{
    /// <summary>
    /// IWeaponを実装しているクラスを発射できるようにしている
    /// </summary>
    public class GoodWeapon : MonoBehaviour
    {
        /// <summary>
        /// 発射する武器
        /// InterfaceはInspectorから渡せないので、Awakeで拾ってくる必要がある
        /// </summary>
        private ILauncher launcher;

        /// <summary>
        /// 発射間隔
        /// </summary>
        [SerializeField] private float fireRefreshRate = 1f;

        /// <summary>
        /// 次の発射可能までの時間
        /// </summary>
        private float nextFireTime;

        private void Awake() {
            launcher = GetComponent<ILauncher>();
            if(launcher == null) {
                Debug.LogError("ILauncherを実装したクラスを取得できませんでした。");
            }
        }

        void Start() {

        }

        void Update() {
            //  発射できるか確認
            if (CanFire()) {
                if (Input.GetButtonDown("Fire1")) {
                    FireWeapon();
                }
            }
        }

        private bool CanFire() {
            return Time.time >= nextFireTime;
        }

        //  武器の発射
        private void FireWeapon() {
            //  次の発射時間可能時間を算出
            nextFireTime = Time.time + fireRefreshRate;

            launcher.Launch(this);
        }
    }
}
