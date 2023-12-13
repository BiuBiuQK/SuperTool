using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SuperTool.Common
{
    /// <summary>
    /// ini配置文件增删改查
    /// 调用的是win32的api，所以只在windows下有效
    /// 微软官方文档参考 https://learn.microsoft.com/zh-cn/windows/win32/api/winbase/nf-winbase-getprivateprofileint
    /// </summary>
    public class IniService
    {
        /*
         * 1)private 不是必需的,根据设计了,public也可以.
         * 2)extern 关键字表示该方法是要调用非托管代码.如果使用extern关键字来引入非托管代码,则必须也同时使用static.为什么要用static,是因为你调用非托管代码,总得有个入口点吧,那么你声明的这个GetPrivateProfileString方法就是你要调用的非托管代码的入口.想想Main函数,是不是也必须是static呢.
         * 3) 为什么要用long，我看也有小伙伴也有用int的，估计是long支持的更多位数
         */
        [DllImport("kernel32")]// 读配置文件方法的6个参数：所在的分区（section）、 键值、     初始缺省值、   StringBuilder、  参数长度上限 、配置文件路径
        public static extern long GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32")]//写入配置文件方法的4个参数：  所在的分区（section）、  键值、     参数值、       配置文件路径
        private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);
        [DllImport("kernel32")]
        private extern static int WritePrivateProfileSection(string segName, string sValue, string fileName);


        public string IniFile { get; set; }
        public int BufferSize { get; set; }//默认设置了1024，如果有配置项里有比较大的数据配置项，这个值需要调大，外部可以重新赋值改

        public IniService(string iniFile)
        {
            IniFile = iniFile;
            BufferSize = 1024;
        }

        /// <summary>
        /// 读ini配置
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public string ReadIniData(string section, string key)
        {
            if (!File.Exists(IniFile)) { return ""; }

            StringBuilder retVal = new StringBuilder(BufferSize);
            GetPrivateProfileString(section, key, "", retVal, BufferSize, IniFile);

            return retVal.ToString();
        }

        /// <summary>
        /// 写ini配置
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool WriteIniData(string section, string key, string value)
        {
            long res = WritePrivateProfileString(section, key, value, IniFile);
            if (res == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 删除某个配置
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool DeleteIniData(string section, string key)
        {
            return WriteIniData(section, key, null!);
        }

        /// <summary>
        /// 删除配置节点整段
        /// </summary>
        /// <param name="section"></param>
        /// <returns></returns>
        public bool DeleteSection(string section)
        {
            int res = WritePrivateProfileSection(section, null!, IniFile);
            if (res == 0)
                return false;
            else
                return true;
        }

        public bool ExistIniFile()
        {
            return File.Exists(IniFile);
        }
        public bool ExistIniFile(string iniFile)
        {
            return File.Exists(iniFile);
        }


    }
}
