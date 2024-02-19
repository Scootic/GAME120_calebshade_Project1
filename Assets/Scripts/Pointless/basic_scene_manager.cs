using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class basic_scene_manager : MonoBehaviour
{
    public static basic_scene_manager instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }else if(instance != this)
        {
            Destroy(this);
        }
    }
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
