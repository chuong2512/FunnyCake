using System.Collections;
using System.Collections.Generic;
using _Game.Assets;
using ChuongCustom;
using DG.Tweening;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum State
{
    Running,
    Stop,
    Jumping
}

public class GameUI : Singleton<GameUI>
{
    public State currentState;

    // Start is called before the first frame update
    void Start()
    {
        SetState(State.Stop);
    }

    [Button]
    public void ShowLose()
    {
        Manager.InGame.Lose();
        MasterAudioManager.Play2DSfx(AudioConst.Lose);
    }

    public float countTime;
    public float timeee = 1;

    public void Update()
    {
        if (currentState == State.Running)
        {
            countTime -= Time.deltaTime;

            if (countTime <= 0)
            {
                ScoreManager.Score++;

                countTime = timeee;
            }
        }

        if (Input.GetMouseButtonDown(0) && currentState == State.Stop && !PointerIsOverUI(Input.mousePosition))
        {
            Tap.Instance?.Hide();
            Player.Instance.Jump();
            SetState(State.Running);
        }
    }

    public static bool PointerIsOverUI(Vector2 screenPos)
    {
        var hitObject = UIRaycast(ScreenPosToPointerData(screenPos));
        return hitObject != null && hitObject.layer == LayerMask.NameToLayer("UI");
    }

    static GameObject UIRaycast(PointerEventData pointerData)
    {
        var results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerData, results);

        return results.Count < 1 ? null : results[0].gameObject;
    }

    static PointerEventData ScreenPosToPointerData(Vector2 screenPos)
        => new(EventSystem.current) {position = screenPos};


    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }


    [Button]
    public void Jump()
    {
        Player.Instance.Jump();
    }

    private float duration = 1f;


    public void EndJump()
    {
    }

    public void SetState(State state)
    {
        currentState = state;
    }
}