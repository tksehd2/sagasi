using System.Collections.Generic;
using UnityEngine;
namespace Sagasi.Core
{
    /// <summary>
    /// ステージ管理をするマネージャ
    /// </summary>
    public class StageManager : MonoBehaviour
    {
        [SerializeField] private List<Stage> Stages;
        
        public Stage CurrentStage;

        private int _currentIdx;
        private List<Stage> _sortedStages;

        //　ステージの選択はランダムIndex、全ステージプレイ後再抽選
        
        private Stage LoadStage()
        {
            return null;
        }

        private void MakeStageIndex()
        {
        }
    }
}
