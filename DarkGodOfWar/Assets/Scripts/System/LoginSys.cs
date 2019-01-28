/****************************************************
    文件：LoginSys.cs
	作者：Sam
    邮箱: 993528129@qq.com
    日期：2019/1/25 14:23:5
	功能：登录系统
*****************************************************/

using UnityEngine;

public class LoginSys : SystemRoot
{
    public LoginWnd loginWnd;
    public override void InitSys()
    {
        base.InitSys();
        Debug.Log("Init LoginSvc...");
    }
    /// <summary>
    /// 进入登陆场景
    /// </summary>
    public void EnterLogin()
    {
       
        //TODO
        //异步加载登陆场景
        ResSvc.Instance.AsyncLoadScene(Constants.SceneLogin,OpenLoginWnd);
        //并显示加载的进度条
        //加载完成以后再打开注册登录界面
    }
    public void OpenLoginWnd()
    {
        loginWnd.SetWndState();
        audioSvc.PlayBGMusic(Constants.BGLogin, true);
    }
}