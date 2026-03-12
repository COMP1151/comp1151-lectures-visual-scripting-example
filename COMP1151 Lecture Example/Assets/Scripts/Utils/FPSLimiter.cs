using UnityEngine;

public class FPSLimiter : MonoBehaviour
{
    [SerializeField] private int targetFPS = 60;

    private int oldVSyncCount;

    void OnEnable()
    {
        oldVSyncCount = QualitySettings.vSyncCount;
        QualitySettings.vSyncCount = 0;
    }

    void OnDisable()
    {
        QualitySettings.vSyncCount = oldVSyncCount;
        Application.targetFrameRate = -1; // unlimited        
    }

    void Update()
    {
        Application.targetFrameRate = targetFPS;
    }
}
