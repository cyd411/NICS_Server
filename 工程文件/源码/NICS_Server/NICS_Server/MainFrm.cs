using BLL;
using Common;
using EF_DB_First.Model;
using Model;
using RestFulService;
using SuperSocketServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NICS_Server
{
    public partial class MainFrm : Form
    {
        /// <summary>
        /// xml配置信息对象
        /// </summary>
        private ServerXml mServerXml;


        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            LoadFrmCfg();
            this.Text += DefParam.VERSION;

            this.timerShowLog.Start();
        }



        /// <summary>
        /// 加载窗体参数
        /// </summary>
        private void LoadFrmCfg()
        {
            mServerXml = new ServerXmlBLL().GetModel();
            this.integerInputPort.Value = Convert.ToInt32(mServerXml.Port);
            this.integerInputAPIPort.Value = Convert.ToInt32(mServerXml.API_Port);
        }
        /// <summary>
        /// 保存窗体参数
        /// </summary>
        private void SaveFrmCfg()
        {
            mServerXml.Port = this.integerInputPort.Value.ToString();
            mServerXml.API_Port = this.integerInputAPIPort.Value.ToString();
            new ServerXmlBLL().UpdateModel(mServerXml);
        }

        private void timerShowLog_Tick(object sender, EventArgs e)
        {
            if (ShareMem.GetCounter() > 0)
            {
                //这里打开，用于防止界面最小化后，显示不正确的问题
                this.richTextBoxExLog.HideSelection = true;

                if (this.richTextBoxExLog.Text.Length >= 1024 * 100)
                {
                    this.richTextBoxExLog.Text = "";
                }

                string strMsg = ShareMem.GetMessage();

                this.richTextBoxExLog.ForeColor = Color.Black;
                int iP1 = this.richTextBoxExLog.TextLength;
                this.richTextBoxExLog.AppendText(strMsg);
                this.richTextBoxExLog.AppendText(Environment.NewLine);
                int iP2 = this.richTextBoxExLog.TextLength;

                this.richTextBoxExLog.Select(iP1, iP2);
                if (strMsg.IndexOf("#重要#") >= 0)
                {
                    this.richTextBoxExLog.SelectionColor = Color.Red;
                }
                else
                {
                    this.richTextBoxExLog.SelectionColor = Color.Black;
                }
                this.richTextBoxExLog.Select(iP2, iP2);
                //这里关掉，用于显示最后一行
                this.richTextBoxExLog.HideSelection = false;
            }
        }


        /// <summary>
        /// 开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonXStart_Click(object sender, EventArgs e)
        {

            SaveFrmCfg();
          
            //nics 服务器端程序，处理nics客户端
            NICSServerProgram oNICSServerProgram = new NICSServerProgram();
            oNICSServerProgram.ServerSvrStart(mServerXml);

            //API服务程序启动
            RestFulServiceProgram oRestFulServiceProgram = new RestFulServiceProgram();
            RestFulServiceProgram.m_ServerXml = mServerXml;
            oRestFulServiceProgram.ApiSvrStart();

            LoadFrmCfg();


            this.buttonXStart.Enabled = false;
            this.buttonXStop.Enabled = true;
            this.integerInputPort.Enabled = false;
            this.integerInputAPIPort.Enabled = false;
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonXStop_Click(object sender, EventArgs e)
        {
            this.buttonXStart.Enabled = true;
            this.buttonXStop.Enabled = false;
            this.integerInputPort.Enabled = true;
            this.Close();
        }
    }
}
