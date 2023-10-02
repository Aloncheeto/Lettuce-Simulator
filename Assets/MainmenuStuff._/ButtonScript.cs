using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour
{
    public bool UsePhys2D;  
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("LoadingScreen");
    }
    private void Update()
    {
        print(UsePhys2D);
    }
    public void UpdatePhysOption()
    {
       
    }
}
