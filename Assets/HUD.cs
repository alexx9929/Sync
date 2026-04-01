using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DisplayCorner { TopLeft, TopRight, BottomLeft, BottomRight }


public class HUD : MonoBehaviour
{
    public DisplayCorner displayCorner = DisplayCorner.TopLeft;
    private float deltaTime = 0.0f;
    private GUIStyle style;
    private Rect position;
    public int TargetFPS = -1;
    public bool Cap;

    private void Start()
    { 
        //QualitySettings.vSyncCount = 1;
        //TargetFPS = 80;
        //if (Cap)
        {
            SetFrameRateLimit(TargetFPS);
        }

        int width = 200;
        int height = 30;
        int padding = 10;

        position = new Rect(padding, padding, width, height);

        switch (displayCorner)
        {
            case DisplayCorner.TopLeft:
                position.y = padding;
                break;
            case DisplayCorner.TopRight:
                position.x = Screen.width - width - padding;
                position.y = padding;
                break;
            case DisplayCorner.BottomLeft:
                position.y = Screen.height - height - padding;
                break;
            case DisplayCorner.BottomRight:
                position.x = Screen.width - width - padding;
                position.y = Screen.height - height - padding;
                break;
        }

        style = new GUIStyle();
        style.alignment = TextAnchor.MiddleCenter;
        style.fontSize = 24;
        style.normal.textColor = Color.green;
    }
    private void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
    }

    private void OnGUI()
    {
        float fps = 1.0f / deltaTime;
        string text = string.Format("{0:0.} FPS", fps);
        GUI.Label(position, text, style);
    }

    public void SetFrameRateLimit(int targetFPS)
    {
        Application.targetFrameRate = targetFPS;
    }
}
