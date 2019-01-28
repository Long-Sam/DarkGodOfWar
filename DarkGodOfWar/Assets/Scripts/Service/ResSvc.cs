/****************************************************
    文件：ResSvc.cs
	作者：Sam
    邮箱: 993528129@qq.com
    日期：2019/1/25 14:24:26
	功能：Nothing
*****************************************************/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResSvc : MonoSingleton<ResSvc> 
{
    public void InitSvc()
    {
        Debug.Log("Init ResSvc...");

    }
    private Action prgCb = null;
    public void AsyncLoadScene(string sceneName,Action loaded=null)
    {
        GameRoot.Instance.loadWnd.SetWndState();
        
        AsyncOperation sceneAsync = SceneManager.LoadSceneAsync(sceneName);
        prgCb = () =>
        {
            float val = sceneAsync.progress;
            GameRoot.Instance.loadWnd.SetProgress(val);
            if (val == 1)
            {
                //LoginSys.Instance.OpenLoginWnd();
                if(loaded!=null)
                loaded();
                prgCb = null;
                sceneAsync = null;
                GameRoot.Instance.loadWnd.SetWndState(false);
            }
        };
    }
    private void Update()
    {
        if (prgCb != null)
        {
            prgCb();
        }
    }
    private Dictionary<string, AudioClip> adDic = new Dictionary<string, AudioClip>();
    public AudioClip LoadAudio(string path,bool cache = false)
    {
        AudioClip au = null;
        if(!adDic.TryGetValue(path,out au))
        {
            au = Resources.Load<AudioClip>(path);
            if (cache)
            {
                adDic.Add(path, au);
            }
        }
        
        return au;
    }
}