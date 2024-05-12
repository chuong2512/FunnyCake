using System;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace ChuongCustom
{
    public class InGameManager : Singleton<InGameManager>
    {
        [SerializeField] public int PriceToPrice = 1;

        private void Start()
        {
            ScoreManager.Reset();

            Time.timeScale = 1;
        }

        [Button]
        public void Win()
        {
            Manager.ScreenManager.OpenScreen(ScreenType.Result);
            //todo:
        }

        private void OnDestroy()
        {
            Time.timeScale = 1;
        }

        [Button]
        public void Lose()
        {
            Manager.ScreenManager.OpenScreen(ScreenType.Lose);
            //todo:
            Time.timeScale = 0;
        }

        [Button]
        public void BeforeLose()
        {
            Manager.ScreenManager.OpenScreen(ScreenType.BeforeLose);
            //todo:
        }

        public void Retry()
        {
            //retry
            //todo:
            SceneManager.LoadScene("GameScene");
        }

        public void Continue()
        {
            //continue

            //todo:
        }
    }
}