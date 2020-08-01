namespace NICS_Server
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.timerShowLog = new System.Windows.Forms.Timer(this.components);
            this.tabControl2 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.buttonXStop = new DevComponents.DotNetBar.ButtonX();
            this.checkBoxXSocketLog = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.richTextBoxExLog = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.buttonXStart = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.integerInputPort = new DevComponents.Editors.IntegerInput();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.integerInputAPIPort = new DevComponents.Editors.IntegerInput();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl2)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerInputPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInputAPIPort)).BeginInit();
            this.SuspendLayout();
            // 
            // timerShowLog
            // 
            this.timerShowLog.Interval = 50;
            this.timerShowLog.Tick += new System.EventHandler(this.timerShowLog_Tick);
            // 
            // tabControl2
            // 
            this.tabControl2.BackColor = System.Drawing.Color.Transparent;
            this.tabControl2.CanReorderTabs = true;
            this.tabControl2.Controls.Add(this.tabControlPanel2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl2.SelectedTabIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(933, 751);
            this.tabControl2.TabIndex = 8;
            this.tabControl2.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl2.Tabs.Add(this.tabItem3);
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.panelEx3);
            this.tabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 31);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(2);
            this.tabControlPanel2.Size = new System.Drawing.Size(933, 720);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 1;
            this.tabControlPanel2.TabItem = this.tabItem3;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.panelEx2);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx3.Location = new System.Drawing.Point(2, 2);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(929, 716);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 1;
            this.panelEx3.Text = "panelEx3";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.buttonXStop);
            this.panelEx2.Controls.Add(this.checkBoxXSocketLog);
            this.panelEx2.Controls.Add(this.richTextBoxExLog);
            this.panelEx2.Controls.Add(this.buttonXStart);
            this.panelEx2.Controls.Add(this.labelX3);
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.Controls.Add(this.integerInputAPIPort);
            this.panelEx2.Controls.Add(this.integerInputPort);
            this.panelEx2.Controls.Add(this.line2);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.Controls.Add(this.line1);
            this.panelEx2.Controls.Add(this.labelX5);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Margin = new System.Windows.Forms.Padding(4);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(929, 716);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 12;
            // 
            // buttonXStop
            // 
            this.buttonXStop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXStop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXStop.Enabled = false;
            this.buttonXStop.Location = new System.Drawing.Point(788, 68);
            this.buttonXStop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXStop.Name = "buttonXStop";
            this.buttonXStop.Size = new System.Drawing.Size(123, 34);
            this.buttonXStop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXStop.TabIndex = 0;
            this.buttonXStop.Text = "退出";
            this.buttonXStop.Click += new System.EventHandler(this.buttonXStop_Click);
            // 
            // checkBoxXSocketLog
            // 
            this.checkBoxXSocketLog.AutoSize = true;
            // 
            // 
            // 
            this.checkBoxXSocketLog.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxXSocketLog.Location = new System.Drawing.Point(385, 70);
            this.checkBoxXSocketLog.Name = "checkBoxXSocketLog";
            this.checkBoxXSocketLog.Size = new System.Drawing.Size(121, 25);
            this.checkBoxXSocketLog.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxXSocketLog.TabIndex = 8;
            this.checkBoxXSocketLog.Text = "socket日志";
            // 
            // richTextBoxExLog
            // 
            this.richTextBoxExLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.richTextBoxExLog.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxExLog.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxExLog.Location = new System.Drawing.Point(20, 201);
            this.richTextBoxExLog.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxExLog.Name = "richTextBoxExLog";
            this.richTextBoxExLog.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset" +
    "134 \\\'cb\\\'ce\\\'cc\\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs18\\par\r\n}\r\n";
            this.richTextBoxExLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxExLog.Size = new System.Drawing.Size(892, 497);
            this.richTextBoxExLog.TabIndex = 7;
            // 
            // buttonXStart
            // 
            this.buttonXStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonXStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonXStart.Location = new System.Drawing.Point(657, 68);
            this.buttonXStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonXStart.Name = "buttonXStart";
            this.buttonXStart.Size = new System.Drawing.Size(123, 34);
            this.buttonXStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonXStart.TabIndex = 0;
            this.buttonXStart.Text = "启动";
            this.buttonXStart.Click += new System.EventHandler(this.buttonXStart_Click);
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(18, 18);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(157, 25);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "服务器配置信息：";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(18, 140);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(64, 25);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "日志：";
            // 
            // integerInputPort
            // 
            // 
            // 
            // 
            this.integerInputPort.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInputPort.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInputPort.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInputPort.Location = new System.Drawing.Point(133, 66);
            this.integerInputPort.Margin = new System.Windows.Forms.Padding(4);
            this.integerInputPort.MinValue = 0;
            this.integerInputPort.Name = "integerInputPort";
            this.integerInputPort.ShowUpDown = true;
            this.integerInputPort.Size = new System.Drawing.Size(210, 28);
            this.integerInputPort.TabIndex = 5;
            this.integerInputPort.Value = 6000;
            // 
            // line2
            // 
            this.line2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line2.Location = new System.Drawing.Point(18, 34);
            this.line2.Margin = new System.Windows.Forms.Padding(4);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(893, 34);
            this.line2.TabIndex = 3;
            this.line2.Text = "日志：";
            // 
            // line1
            // 
            this.line1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line1.Location = new System.Drawing.Point(18, 156);
            this.line1.Margin = new System.Windows.Forms.Padding(4);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(893, 34);
            this.line1.TabIndex = 3;
            this.line1.Text = "日志：";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(24, 70);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(120, 25);
            this.labelX5.TabIndex = 2;
            this.labelX5.Text = "客户端端口：";
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanel2;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "服务器参数";
            // 
            // tabItem2
            // 
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "站点管理";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(24, 106);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(92, 25);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "API端口：";
            // 
            // integerInputAPIPort
            // 
            // 
            // 
            // 
            this.integerInputAPIPort.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerInputAPIPort.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerInputAPIPort.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerInputAPIPort.Location = new System.Drawing.Point(133, 102);
            this.integerInputAPIPort.Margin = new System.Windows.Forms.Padding(4);
            this.integerInputAPIPort.MinValue = 0;
            this.integerInputAPIPort.Name = "integerInputAPIPort";
            this.integerInputAPIPort.ShowUpDown = true;
            this.integerInputAPIPort.Size = new System.Drawing.Size(210, 28);
            this.integerInputAPIPort.TabIndex = 5;
            this.integerInputAPIPort.Value = 7788;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 751);
            this.Controls.Add(this.tabControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NICS服务器";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl2)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerInputPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.integerInputAPIPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerShowLog;
        private DevComponents.DotNetBar.TabControl tabControl2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxXSocketLog;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxExLog;
        private DevComponents.DotNetBar.ButtonX buttonXStart;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.IntegerInput integerInputPort;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX buttonXStop;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.Editors.IntegerInput integerInputAPIPort;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}

