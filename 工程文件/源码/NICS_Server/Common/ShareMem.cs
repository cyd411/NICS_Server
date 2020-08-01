using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Common
{
    public class ShareMem
    {
        /// <summary>
        /// 用于界面显示信息使用
        /// </summary>
        private static List<string> m_lMessages = new List<string>();
        /// <summary>
        /// 互斥锁
        /// </summary>
        private static Mutex mMutex = new Mutex();
        /// <summary>
        /// 获取记录个个数
        /// </summary>
        /// <returns></returns>
        public static int GetCounter()
        {
            //申请
            mMutex.WaitOne();
            int iRst = m_lMessages.Count();
            //  释放
            mMutex.ReleaseMutex();
            return iRst;
        }
        /// <summary>
        /// 获取要显示的信息
        /// </summary>
        /// <returns></returns>
        public static string GetMessage()
        {
            string strRst = "";
            //申请
            mMutex.WaitOne();
            if (m_lMessages.Count() > 0)
            {
                strRst = m_lMessages[0];
                m_lMessages.RemoveAt(0);
            }

            //  释放
            mMutex.ReleaseMutex();
            return strRst;
        }
        /// <summary>
        /// 插入信息
        /// </summary>
        /// <param name="strMessage">需要插入的信息</param>
        public static void SetMessage(string strMessage)
        {
            //申请
            mMutex.WaitOne();
            if (m_lMessages.Count < 2000)
                m_lMessages.Add(strMessage);
            //  释放
            mMutex.ReleaseMutex();
        }

    }
}
