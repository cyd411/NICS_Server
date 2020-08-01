using EF_DB_First.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_DB_First.DAL
{
    public class nics_regulator_outputDAL
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(nics_regulator_output model)
        {
            string strTableNameDate = model.upload_time.Year.ToString("D4") + "_" + model.upload_time.Month.ToString("D2");
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into nics_regulator_output_" + strTableNameDate + " (");
            strSql.Append("client_id,regulator_id,col_port1_part3,col_port1_part1,col_port1_part2,upload_time,col_port19_part1,col_port22_part1,col_port8_part1,col_port5_part3,col_port8_part3,col_port8_part2,col_port5_part1,col_port5_part2,col_port19_part2,col_port19_part3,col_port16_part3,col_port16_part2,col_port16_part1,col_port23_part2,col_port23_part1,col_port23_part3,col_port15_part3,col_port15_part2,col_port21_part2,col_port4_part1,col_port21_part1,col_port4_part2,col_port4_part3,col_port15_part1,col_port7_part3,col_port12_part3,col_port12_part1,col_port12_part2,col_port7_part1,col_port7_part2,col_port3_part2,col_port14_part3,col_port3_part1,col_port14_part1,col_port3_part3,col_port14_part2,col_port24_part1,col_port24_part2,col_port24_part3,col_port10_part1,col_port20_part3,col_port6_part1,col_port10_part2,col_port20_part2,col_port6_part2,col_port20_part1,col_port6_part3,col_port11_part2,col_port11_part3,col_port21_part3,col_port18_part3,col_port18_part2,col_port18_part1,col_port13_part1,col_port13_part2,col_port13_part3,col_port11_part1,col_port9_part3,col_port9_part2,col_port10_part3,col_port9_part1,col_port2_part3,col_port2_part2,col_port2_part1,col_port22_part3,col_port22_part2,col_port17_part1,watt,col_port17_part3,col_port17_part2,voltage,ampere,total_energy)");
            strSql.Append(" values (");
            strSql.Append("@client_id,@regulator_id,@col_port1_part3,@col_port1_part1,@col_port1_part2,@upload_time,@col_port19_part1,@col_port22_part1,@col_port8_part1,@col_port5_part3,@col_port8_part3,@col_port8_part2,@col_port5_part1,@col_port5_part2,@col_port19_part2,@col_port19_part3,@col_port16_part3,@col_port16_part2,@col_port16_part1,@col_port23_part2,@col_port23_part1,@col_port23_part3,@col_port15_part3,@col_port15_part2,@col_port21_part2,@col_port4_part1,@col_port21_part1,@col_port4_part2,@col_port4_part3,@col_port15_part1,@col_port7_part3,@col_port12_part3,@col_port12_part1,@col_port12_part2,@col_port7_part1,@col_port7_part2,@col_port3_part2,@col_port14_part3,@col_port3_part1,@col_port14_part1,@col_port3_part3,@col_port14_part2,@col_port24_part1,@col_port24_part2,@col_port24_part3,@col_port10_part1,@col_port20_part3,@col_port6_part1,@col_port10_part2,@col_port20_part2,@col_port6_part2,@col_port20_part1,@col_port6_part3,@col_port11_part2,@col_port11_part3,@col_port21_part3,@col_port18_part3,@col_port18_part2,@col_port18_part1,@col_port13_part1,@col_port13_part2,@col_port13_part3,@col_port11_part1,@col_port9_part3,@col_port9_part2,@col_port10_part3,@col_port9_part1,@col_port2_part3,@col_port2_part2,@col_port2_part1,@col_port22_part3,@col_port22_part2,@col_port17_part1,@watt,@col_port17_part3,@col_port17_part2,@voltage,@ampere,@total_energy)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@client_id", MySqlDbType.Int32,19),
					new MySqlParameter("@regulator_id", MySqlDbType.Int32,19),
					new MySqlParameter("@col_port1_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port1_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port1_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@upload_time", MySqlDbType.DateTime),
					new MySqlParameter("@col_port19_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port22_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port8_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port5_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port8_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port8_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port5_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port5_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port19_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port19_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port16_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port16_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port16_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port23_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port23_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port23_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port15_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port15_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port21_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port4_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port21_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port4_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port4_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port15_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port7_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port12_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port12_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port12_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port7_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port7_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port3_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port14_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port3_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port14_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port3_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port14_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port24_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port24_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port24_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port10_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port20_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port6_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port10_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port20_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port6_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port20_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port6_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port11_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port11_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port21_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port18_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port18_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port18_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port13_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port13_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port13_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port11_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port9_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port9_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port10_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port9_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port2_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port2_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port2_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port22_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port22_part2", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port17_part1", MySqlDbType.VarChar,32),
					new MySqlParameter("@watt", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port17_part3", MySqlDbType.VarChar,32),
					new MySqlParameter("@col_port17_part2", MySqlDbType.VarChar,32),
                    new MySqlParameter("@voltage", MySqlDbType.VarChar,32),
                    new MySqlParameter("@ampere", MySqlDbType.VarChar,32),
                    new MySqlParameter("@total_energy", MySqlDbType.VarChar,32)};
            parameters[0].Value = model.client_id;
            parameters[1].Value = model.regulator_id;
            parameters[2].Value = model.col_port1_part3;
            parameters[3].Value = model.col_port1_part1;
            parameters[4].Value = model.col_port1_part2;
            parameters[5].Value = model.upload_time;
            parameters[6].Value = model.col_port19_part1;
            parameters[7].Value = model.col_port22_part1;
            parameters[8].Value = model.col_port8_part1;
            parameters[9].Value = model.col_port5_part3;
            parameters[10].Value = model.col_port8_part3;
            parameters[11].Value = model.col_port8_part2;
            parameters[12].Value = model.col_port5_part1;
            parameters[13].Value = model.col_port5_part2;
            parameters[14].Value = model.col_port19_part2;
            parameters[15].Value = model.col_port19_part3;
            parameters[16].Value = model.col_port16_part3;
            parameters[17].Value = model.col_port16_part2;
            parameters[18].Value = model.col_port16_part1;
            parameters[19].Value = model.col_port23_part2;
            parameters[20].Value = model.col_port23_part1;
            parameters[21].Value = model.col_port23_part3;
            parameters[22].Value = model.col_port15_part3;
            parameters[23].Value = model.col_port15_part2;
            parameters[24].Value = model.col_port21_part2;
            parameters[25].Value = model.col_port4_part1;
            parameters[26].Value = model.col_port21_part1;
            parameters[27].Value = model.col_port4_part2;
            parameters[28].Value = model.col_port4_part3;
            parameters[29].Value = model.col_port15_part1;
            parameters[30].Value = model.col_port7_part3;
            parameters[31].Value = model.col_port12_part3;
            parameters[32].Value = model.col_port12_part1;
            parameters[33].Value = model.col_port12_part2;
            parameters[34].Value = model.col_port7_part1;
            parameters[35].Value = model.col_port7_part2;
            parameters[36].Value = model.col_port3_part2;
            parameters[37].Value = model.col_port14_part3;
            parameters[38].Value = model.col_port3_part1;
            parameters[39].Value = model.col_port14_part1;
            parameters[40].Value = model.col_port3_part3;
            parameters[41].Value = model.col_port14_part2;
            parameters[42].Value = model.col_port24_part1;
            parameters[43].Value = model.col_port24_part2;
            parameters[44].Value = model.col_port24_part3;
            parameters[45].Value = model.col_port10_part1;
            parameters[46].Value = model.col_port20_part3;
            parameters[47].Value = model.col_port6_part1;
            parameters[48].Value = model.col_port10_part2;
            parameters[49].Value = model.col_port20_part2;
            parameters[50].Value = model.col_port6_part2;
            parameters[51].Value = model.col_port20_part1;
            parameters[52].Value = model.col_port6_part3;
            parameters[53].Value = model.col_port11_part2;
            parameters[54].Value = model.col_port11_part3;
            parameters[55].Value = model.col_port21_part3;
            parameters[56].Value = model.col_port18_part3;
            parameters[57].Value = model.col_port18_part2;
            parameters[58].Value = model.col_port18_part1;
            parameters[59].Value = model.col_port13_part1;
            parameters[60].Value = model.col_port13_part2;
            parameters[61].Value = model.col_port13_part3;
            parameters[62].Value = model.col_port11_part1;
            parameters[63].Value = model.col_port9_part3;
            parameters[64].Value = model.col_port9_part2;
            parameters[65].Value = model.col_port10_part3;
            parameters[66].Value = model.col_port9_part1;
            parameters[67].Value = model.col_port2_part3;
            parameters[68].Value = model.col_port2_part2;
            parameters[69].Value = model.col_port2_part1;
            parameters[70].Value = model.col_port22_part3;
            parameters[71].Value = model.col_port22_part2;
            parameters[72].Value = model.col_port17_part1;
            parameters[73].Value = model.watt;
            parameters[74].Value = model.col_port17_part3;
            parameters[75].Value = model.col_port17_part2;
            parameters[76].Value = model.voltage;
            parameters[77].Value = model.ampere;
            parameters[78].Value = model.total_energy;
            int iRst = 0;
            using (var db = new DatabaseContext())
            {
                iRst = db.Database.ExecuteSqlCommand(strSql.ToString(), parameters);
            };
            return iRst;
        }


    }
}
