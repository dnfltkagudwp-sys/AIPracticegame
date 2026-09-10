using UnityEngine;

public class Camer : MonoBehaviour
{
    private void Awake()
    {
         float screenAspectRatio = (float)Screen.width / Screen.height;
         float orthograpicSize = (6-(screenAspectRatio - 0.458f) * 11f);
        if (orthograpicSize < 4)
        {
            orthograpicSize = 4;
        }
        
        Camera.main.orthographicSize = orthograpicSize;
    }
}
