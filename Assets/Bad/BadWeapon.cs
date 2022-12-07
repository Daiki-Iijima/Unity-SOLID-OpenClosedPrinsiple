using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 武器
/// Open : 振る舞いの追加(発射する武器の種類の追加)をこのクラスのコードを変更せずにできるか？
/// Closed : 振る舞いの変更(発射する武器の種類の追加)をしても、既存の処理に影響を与える可能性がないか？
/// 新しい武器を追加すると、FireWeaponメソッドのif文が増え(閉じていない)、追加した武器のスクリプトの定義を追加していく必要がある(開いていない)
/// </summary>
public class BadWeapon : MonoBehaviour
{
    /// <summary>
    /// 弾のプレファブ
    /// </summary>
    [SerializeField] private Bullet bulletPrefab;

    /// <summary>
    /// ミサイルのプレファブ
    /// </summary>
    [SerializeField] private Missile missilePrefab;
    /// <summary>
    /// ミサイルのターゲット
    /// </summary>
    [SerializeField] private GameObject target;

    /// <summary>
    /// 発射間隔
    /// </summary>
    [SerializeField] private float fireRefreshRate = 1f;

    [SerializeField] private float lifeTime = 2f;

    /// <summary>
    /// 次の発射可能までの時間
    /// </summary>
    private float nextFireTime;

    private void Update() {
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

        //  問題点1 : 武器の種類が増えるたびに、if文が増えていく、既存のコードを変更する必要がある
        if (bulletPrefab != null) {
            Bullet bullet = Instantiate(bulletPrefab);
            //  生存時間を設定
            Destroy(bullet.gameObject, lifeTime);
            //  発射
            bullet.Launch(transform.forward);
        } else if (missilePrefab != null) {
            Missile missile = Instantiate(missilePrefab);
            //  生存時間を設定
            Destroy(missile.gameObject, lifeTime);
            missile.SetTarget(target);
        }
    }
}
