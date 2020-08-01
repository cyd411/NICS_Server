using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class ServerXmlBLL
    {
        private ServerXmlDAL mServerXmlDAL = new ServerXmlDAL();

        /// <summary>
        /// 获取xml配置信息对象
        /// </summary>
        /// <returns></returns>
        public ServerXml GetModel()
        {
            return mServerXmlDAL.GetModel();
        }
        /// <summary>
        /// 更新界面配置信息到xml
        /// </summary>
        /// <param name="oServerXml"></param>
        public void UpdateModel(ServerXml oServerXml)
        {
            mServerXmlDAL.UpdateModel(oServerXml);
        }
    }
}
