using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class CameraDepthSetting : MonoBehaviour
{
    // 深度テクスチャモード
    public DepthTextureMode DepthTextureMode;

    private Camera _camera;
    private Camera Camera { get { return _camera ?? (_camera = GetComponent<Camera>()); } }

    void Awake()
    {
        Camera.depthTextureMode = DepthTextureMode;
    }

    // Use this for initialization
    void Start()
    {
        _camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnValidate()
    {
        Camera.depthTextureMode = DepthTextureMode;
    }

    void OnGUI()
    {/*
        if (GUI.Button(new Rect(10, 150 * 0 + 10, 300, 150), "None"))
        {
            DepthTextureMode = DepthTextureMode.None;
        }
        if (GUI.Button(new Rect(10, 150 * 1 + 10, 300, 150), "Depth"))
        {
            DepthTextureMode = DepthTextureMode.Depth;
        }
        if (GUI.Button(new Rect(10, 150 * 2 + 10, 300, 150), "DepthNormals"))
        {
            DepthTextureMode = DepthTextureMode.DepthNormals;
        }
        if (GUI.Button(new Rect(10, 150 * 3 + 10, 300, 150), "MotionVectors"))
        {
            DepthTextureMode = DepthTextureMode.MotionVectors;
        }
        */
        Camera.depthTextureMode = DepthTextureMode;
    }
}