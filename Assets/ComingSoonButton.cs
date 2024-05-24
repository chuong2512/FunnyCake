using System.Collections;
using System.Collections.Generic;
using ChuongCustom;
using UnityEngine;

public class ComingSoonButton : AButton
{
    protected override void OnClickButton()
    {
        ToastManager.Instance.ShowMessageToast("This feature is coming soon !!");
        Debug.LogError("Coming soon");
    }

    protected override void OnStart()
    {
    }
}