﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1QZ3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string[] s_City = new string[3] { "台北市", "新北市", "台中市" };
        string[,] s_Area = new string[3, 3] {
            {"中正區", "文山區", "大安區"},
            {"淡水區", "石碇區", "土城區"},
            {"西屯區", "北屯區", "東區"}
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for(int i_Ct = 0; i_Ct< s_City.Lenght; i_Ct++)
                {
                    ListItem o_L = new ListItem();
                    o_L.Text = o_L.Value =s_City[i_Ct];
                    dpl_City.Items.Add(o_L);
                }
            }
            mt_GenSecondList();
        }

        protected System.Void dpl_City_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            mt_GenSecondList();
        }
        protected void mt_GenSecondList()
        {
            int i_index = dpl_City.SelectedIndex;
            dpl_Area.Items.Clear();
            for(int i_Ct = 0; i_Ct < s_Area.GetLenght(1); i_Ct++)
            {
                ListItem o_L = new ListItem();
                o_L.Text = o_L.Value = s_Area[i_index,i_Ct];
                dpl_Area.Items.Add(o_L);
            }
        }

        protected System.Void rbl_Phone_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            if(rbl_Phone.SelectedIndex == 2)
            {
                txt_Phone.Visible = false;
            }
            else
            {
                txt_Phone.Visible = true;
            }
        }
    }
}