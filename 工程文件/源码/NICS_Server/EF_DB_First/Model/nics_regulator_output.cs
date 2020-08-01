using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_DB_First.Model
{

    //分钟数据表
    public class nics_regulator_output
    {
        //以下内容使用代码工具自动生成


        private int _id;
        private int _client_id;
        private int _regulator_id;
        private string _col_port1_part3;
        private string _col_port1_part1;
        private string _col_port1_part2;
        private DateTime _upload_time;
        private string _col_port19_part1;
        private string _col_port22_part1;
        private string _col_port8_part1;
        private string _col_port5_part3;
        private string _col_port8_part3;
        private string _col_port8_part2;
        private string _col_port5_part1;
        private string _col_port5_part2;
        private string _col_port19_part2;
        private string _col_port19_part3;
        private string _col_port16_part3;
        private string _col_port16_part2;
        private string _col_port16_part1;
        private string _col_port23_part2;
        private string _col_port23_part1;
        private string _col_port23_part3;
        private string _col_port15_part3;
        private string _col_port15_part2;
        private string _col_port21_part2;
        private string _col_port4_part1;
        private string _col_port21_part1;
        private string _col_port4_part2;
        private string _col_port4_part3;
        private string _col_port15_part1;
        private string _col_port7_part3;
        private string _col_port12_part3;
        private string _col_port12_part1;
        private string _col_port12_part2;
        private string _col_port7_part1;
        private string _col_port7_part2;
        private string _col_port3_part2;
        private string _col_port14_part3;
        private string _col_port3_part1;
        private string _col_port14_part1;
        private string _col_port3_part3;
        private string _col_port14_part2;
        private string _col_port24_part1;
        private string _col_port24_part2;
        private string _col_port24_part3;
        private string _col_port10_part1;
        private string _col_port20_part3;
        private string _col_port6_part1;
        private string _col_port10_part2;
        private string _col_port20_part2;
        private string _col_port6_part2;
        private string _col_port20_part1;
        private string _col_port6_part3;
        private string _col_port11_part2;
        private string _col_port11_part3;
        private string _col_port21_part3;
        private string _col_port18_part3;
        private string _col_port18_part2;
        private string _col_port18_part1;
        private string _col_port13_part1;
        private string _col_port13_part2;
        private string _col_port13_part3;
        private string _col_port11_part1;
        private string _col_port9_part3;
        private string _col_port9_part2;
        private string _col_port10_part3;
        private string _col_port9_part1;
        private string _col_port2_part3;
        private string _col_port2_part2;
        private string _col_port2_part1;
        private string _col_port22_part3;
        private string _col_port22_part2;
        private string _col_port17_part1;
        private string _watt;
        private string _col_port17_part3;
        private string _col_port17_part2;
        private string _voltage;
        private string _ampere;
        private string _total_energy;



        /// <summary>
        /// auto_increment
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 客户端
        /// </summary>
        public int client_id
        {
            set { _client_id = value; }
            get { return _client_id; }
        }
        /// <summary>
        /// 控制器ID
        /// </summary>
        public int regulator_id
        {
            set { _regulator_id = value; }
            get { return _regulator_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port1_part3
        {
            set { _col_port1_part3 = value; }
            get { return _col_port1_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port1_part1
        {
            set { _col_port1_part1 = value; }
            get { return _col_port1_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port1_part2
        {
            set { _col_port1_part2 = value; }
            get { return _col_port1_part2; }
        }
        /// <summary>
        /// 上传时间
        /// </summary>
        public DateTime upload_time
        {
            set { _upload_time = value; }
            get { return _upload_time; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port19_part1
        {
            set { _col_port19_part1 = value; }
            get { return _col_port19_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port22_part1
        {
            set { _col_port22_part1 = value; }
            get { return _col_port22_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port8_part1
        {
            set { _col_port8_part1 = value; }
            get { return _col_port8_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port5_part3
        {
            set { _col_port5_part3 = value; }
            get { return _col_port5_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port8_part3
        {
            set { _col_port8_part3 = value; }
            get { return _col_port8_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port8_part2
        {
            set { _col_port8_part2 = value; }
            get { return _col_port8_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port5_part1
        {
            set { _col_port5_part1 = value; }
            get { return _col_port5_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port5_part2
        {
            set { _col_port5_part2 = value; }
            get { return _col_port5_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port19_part2
        {
            set { _col_port19_part2 = value; }
            get { return _col_port19_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port19_part3
        {
            set { _col_port19_part3 = value; }
            get { return _col_port19_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port16_part3
        {
            set { _col_port16_part3 = value; }
            get { return _col_port16_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port16_part2
        {
            set { _col_port16_part2 = value; }
            get { return _col_port16_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port16_part1
        {
            set { _col_port16_part1 = value; }
            get { return _col_port16_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port23_part2
        {
            set { _col_port23_part2 = value; }
            get { return _col_port23_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port23_part1
        {
            set { _col_port23_part1 = value; }
            get { return _col_port23_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port23_part3
        {
            set { _col_port23_part3 = value; }
            get { return _col_port23_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port15_part3
        {
            set { _col_port15_part3 = value; }
            get { return _col_port15_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port15_part2
        {
            set { _col_port15_part2 = value; }
            get { return _col_port15_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port21_part2
        {
            set { _col_port21_part2 = value; }
            get { return _col_port21_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port4_part1
        {
            set { _col_port4_part1 = value; }
            get { return _col_port4_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port21_part1
        {
            set { _col_port21_part1 = value; }
            get { return _col_port21_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port4_part2
        {
            set { _col_port4_part2 = value; }
            get { return _col_port4_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port4_part3
        {
            set { _col_port4_part3 = value; }
            get { return _col_port4_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port15_part1
        {
            set { _col_port15_part1 = value; }
            get { return _col_port15_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port7_part3
        {
            set { _col_port7_part3 = value; }
            get { return _col_port7_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port12_part3
        {
            set { _col_port12_part3 = value; }
            get { return _col_port12_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port12_part1
        {
            set { _col_port12_part1 = value; }
            get { return _col_port12_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port12_part2
        {
            set { _col_port12_part2 = value; }
            get { return _col_port12_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port7_part1
        {
            set { _col_port7_part1 = value; }
            get { return _col_port7_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port7_part2
        {
            set { _col_port7_part2 = value; }
            get { return _col_port7_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port3_part2
        {
            set { _col_port3_part2 = value; }
            get { return _col_port3_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port14_part3
        {
            set { _col_port14_part3 = value; }
            get { return _col_port14_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port3_part1
        {
            set { _col_port3_part1 = value; }
            get { return _col_port3_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port14_part1
        {
            set { _col_port14_part1 = value; }
            get { return _col_port14_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port3_part3
        {
            set { _col_port3_part3 = value; }
            get { return _col_port3_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port14_part2
        {
            set { _col_port14_part2 = value; }
            get { return _col_port14_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port24_part1
        {
            set { _col_port24_part1 = value; }
            get { return _col_port24_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port24_part2
        {
            set { _col_port24_part2 = value; }
            get { return _col_port24_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port24_part3
        {
            set { _col_port24_part3 = value; }
            get { return _col_port24_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port10_part1
        {
            set { _col_port10_part1 = value; }
            get { return _col_port10_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port20_part3
        {
            set { _col_port20_part3 = value; }
            get { return _col_port20_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port6_part1
        {
            set { _col_port6_part1 = value; }
            get { return _col_port6_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port10_part2
        {
            set { _col_port10_part2 = value; }
            get { return _col_port10_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port20_part2
        {
            set { _col_port20_part2 = value; }
            get { return _col_port20_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port6_part2
        {
            set { _col_port6_part2 = value; }
            get { return _col_port6_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port20_part1
        {
            set { _col_port20_part1 = value; }
            get { return _col_port20_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port6_part3
        {
            set { _col_port6_part3 = value; }
            get { return _col_port6_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port11_part2
        {
            set { _col_port11_part2 = value; }
            get { return _col_port11_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port11_part3
        {
            set { _col_port11_part3 = value; }
            get { return _col_port11_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port21_part3
        {
            set { _col_port21_part3 = value; }
            get { return _col_port21_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port18_part3
        {
            set { _col_port18_part3 = value; }
            get { return _col_port18_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port18_part2
        {
            set { _col_port18_part2 = value; }
            get { return _col_port18_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port18_part1
        {
            set { _col_port18_part1 = value; }
            get { return _col_port18_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port13_part1
        {
            set { _col_port13_part1 = value; }
            get { return _col_port13_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port13_part2
        {
            set { _col_port13_part2 = value; }
            get { return _col_port13_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port13_part3
        {
            set { _col_port13_part3 = value; }
            get { return _col_port13_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port11_part1
        {
            set { _col_port11_part1 = value; }
            get { return _col_port11_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port9_part3
        {
            set { _col_port9_part3 = value; }
            get { return _col_port9_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port9_part2
        {
            set { _col_port9_part2 = value; }
            get { return _col_port9_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port10_part3
        {
            set { _col_port10_part3 = value; }
            get { return _col_port10_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port9_part1
        {
            set { _col_port9_part1 = value; }
            get { return _col_port9_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port2_part3
        {
            set { _col_port2_part3 = value; }
            get { return _col_port2_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port2_part2
        {
            set { _col_port2_part2 = value; }
            get { return _col_port2_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port2_part1
        {
            set { _col_port2_part1 = value; }
            get { return _col_port2_part1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port22_part3
        {
            set { _col_port22_part3 = value; }
            get { return _col_port22_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port22_part2
        {
            set { _col_port22_part2 = value; }
            get { return _col_port22_part2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port17_part1
        {
            set { _col_port17_part1 = value; }
            get { return _col_port17_part1; }
        }
        /// <summary>
        /// 功率
        /// </summary>
        public string watt
        {
            set { _watt = value; }
            get { return _watt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port17_part3
        {
            set { _col_port17_part3 = value; }
            get { return _col_port17_part3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string col_port17_part2
        {
            set { _col_port17_part2 = value; }
            get { return _col_port17_part2; }
        }
        /// <summary>
        /// 电压
        /// </summary>
        public string voltage
        {
            get { return _voltage; }
            set { _voltage = value; }
        }

        /// <summary>
        /// 电流
        /// </summary>
        public string ampere
        {
            get { return _ampere; }
            set { _ampere = value; }
        }
        /// <summary>
        /// 累计能耗
        /// </summary>
        public string total_energy
        {
            get { return _total_energy; }
            set { _total_energy = value; }
        }
    }
}
