/****************************************************
    文件：SystemRoot.cs
	作者：Sam
    邮箱: 993528129@qq.com
    日期：2019/1/25 17:38:19
	功能：业务系统基类
*****************************************************/

using UnityEngine;

public class SystemRoot : MonoSingleton<SystemRoot> 
{
    protected ResSvc resSvc;
    protected AudioSvc audioSvc;
    public virtual void InitSys()
    {
        resSvc = ResSvc.Instance;
        audioSvc = AudioSvc.Instance;
    }


}