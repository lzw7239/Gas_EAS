﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

using EAS.Data;
using EAS.Data.ORM;
using EAS.Data.Access;
using EAS.Modularization;

using EAS;
using EAS.Services;
using EAS.Data.Linq;

using Gas_test2.Entities;

using Gas_test2.BLL;

namespace Gas_test2.WinUI
{
    [Module("E5BD5566-25F7-493C-9463-02E123E4FC87", "算法文件配置", "FunctionList")]
    
    public partial class FileConfig : UserControl
    {
        private DataSet dataset = new DataSet();
        
        public FileConfig()
        {
            InitializeComponent();
        }

        [ModuleStart]
        public void StartEx()
        {

        }

        private void FileConfig_Load(object sender, EventArgs e)
        {
            lbox_Type.Items.Clear();
            dataset = ServiceContainer.GetService<IGasDAL>().QueryTable("AlgName", "AlgTypeAbl");
            lbox_Type.Items.Add(dataset.Tables[0].Rows[1]);

            textBox1.Clear();
            textBox2.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            FormView.AddAlgorithm addalg = new FormView.AddAlgorithm();
            addalg.Show();
            addalg.Dispose();

            lbox_Type.Items.Clear();
            dataset = ServiceContainer.GetService<IGasDAL>().QueryTable("AlgName", "AlgTypeAbl");
            lbox_Type.Items.Add(dataset.Tables[0].Rows[1]);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            FormView.AddAlgorithm addalg = new FormView.AddAlgorithm();
            addalg.Show();
            addalg.Dispose();
            
            ////update表数据
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            lbox_Type.Items.RemoveAt(lbox_Type.SelectedIndex);
            /////删除一行数据

            dataset.Clear();
            lbox_Type.Items.Clear();
            dataset = ServiceContainer.GetService<IGasDAL>().QueryTable("AlgName", "AlgTypeAbl");
            lbox_Type.Items.Add(dataset.Tables[0].Rows[1].ToString());
        }

        private void btn_Browse1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName; //得到文件名 
                textBox1.Text = fileName;
            }
        }

        private void btn_Browse2_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName; //得到文件名 
                textBox2.Text = fileName;
            }
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            ////update表数据
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }











    }
}
