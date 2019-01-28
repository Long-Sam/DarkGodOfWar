/****************************************************
    文件：GameRoot.cs
	作者：Sam
    邮箱: 993528129@qq.com
    日期：2019/1/25 14:13:31
	功能：游戏启动入口
*****************************************************/

using UnityEngine;

public class GameRoot : MonoSingleton<GameRoot> 
{
    public LoadingWnd loadWnd;
    
    private void Start()
    {
        DontDestroyOnLoad(this);
        Debug.Log("Game Start...");
        Init();
         
    }
    private void Init()
    {
        //服务模块初始化
        ResSvc res = GetComponent<ResSvc>();
        res.InitSvc();
        //业务系统初始化
        LoginSys login = GetComponent<LoginSys>();
        login.InitSys();

        //进入登陆场景并加载对应的UI
        login.EnterLogin();
    }
}