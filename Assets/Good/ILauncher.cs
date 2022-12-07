using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Good
{
    /// <summary>
    /// 発射インターフェイス
    /// internal : アセンブリからのみアクセス可能(public)
    /// </summary>
    internal interface ILauncher
    {
        /// <summary>
        /// 発射
        /// </summary>
        /// <param name="weapon"></param>
        void Launch(GoodWeapon weapon);
    }
}
