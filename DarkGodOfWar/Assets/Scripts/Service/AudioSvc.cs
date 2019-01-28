/****************************************************
    文件：AudioSvc.cs
	作者：Sam
    邮箱: 993528129@qq.com
    日期：2019/1/25 17:0:12
	功能：声音播放服务
*****************************************************/

using UnityEngine;

public class AudioSvc :MonoSingleton<AudioSvc> 
{
    public AudioSource bgAudio;
    public AudioSource uiAudio;
    public void InitSvc()
    {
        Debug.Log("init AudioSvc...");
    }
    public void PlayBGMusic(string name,bool isLoop = true)
    {
        AudioClip audio=ResSvc.Instance.LoadAudio("ResAudio/"+name,true);
        if(bgAudio.clip==null|| bgAudio.name != audio.name)
        {
            bgAudio.clip = audio;
            bgAudio.loop = isLoop;
            bgAudio.Play();
        }
    }
    public void PlayUIAudio(string name)
    {
        AudioClip audio = ResSvc.Instance.LoadAudio("ResAudio/" + name, true);
        if (uiAudio.clip == null || uiAudio.name != audio.name)
        {
            uiAudio.clip = audio;
            uiAudio.Play();
        }
    }
}