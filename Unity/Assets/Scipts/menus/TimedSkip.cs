using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimedSkip : MonoBehaviour
{	
	public float SkipTime = 4f;

    // Update is called once per frame
    void Update()
    {
        SkipTime -= Time.deltaTime;

        if (SkipTime <= 0)
        {
        	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
