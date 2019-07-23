using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMC.Model.Controller;
using System.IO.Ports;
using SMC.Controller.Ult;
namespace SMC.Controller
{
    public class SMCController
    {
        static SMC_Controller_Model currentModel;
        static bool SeraPortIsOpen = false;


        //扫描所有串口
        public static string[] ScanSeraPort()
        {
            string[] ports = SerialPort.GetPortNames();
            return ports;
        }


        /// <summary>
        /// 连接并初始化控制器
        /// </summary>
        public static void Connect_Controller(SMC_Controller_Model model)
        {          
            currentModel = model;
            //[1]设置控制器工作模式       
            Ult.Ult.SMC_GlobalInit();//全局初始化
            Ult.Ult.SMC_OpenSericalPort(model.COM_NUM);//打开串口
            Ult.Ult.SMC_SetWorkMode(SMC_Controller_Model.ADDR, PROGRAM_WORK_MODE_E.WORK_MODE_COMMAND, 0);//工作模式二 具体参考.h文件/* PC命令执行方式 */
            model.AXIS_X.Activate();
            model.AXIS_Y.Activate();
            model.AXIS_Z.Activate();
            model.AXIS_U.Activate();
            //TODO:复位
            SeraPortIsOpen = true;
        }


        //关闭控制器
        public static void Close_Controller()
        {
            if (SeraPortIsOpen)
            {
                Ult.Ult.SMC_CloseSericalPort();
                Ult.Ult.SMC_GlobalRelease();
                SeraPortIsOpen = false;
            }
        }


        //判断是否到达0点
        public static bool IsZERO(byte ADDR,byte ZERO)
        {
            bool Key;
            Ult.Ult.SMC_GetIOPinLevel(ADDR, ZERO, out Key);
            return !Key;
        }


        //复位
        public static void Reset(byte ADDR= SMC_Controller_Model.ADDR)

        {
            bool Xzero = false;
            bool Yzero = false;
            bool Zzero = false;
            Ult.Ult.SMC_ManualLeftMove(ADDR, AXIS_TYPE_E.AXIS_X);//连续左行
            Ult.Ult.SMC_ManualRightMove(ADDR, AXIS_TYPE_E.AXIS_Y);//连续左行
            Ult.Ult.SMC_ManualLeftMove(ADDR, AXIS_TYPE_E.AXIS_Z);//连续左行

            while (true)
            {
                if (IsZERO(ADDR, SMC_Controller_Model.XZERO))
                {
                    Ult.Ult.SMC_QuickStopMotor(ADDR, AXIS_TYPE_E.AXIS_X);
                    Xzero = true;
                }
                System.Threading.Thread.Sleep(5);
                if (IsZERO(ADDR, SMC_Controller_Model.YZERO))
                {
                    Ult.Ult.SMC_QuickStopMotor(ADDR, AXIS_TYPE_E.AXIS_Y);
                    Yzero = true;
                }

                if (IsZERO(ADDR, SMC_Controller_Model.ZZERO))
                {
                    Ult.Ult.SMC_QuickStopMotor(ADDR, AXIS_TYPE_E.AXIS_Z);
                    Zzero = true;
                }

                if (Xzero && Yzero && Zzero) break;
            }
            //TODO:降低各个轴的速度

            Ult.Ult.SMC_ManualRightMove(ADDR, AXIS_TYPE_E.AXIS_X);//连续行
            Ult.Ult.SMC_ManualLeftMove(ADDR, AXIS_TYPE_E.AXIS_Y);//连续
            Ult.Ult.SMC_ManualRightMove(ADDR, AXIS_TYPE_E.AXIS_Z);//连续

            while (true)
            {

                if (!IsZERO(ADDR, SMC_Controller_Model.XZERO))
                {
                    Ult.Ult.SMC_QuickStopMotor(ADDR, AXIS_TYPE_E.AXIS_X);
                    Xzero = false;
                }

                if (!IsZERO(ADDR, SMC_Controller_Model.YZERO))
                {
                    Ult.Ult.SMC_QuickStopMotor(ADDR, AXIS_TYPE_E.AXIS_Y);
                    Yzero = false;
                }

                if (!IsZERO(ADDR, SMC_Controller_Model.ZZERO))
                {
                    Ult.Ult.SMC_QuickStopMotor(ADDR, AXIS_TYPE_E.AXIS_Z);
                    Zzero = false;
                }

                if ((!Xzero) && (!Yzero) && (!Zzero)) break;

            }

            Ult.Ult.SMC_ClearMotorPosition(ADDR, AXIS_TYPE_E.AXIS_X);//清除坐标
            Ult.Ult.SMC_ClearMotorPosition(ADDR, AXIS_TYPE_E.AXIS_Y);//清除坐标
            Ult.Ult.SMC_ClearMotorPosition(ADDR, AXIS_TYPE_E.AXIS_Z);//清除坐标
            Ult.Ult.SMC_ClearMotorPosition(ADDR, AXIS_TYPE_E.AXIS_U);//清除坐标
        }


        //急停
        public static void Stop()
        {
            currentModel.AXIS_X.StopMove();
            currentModel.AXIS_Y.StopMove();
            currentModel.AXIS_Z.StopMove();
            currentModel.AXIS_U.StopMove();
        }

    }
}
