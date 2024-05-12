using ChuongCustom;
using UnityEngine;

namespace _Game.Assets
{
    public class Tap : Singleton<Tap>
    {
        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}