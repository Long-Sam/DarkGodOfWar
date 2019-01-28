/****************************************************
    文件：LoginWnd.cs
	作者：Sam
    邮箱: 993528129@qq.com
    日期：2019/1/25 15:57:38
	功能：登陆注册界面
*****************************************************/

using UnityEngine;
using UnityEngine.UI;
public class LoginWnd : WindowRoot 
{
    public InputField iptAcct;
    public InputField iptPass;
    public Button btnEnter;
    public Button btnNotice;
    protected override void InitWnd()
    {
        //获取本地存储的账号和密码
        if (PlayerPrefs.HasKey("Acct") && PlayerPrefs.HasKey("Pass"))
        {
            iptAcct.text = PlayerPrefs.GetString("Acct");
            iptPass.text = PlayerPrefs.GetString("Pass");
        }else
        {
            iptAcct.text = "";
            iptPass.text = "";
        }
    }
    //TODO更新本地存储的账号密码
    
}