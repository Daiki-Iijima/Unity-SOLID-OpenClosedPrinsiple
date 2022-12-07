using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private bool isLaunch = false;

    private GameObject target;

    /// <summary>
    /// 経過時間
    /// </summary>
    private float elapsedTime = 0;

    public void SetTarget(GameObject target) {
        this.target = target;
        isLaunch = true;
    }

    private void Update() {
        if (isLaunch) {
            //  角度を対象に向ける
            this.transform.LookAt(target.transform, Vector3.up);

            //  位置更新
            this.transform.position += this.transform.forward * Time.deltaTime * speed;

            //  経過時間加算
            elapsedTime += Time.deltaTime;
        }
    }

}
