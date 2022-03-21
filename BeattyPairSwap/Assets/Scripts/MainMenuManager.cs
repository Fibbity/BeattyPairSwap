using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    //-----------------------------//
    public void ChangeScreen(int value)
    //-----------------------------//
    {
        if(value == 0)
        {
            SceneManager.LoadScene(1);
        }
        if(value == 1)
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
        }

    }//END ChangeScreen


}//END MainMenuManager
