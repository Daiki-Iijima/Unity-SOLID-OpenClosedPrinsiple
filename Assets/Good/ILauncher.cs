using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Good
{
    /// <summary>
    /// ���˃C���^�[�t�F�C�X
    /// internal : �A�Z���u������̂݃A�N�Z�X�\(public)
    /// </summary>
    internal interface ILauncher
    {
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="weapon"></param>
        void Launch(GoodWeapon weapon);
    }
}
