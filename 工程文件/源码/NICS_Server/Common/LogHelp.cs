using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Common
{
    public class LogHelp
    {
        /// <summary>
        /// 获取时间
        /// </summary>
        /// <returns></returns>
        private static string GetDateTime()
        {
            string str = "【" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "】 ";
            return str;
        }

        /// <summary>
        /// 设置信息
        /// </summary>
        /// <param name="strMessage"></param>
        private static void SetMessage(string strMessage)
        {
            ShareMem.SetMessage(strMessage);
        }



        public static void Error(string strMsg)
        {
            string str = "【错误】" + GetDateTime() + strMsg;
            SetMessage(str);
        }

        public static void ErrorFormat(string strFormat, string strMsg)
        {
            string str = string.Format("【错误】" + GetDateTime() + strFormat, strMsg);
            SetMessage(str);
        }

        public static void ErrorFormat(string strFormat, string strSocket, string strMsg)
        {
            string str = string.Format("【错误】" + GetDateTime() + strFormat, strSocket, strMsg);
            SetMessage(str);
        }
        public static void ErrorFormat(string strFormat, Socket oSocket, string strMsg)
        {
            string str = string.Format("【错误】" + GetDateTime() + strFormat, oSocket, strMsg);
            SetMessage(str);
        }


        public static void Info(string strMsg)
        {
            string str = "【信息】" + GetDateTime() + strMsg;
            SetMessage(str);
        }
        /// <summary>
        /// 重要信息，会加颜色头，拆包的时候回分析
        /// </summary>
        /// <param name="strMsg"></param>
        public static void InfoImportant(string strMsg)
        {
            string str = "#重要#【信息】" + GetDateTime() + strMsg;
            SetMessage(str);
        }

        public static void InfoFormat(string strFormat, string strMsg)
        {
            string str = string.Format("【信息】" + GetDateTime() + strFormat, strMsg);
            SetMessage(str);
        }
        public static void InfoFormat(string strFormat, EndPoint oEndPoint, string strMsg)
        {
            string str = string.Format("【信息】" + GetDateTime() + strFormat, oEndPoint, strMsg);
            SetMessage(str);
        }
        public static void InfoFormat(string strFormat, EndPoint oLocalEndPoint, EndPoint oRemoteEndPoint)
        {
            string str = string.Format("【信息】" + GetDateTime() + strFormat, oLocalEndPoint, oRemoteEndPoint);
            SetMessage(str);
        }
        public static void WarnFormat(string strFormat, EndPoint oLocalEndPoint, EndPoint oRemoteEndPoint)
        {
            string str = string.Format("【警告】" + GetDateTime() + strFormat, oLocalEndPoint, oRemoteEndPoint);
            SetMessage(str);
        }
    }
}
