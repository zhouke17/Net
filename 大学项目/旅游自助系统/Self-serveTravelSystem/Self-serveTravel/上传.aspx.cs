﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Self_serveTravelSystem.Self_serveTravel
{
    public partial class 上传 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=ZHOUKE-PC;database=旅游自助系统;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connStr);
            //打开连接
            conn.Open();
            //insert student values(2017056102,'郭有军','男',23,'市场营销',657,1,NULL)
            //string sql = "insert student values(2017056102,'郭有军','男',23,'市场营销',657,1,NULL)";
            //string sql = "select * from student";
            string sql = string.Format("insert 旅游线路信息表 values({0},{1},'{2}','{3}','{4}','{9}','{8}',{7},{6},{5},null)",TextBox1.Text,TextBox2.Text,TextBox3.Text,TextBox4.Text,TextBox5.Text,TextBox6.Text,TextBox7.Text,TextBox8.Text,TextBox9.Text,TextBox10.Text);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Response.Write("<script>alert('上传成功!')</script>"); 
        }
    }
}