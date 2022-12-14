using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 弾丸
/// 指定した方向に動かす
/// </summary>
public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private bool isLaunch = false;
    private Vector3 direction;

    /// <summary>
    /// 経過時間
    /// </summary>
    private float elapsedTime = 0;

    public void Launch(Vector3 direction) {
        isLaunch = true;
        this.direction = direction;
    }

    private void Update() {
        if (isLaunch) {
            this.transform.position += speed * Time.deltaTime * direction;
            elapsedTime += Time.deltaTime;
        }
    }
}
