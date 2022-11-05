using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ’eŠÛ
/// Žw’è‚µ‚½•ûŒü‚É“®‚©‚·
/// </summary>
public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float lifeTime = 2f;

    private bool isLaunch = false;
    private Vector3 direction;

    /// <summary>
    /// Œo‰ßŽžŠÔ
    /// </summary>
    private float elapsedTime = 0;

    public void Launch(Vector3 direction) {
        isLaunch = true;
        this.direction = direction;
    }

    private void Update() {

        if(elapsedTime >= lifeTime) {
            Destroy(this.gameObject);
        }

        if (isLaunch) {
            this.transform.position += speed * Time.deltaTime * direction;
            elapsedTime += Time.deltaTime;
        }
    }
}
