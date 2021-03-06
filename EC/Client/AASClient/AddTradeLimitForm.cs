﻿using AASClient.AASServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AASClient
{
    public partial class AddTradeLimitForm : Form
    {

        public AddTradeLimitForm()
        {
            InitializeComponent();

   
        }

        private void AddTradeLimitForm_Load(object sender, EventArgs e)
        {
            this.comboBox交易员.DataSource = Program.AASServiceClient.QueryJY();
            this.comboBox交易员.DisplayMember = "用户名";


            //AASClient.AASServiceReference.DbDataSet.券商帐户DataTable 券商帐户DataTable1 = Program.AASServiceClient.QueryQsAccount();

            //foreach (AASClient.AASServiceReference.DbDataSet.券商帐户Row 券商帐户Row1 in 券商帐户DataTable1)
            //{
            //    this.comboBox组合号.Items.Add(券商帐户Row1.名称);
            //}
            var dt = Program.AASServiceClient.QueryECoinQsAccount();
            foreach (var item in dt)
            {
                this.comboBox组合号.Items.Add(item.名称);
            }

            
            if (this.comboBox组合号.Items.Count>0)
            {
                this.comboBox组合号.SelectedIndex = 0;
            }
            
            this.comboBox市场.SelectedIndex = 0;
            this.comboBox买模式.DataSource = System.Enum.GetNames(typeof(买模式));
            this.comboBox卖模式.DataSource = System.Enum.GetNames(typeof(卖模式));
        }

        private void AddTradeLimitForm_Activated(object sender, EventArgs e)
        {
            this.textBox证券代码.Focus();
        }


        private void textBox拼音缩写_Leave(object sender, EventArgs e)
        {
            this.textBox拼音缩写.Text = this.textBox拼音缩写.Text.ToUpper();
        }

        private void button添加交易额度_Click(object sender, EventArgs e)
        {
            if (this.numericUpDown手续费率.Value == 0)
            {
                var result = MessageBox.Show("手续费率为0，是否保存?", "提示", MessageBoxButtons.OKCancel);
                if (result != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }
            }
            Program.AASServiceClient.AddTradeLimit(this.comboBox交易员.Text, this.textBox证券代码.Text, this.comboBox组合号.Text, (byte)this.comboBox市场.SelectedIndex, this.textBox证券名称.Text, this.textBox拼音缩写.Text, (买模式)this.comboBox买模式.SelectedIndex, (卖模式)this.comboBox卖模式.SelectedIndex, this.numericUpDown交易额度.Value, this.numericUpDown手续费率.Value);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            
        }

        private void numericUpDown交易额度_ValueChanged(object sender, EventArgs e)
        {

        }

       
       
     

       

        
    }
}
