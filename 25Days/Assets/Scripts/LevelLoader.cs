using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour 
{
    public float delay = 2f;
    public string level;

	void Update () 
    {
	    if (Time.timeSinceLevelLoad > delay)
        {
            Application.LoadLevel(level);
        }
	}
}
