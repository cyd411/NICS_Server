using Common;
using DBUtility;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ServerXmlDAL
    {
        /// <summary>
        /// 获取xml配置信息对象
        /// </summary>
        /// <returns></returns>
        public ServerXml GetModel()
        {
            DataSet oDataSet = XmlHelper.GetDataSet(DefParam.CONFIG_PATH_FILE, XmlHelper.XmlType.File);
            ServerXml oServerXml = new ServerXml();
            oServerXml.Port = oDataSet.Tables["MAIN_FRM"].Rows[0]["PORT"].ToString();
            oServerXml.Ip = oDataSet.Tables["MAIN_FRM"].Rows[0]["IP"].ToString();
            oServerXml.Id = oDataSet.Tables["MAIN_FRM"].Rows[0]["ID"].ToString();
            oServerXml.API_Port = oDataSet.Tables["MAIN_FRM"].Rows[0]["API_PORT"].ToString();
            //oServerXml.Server_ip = oDataSet.Tables["SQL"].Rows[0]["SERVER_IP"].ToString();
            //oServerXml.User_name = oDataSet.Tables["SQL"].Rows[0]["USER_NAME"].ToString();
            //oServerXml.Password = oDataSet.Tables["SQL"].Rows[0]["PASSWORD"].ToString();


            oServerXml.Client_max_num = oDataSet.Tables["SOCKET"].Rows[0]["CLIENT_MAX_NUM"].ToString();
            oServerXml.Socket_timeout_ms = oDataSet.Tables["SOCKET"].Rows[0]["SOCKET_TIMEOUT_MS"].ToString();
            oServerXml.File_Directory = oDataSet.Tables["SOCKET"].Rows[0]["FILE_DIRECTORY"].ToString();



            return oServerXml;
        }
        /// <summary>
        /// 更新对象信息
        /// </summary>
        /// <param name="oServerXml"></param>
        public void UpdateModel(ServerXml oServerXml)
        {
            //目前只更新界面上的参数，不更新数据库的用户名密码ip
            XmlHelper.UpdateNode(DefParam.CONFIG_PATH_FILE, "PORT", oServerXml.Port);
            XmlHelper.UpdateNode(DefParam.CONFIG_PATH_FILE, "IP", oServerXml.Ip);
            XmlHelper.UpdateNode(DefParam.CONFIG_PATH_FILE, "ID", oServerXml.Id);
            XmlHelper.UpdateNode(DefParam.CONFIG_PATH_FILE, "API_PORT", oServerXml.API_Port);
        }
    }
}
