using UnityEngine;

namespace Simplify2D
{
    public class Simplified2DCanvas : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("CheckFramerateLimit", 1, 1);
        }

        /// <summary>
        /// Check if the framerate limit has changed in 
        /// the playerprefs 
        /// </summary>
        private void CheckFramerateLimit()
        {
            // Limit FPS = 1 / No Limit = 0 
            int limitFPS = PlayerPrefs.GetInt("LimitFPS", 0);

            // No limit
            if (limitFPS == 0)
            {
                QualitySettings.vSyncCount = 1;
                Application.targetFrameRate = -1;                
            }
            // limit to 60 FPS
            else
            {                
                QualitySettings.vSyncCount = 0;
                Application.targetFrameRate = 60;
            }
        }
    }
}
