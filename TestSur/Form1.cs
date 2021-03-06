﻿using System;
using System.Data;
using System.Windows.Forms;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Net.NetworkInformation;
using System.Net;


namespace TestSur
{
    using HoraceOriginal;//添加引用WCFError错误类
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.IclClient sc = new ServiceReference2.IclClient();
            using (sc as IDisposable)//避免在捕获后sc因为被释放，不能更新信道
            {
                try
                {

                    DataSet DS = new DataSet();
                    DS = sc.GetServer("001");

                }
                catch (System.ServiceModel.FaultException<TestSur.ServiceReference2.WCFError> ex)
                {
                    MessageBox.Show(ex.Message);
                    (sc as ICommunicationObject).Abort();//请不要用Close()！！！
                }                                        //请不要用Close()！！！
            }                                            //请不要用Close()！！！

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference2.IclClient ping = new ServiceReference2.IclClient();
            using (ping as IDisposable)
            {
                try
                {

                    string serid = "1";
                    IPAddress Address = new IPAddress(new byte[] { 202, 115, 74, 254 });//TODO:Select IPAdress from database according to the serverid
                    long RtT = 0;//实例化参数
                    int Ttl = 0;
                    bool DF = true;
                    int BfL = 32;
                    int i = ping.PingSer(serid, Address, ref RtT, ref Ttl, DF, ref BfL);//调用Ping，返回结果
                    if (i == 0)
                    {
                        MessageBox.Show("成功：" + Address.ToString() + "," + "RtT:" + RtT.ToString() + "Ttl:" + Ttl.ToString());


                    }
                    else
                    {
                        MessageBox.Show("失败");
                    }
                }

                catch (System.ServiceModel.FaultException<TestSur.ServiceReference2.WCFError> ex)
                {
                    MessageBox.Show(ex.Message);
                    (ping as ICommunicationObject).Abort();
                }
            }
        }
    }
}
namespace HoraceOriginal
{
    [DataContractAttribute(Namespace = "Horace")]
    public class WCFError 
    {
        public WCFError(string operation, string message)
        {
            if (string.IsNullOrEmpty(operation))
            {
                throw new ArgumentNullException("operation");
            }
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentNullException("message");
            }

            Operation = operation;
            this.Message = message;
        }
        [DataMember]
        public string Operation
        { get; set; }
        [DataMember]
        public string Message
        { get; set; }
    }

}