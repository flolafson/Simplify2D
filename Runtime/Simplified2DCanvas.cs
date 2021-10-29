using UnityEngine;

namespace Simplify2D
{
    public class Simplified2DCanvas : MonoBehaviour
    {
        private bool limitFPS = false;

        void Awake() 
        {
            CheckFramerateLimit();
        }

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
            bool newLimitFPS = PlayerPrefs.GetInt("LimitFPS", 0) == 0 ? false : true;

            // Limit has changed
            if (limitFPS != newLimitFPS)
            {
                limitFPS = newLimitFPS;

                // No limit
                if (limitFPS)
                {
                    QualitySettings.vSyncCount = 0;
                    Application.targetFrameRate = 60;
                    
                }
                // limit to 60 FPS
                else
                {
                    QualitySettings.vSyncCount = 1;
                    Application.targetFrameRate = -1;
                }
            }
        }
    }
}
