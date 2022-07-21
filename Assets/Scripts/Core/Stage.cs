using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
namespace Sagasi.Core
{
    public class Stage : MonoBehaviour
    {
        /// <summary></summary>
        [SerializeField]
        private Image TargetImage;

        /// <summary></summary>
        public Sprite TargetImageSprite => TargetImage.sprite;

        /// <summary></summary>
        public int TimeOverSec;
        
        /// <summary></summary>
        public StageResult Result { get; private set; }

        /// <summary></summary>
        public int RemainTime { get; private set; }

        /// <summary>
        /// 各種初期化 
        /// </summary>
        private void Awake()
        {
            RemainTime = TimeOverSec;
            Result = StageResult.Playing;
            StartCoroutine(Timer());
        }

        /// <summary>
        /// ステージタイマー
        /// </summary>
        /// <returns>コルーチン列挙子</returns>
        private IEnumerator Timer()
        {
            while (RemainTime >= 0)
            {
                yield return new WaitForSeconds(1f);

                RemainTime--;

                if (RemainTime <= 0)
                {
                    Result = StageResult.TimeOver;
                }
            }
        }

        /// <summary>
        /// 目標をクリックした時のコールバック
        /// </summary>
        public void OnTargetClick()
        {
            Result = StageResult.Clear;
            // ターゲットイメージの下にあたりエフェクトを出す
        }

        /// <summary>
        /// 背景をクリックした時のコールバック
        /// </summary>
        public void OnBackgroundClick()
        {
            
            Debug.Log($"wrong {Input.mousePosition}");
            // マウス座標にクリックミスエフェクトを出す
        }
    }
}
