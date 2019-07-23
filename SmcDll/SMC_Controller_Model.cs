using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMC.Controller.Ult;

namespace SMC.Model.Controller
{

    /* 移动轴类型定义 */
    public enum AXIS_TYPE_E
    {
        //AXIS_X = 1,
        //AXIS_V = 2,
        //AXIS_Z = 4,
        //AXIS_U = 8,
        //AXIS_Y = 16,
        //AXIS_W = 32

        AXIS_Y = 1,
        AXIS_V = 2,
        AXIS_X = 4,
        AXIS_Z = 8,
        AXIS_U = 16,
        AXIS_W = 32
    }

    /*程序运行模式*/
    public enum PROGRAM_WORK_MODE_E
    {
        WORK_MODE_PROGRAM = 1,       /* 程序运行模式 */
        WORK_MODE_COMMAND = 2,       /* PC命令执行方式 */
        WORK_MODE_DOWN = 3,       /* 应用程序下载 */
        WORK_MODE_STEP = 4        /* 单步仿真模式 */
    }

    /*速度*/
    public class Axis
    {
        //轴类型
        AXIS_TYPE_E axisType;
        //细分
        private uint driveDiv;
        public uint DriveDiv
        {
            get
            {
                return driveDiv;
            }
            set
            {
                driveDiv = value;
            }
        }
     
        //加速
        private uint acc;
        public uint Acc
        {
            get
            {
                return acc;
            }
            set
            {
                acc = value;
            }
        }
    
        //减速
        private uint dec;
        public uint Dec
        {
            get
            {
                return dec;
            }
            set
            {
                dec = value;
            }
        }
    
        //节径（就是电机转一圈移动的距离）
        private float pitch;
        public float Pitch
        {
            get
            {
                return pitch;
            }
            set
            {
                pitch = value;
            }
        }
    
        //最小速度
        private float minSpeed;
        public float MinSpeed
        {
            get
            {
                return minSpeed;
            }
            set
            {
                minSpeed = value;
            }
        }

        //最大速度
        private float maxSpeed;
        public float MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                maxSpeed = value;
            }
        }


        //构造函数
        public Axis(AXIS_TYPE_E axisType, uint driveDiv, uint acc, uint dec
            , float pitch, float minSpeed, float maxSpeed)

        {
            this.driveDiv = driveDiv;
            this.acc = acc;
            this.dec = dec;
            this.pitch = pitch;
            this.minSpeed = minSpeed;
            this.maxSpeed = maxSpeed;
            this.axisType = axisType;
        }


        //类的克隆，返回个相同的实例化对象
        public Axis Clone(AXIS_TYPE_E axisType)
        {
            Axis axis = new Axis(axisType, this.DriveDiv, this.Acc, this.Dec, this.Pitch,
              this.MinSpeed, this.MaxSpeed);
            return axis;
        }


        //激活轴
        public void Activate()
        {
            int rev;
            rev = Ult.SMC_SetMotorDriveDiv(SMC_Controller_Model.ADDR, axisType, driveDiv);
            rev = Ult.SMC_SetMotorPitch(SMC_Controller_Model.ADDR, axisType, pitch);
            rev = Ult.SMC_SetMotorAcc(SMC_Controller_Model.ADDR, axisType, acc);
            rev = Ult.SMC_SetMotorDec(SMC_Controller_Model.ADDR, axisType, dec);
            rev = Ult.SMC_SetMotorMaxSpeed(SMC_Controller_Model.ADDR, axisType, maxSpeed);
            rev = Ult.SMC_SetMotorMinSpeed(SMC_Controller_Model.ADDR, axisType, minSpeed);
        }


        //复位
        public void Reset(byte ADDR = SMC_Controller_Model.ADDR)
        {
            if (axisType == AXIS_TYPE_E.AXIS_Y)
                Ult.SMC_ManualRightMove(ADDR, axisType);//连续左行
            else
                Ult.SMC_ManualLeftMove(ADDR, axisType);//连续左行
            byte Zero = 0;
            switch (axisType)
            {
                case
                    AXIS_TYPE_E.AXIS_X:
                    Zero = SMC_Controller_Model.XZERO;
                    break;
                case
                    AXIS_TYPE_E.AXIS_Y:
                    Zero = SMC_Controller_Model.YZERO;
                    break;
                case
                    AXIS_TYPE_E.AXIS_Z:
                    Zero = SMC_Controller_Model.ZZERO;
                    break;
            }
            while (!SMC.Controller.SMCController.IsZERO(ADDR, Zero))
            {
                System.Threading.Thread.Sleep(5);
            }
            Ult.SMC_QuickStopMotor(ADDR, AXIS_TYPE_E.AXIS_X);//停止X轴          
            //TODO:降低电机速度
            if (axisType == AXIS_TYPE_E.AXIS_Y)
                Ult.SMC_ManualLeftMove(ADDR, axisType);//连续左行
            else
                Ult.SMC_ManualRightMove(ADDR, axisType);//连续左行
            while (!SMC.Controller.SMCController.IsZERO(ADDR, Zero))
            {
                System.Threading.Thread.Sleep(5);
            }

            Ult.SMC_QuickStopMotor(ADDR, axisType);//停止X轴
            Ult.SMC_ClearMotorPosition(ADDR, axisType);//清除坐标

        }


        //停止
        public void StopMove()
        {
            Ult.SMC_QuickStopMotor(SMC_Controller_Model.ADDR, axisType);
        }


        //向右运动（正方向）
        public void MoveRight()
        {
            Ult.SMC_ManualRightMove(SMC_Controller_Model.ADDR, axisType);
        }


        //向左运动（负方向）
        public void MoveLeft()
        {
            Ult.SMC_ManualLeftMove(SMC_Controller_Model.ADDR, axisType);
        }


        //相对运动
        public void MoveTo(float delt,byte ADDR = SMC_Controller_Model.ADDR)
        {
            Ult.SMC_MotorMove(ADDR, axisType, delt);
            //如果满足精度要求 退出

            //下面是如果不满足精度要求的补偿措施
            //TODO:..

        }


        public float GetCurrentPos(float target,byte ADDR = SMC_Controller_Model.ADDR)
        {
            float current;
            Ult.SMC_GetMotorPosition(ADDR, axisType, out current);
            return current - target;// Math.Abs();
        }

        //设置轴当前为原点
        public void ClearMotorPosition()
        {
            Ult.SMC_ClearMotorPosition(SMC_Controller_Model.ADDR, axisType);
        }


    }


    /*控制器模型*/
    public class SMC_Controller_Model
    {
        public const byte ADDR = 0;//控制器地址
        public const float Error = 0.1f;//误差允许
        public const byte INBASE = 0;
        public const byte YZERO = INBASE + 2;
        public const byte UZERO = INBASE + 1;
        public const byte XZERO = INBASE + 3;
        public const byte ZZERO = INBASE + 4;
        //需要在构造函数中初始化的值
        public byte COM_NUM = 7;       //串口号
        public Axis AXIS_X;      //X轴速度
        public Axis AXIS_Y;      //Y轴速度
        public Axis AXIS_Z;      //Z轴速度
        public Axis AXIS_U;      //U轴速度


        //构造函数
        public SMC_Controller_Model(byte COM_NUM)
        {
            this.COM_NUM = COM_NUM;
            AXIS_X = new Axis(AXIS_TYPE_E.AXIS_X, 1600, 10, 10, 45, 0, 27);
            AXIS_Y = new Axis(AXIS_TYPE_E.AXIS_Y, 1600, 10, 10, 10, 0, 30);    //电机减速比17，齿轮 200齿数：33齿数//一周360   360/（17*200/33)
            AXIS_Z = new Axis(AXIS_TYPE_E.AXIS_Z, 6400, 10, 10, 360, 0, 30);
            AXIS_U = new Axis(AXIS_TYPE_E.AXIS_U, 1600, 10, 10, 3.495f, 0, 15);

        }
    }
}

