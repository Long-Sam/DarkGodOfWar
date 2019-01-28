/****************************************************
    文件：LoopDragonAni.cs
	作者：Sam
    邮箱: 993528129@qq.com
    日期：2019/1/25 17:52:11
	功能：飞龙循环动画
*****************************************************/

using UnityEngine;

public class LoopDragonAni : MonoBehaviour 
{
    private Animation ani;
    private void Awake()
    {
        ani = GetComponent<Animation>();
    }
    private void Start()
    {
        if (ani != null)
        {
            InvokeRepeating("PlayDragonAni", 0, 20);
        }
    }
    private void PlayDragonAni()
    {
        if (ani != null)
        {
            ani.Play();
        }
    }
}