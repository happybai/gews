﻿using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using LibEntity;
using LibCommon;
using LibCommonForm;
using LibConfig;
using System.IO;
using System.Reflection;
using System.Threading;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;
using Castle.ActiveRecord.Framework.Config;

namespace LibLoginForm
{
    public partial class LoginForm : Form
    {
        //获取曾经登录用户的信息
        private UserLogin[] entsLogined = null;

        //获取所有的用户信息
        private UserLogin[] ents = null;

        private string Path { get; set; }

        Form _showForm = null;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="form2ShowAfterLogin"></param>
        /// <param name="path"></param>
        public LoginForm(Form form2ShowAfterLogin, string path)
        {
            InitializeComponent();
            _showForm = form2ShowAfterLogin;
            Path = path;
            //SkinReader sr = new SkinReader();
            //string sn = sr.ReadCurSkin();
            //skinEngine1.SkinFile = Application.StartupPath + "\\skin\\" + sn;
            //skinEngine1.SkinAllForm = true;
        }

        /// <summary>
        /// 窗体登录事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture =
             new CultureInfo("zh-Hans");
            Thread.CurrentThread.CurrentCulture =
                new CultureInfo("zh-Hans");
            IConfigurationSource config = new XmlConfigurationSource("ARConfig.xml");
            var asm = Assembly.Load("LibEntity");
            ActiveRecordStarter.Initialize(asm, config);

            BitmapRegion.CreateControlRegion(this, new Bitmap(Path));

            try
            {
                ents = UserLogin.FindAll();
            }
            catch (Exception ex)
            {
                throw;
            }
            //获取所有用户信息


            //添加已记录的登录用户
            entsLogined = UserLogin.FindAllByIsLogined(0);
            foreach (UserLogin ent in entsLogined)
            {
                _cbxUserName.Items.Add(ent.LoginName);
            }

            //默认显示第一个用户，应改成默认选择最后一个登录用户。
            //可采用表中记录登录时间来实现。为减少修改量，未采用修改数据表结构。
            //采用读取配置文件的方法。记录信息在DefaultUser           
            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\DefaultUser");
                string str = sr.ReadLine();
                sr.Close();

                //赋值同时，触发_cbxUserName_SelectedIndexChanged事件，符合记住密码的用户名，自动赋值
                _cbxUserName.SelectedItem = (object)str;
            }
            catch (System.Exception ex)
            {
                Alert.alert(ex.Message);
            }
        }

        /// <summary>
        /// 确定登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {

            bool status = false;

            string userName = this._cbxUserName.Text;
            string password = this._txtPassword.Text;

            UserLogin[] ents = UserLogin.FindAll();
            //数据库中无用户名及密码信息
            if (ents == null)
            {
                LibCommon.Const.FIRST_TIME_LOGIN = true;
                status = false;
                Alert.alert(Const.ADD_USER_INFO, Const.LOGIN_FAILED_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);

                UserLogin ent = new UserLogin();
                ent.LoginName = _cbxUserName.Text.ToString();
                ent.PassWord = _txtPassword.Text;

                //显示添加用户信息界面，确定后将新创建的用户名及密码自动填写到相应控件上
                UserLoginInformationInput ulii = new UserLoginInformationInput(ent);
                ulii.ShowDialog();
                if (LibCommon.Const.FIRST_LOGIN_NAME != "")
                {
                    _cbxUserName.Text = LibCommon.Const.FIRST_LOGIN_NAME;
                    _txtPassword.Text = LibCommon.Const.FIRST_LOGIN_PASSWORD;
                    LibCommon.Const.FIRST_TIME_LOGIN = false;
                    //buttonOk_Click(sender, e);//添加成功用户后，自动登陆系统
                }
            }
            else
            {
                //验证帐号密码是否正确
                if (LoginSuccess(userName, password))
                {
                    status = true;
                }
                else
                {
                    Alert.alert(Const.USER_NAME_OR_PWD_ERROR_MSG, Const.LOGIN_FAILED_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (status)
            {
                this.Hide();
                _showForm.WindowState = FormWindowState.Maximized;

                _showForm.ShowDialog();
            }

        }

        /// <summary>
        /// 登录成功
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        private bool LoginSuccess(string userName, string password)
        {
            //定义记录登录成功与否的值
            bool isLogin = false;
            var userLogin = UserLogin.FindOneByLoginNameAndPassword(userName, password);
            if (userLogin != null)
            {
                //set CurrentUser
                CurrentUser.CurLoginUserInfo = userLogin;

                //记录最后一次登录用户
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\DefaultUser", false);
                sw.WriteLine(userName);
                sw.Close();

                //记住密码,登录成功，修改用户“尚未登录”为False；根据是否记住密码设定相应的值
                userLogin.IsSavePassWord = Convert.ToInt32(_chkSavePassword.Checked);
                userLogin.Save();
                ConfigManager.Instance.add(ConfigConst.CONFIG_CURRENT_USER, userName);
                isLogin = true;
            }
            return isLogin;
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 用户名选择变化时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _cbxUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strSelLoginName = _cbxUserName.Text;
            foreach (UserLogin ent in ents)
            {
                if (strSelLoginName == ent.LoginName)
                {
                    //验证是否记住密码,并赋予相应的值
                    _chkSavePassword.Checked = ent.IsSavePassWord != 0;
                    _txtPassword.Text = ent.IsSavePassWord == 1 ? ent.PassWord : "";
                    //设置焦点
                    if (ent.IsSavePassWord == 1)
                    {
                        buttonOk.Focus();
                    }
                    else
                    {
                        _txtPassword.Focus();
                    }
                    break;
                }
            }
        }
    }
}
