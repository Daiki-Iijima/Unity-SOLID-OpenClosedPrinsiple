using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private bool isLaunch = false;

    private GameObject target;

    /// <summary>
    /// �o�ߎ���
    /// </summary>
    private float elapsedTime = 0;

    public void SetTarget(GameObject target) {
        this.target = target;
        isLaunch = true;
    }

    private void Update() {
        if (isLaunch) {
            //  �p�x��ΏۂɌ�����
            this.transform.LookAt(target.transform, Vector3.up);

            //  �ʒu�X�V
            this.transform.position += this.transform.forward * Time.deltaTime * speed;

            //  �o�ߎ��ԉ��Z
            elapsedTime += Time.deltaTime;
        }
    }

}
