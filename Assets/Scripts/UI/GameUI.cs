using Sagasi.Core;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
namespace Sagasi
{
    public class GameUI : MonoBehaviour
    {
        [SerializeField]
        private StageManager StageManager;

        [SerializeField]
        private TMP_Text Timer;

        [SerializeField]
        private Image Hint;

        private void Awake()
        {
            Hint.sprite = StageManager.CurrentStage.TargetImageSprite;
            Hint.SetNativeSize();
        }

        private void Update()
        {
            Timer.text = StageManager.CurrentStage.RemainTime.ToString();
        }
    }
}
