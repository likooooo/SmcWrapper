using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using SMC.Model.Controller;

namespace SMC.Controller.Ult
{
    /*Adhon_SMC_48MT6.dll的外部调用*/
    class Ult
    {
        /// <summary>
        /// 控制器全局初始化
        /// </summary>
        /// <returns>初始化是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_GlobalInit();

        /// <summary>
        /// 控制器全局资源释放函数
        /// </summary>
        /// <returns>释放资源是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_GlobalRelease();

        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="iPort">需要打开的串口编号</param>
        /// <returns>打开端口是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_OpenSericalPort(int iPort);

        /// <summary>
        /// 关闭串口
        /// </summary>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern void SMC_CloseSericalPort();

        /// <summary>
        /// 将用户程序下载到SDK中
        /// </summary>
        /// <param name="pucProgramData">应用程序起始地址</param>
        /// <param name="usUserProgramLines">应用程序代码行</param>
        /// <returns></returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_GetControllerVersion(byte pucProgramData, UInt32 usUserProgramLines);

        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_SetWorkMode(byte ucControllerAddr, PROGRAM_WORK_MODE_E enWorkMode, byte ucProgramIndex);

        /// <summary>
        /// 设置控制器地址
        /// 使用SDK接口编程方式下，可以调整控制器地址，调整后可以使用modbus协议进行多级通信
        /// 使用SDK方式暂时不支持多机通信，因此左右指令中的控制器地址填写为0x0ff
        /// </summary>
        /// <param name="ucControllerAddr">控制器原地址</param>
        /// <param name="ucNewControllerAddr">控制器新地址</param>
        /// <returns></returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_SetControllerAddr(byte ucControllerAddr, byte ucNewControllerAddr);

        /// <summary>
        /// 获取控制器地址
        /// </summary>
        /// <param name="pucControllerAddr">获取控制器地址</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_GetControllerAddr(out byte pucControllerAddr);

        /// <summary>
        /// 暂停控制器运行
        /// 调用该函数，控制器的电机会停止，一般作为急停使用
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_PauseController(byte ucControllerAddr);

        /// <summary>
        /// 回复控制器继续运行
        /// 暂停情况下，控制器恢复继续运行
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_ContinueController(byte ucControllerAddr);

        /// <summary>
        /// 用于对控制器上的蜂鸣器进行验证，验收控制器硬件是否正常
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="ulBeepTimeMs">蜂鸣器鸣叫时间，单位为ms</param>
        /// <returns></returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_Beeper(byte ucControllerAddr, UInt32 ulBeepTimeMs);

        /// <summary>
        /// 在指定端口上输出高电平
        /// 将控制器指定的输出口上面输出指定的电平值，如可以用于控制器外部继电器等
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="ucOutputNo">输出端口号</param>
        /// <param name="bHLevel">输出的电平值</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_SetIOPinLevel(byte ucControllerAddr, byte ucOutputNo, bool bHLevel);

        /// <summary>
        /// 读取输入端口的状态信息
        /// 用于检测输入口是否有信号到来
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="ucOutputNo">输入端口电平值(从低位到高位依次为:X0-X5,IN1-IN6)</param>
        /// <param name="pbHLevelunsigned"></param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_GetIOPinLevel(byte ucControllerAddr, byte ucOutputNo, out bool pbHLevelunsigned);

        /// <summary>
        /// 设置驱动器细分数
        /// 设置步进电机转动一圈需要的脉冲数，一般由步进电机驱动器或者伺服电机驱动器决定
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作的轴</param>
        /// <param name="ulDriverDiv">驱动器细分数</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_SetMotorDriveDiv(byte ucControllerAddr, AXIS_TYPE_E enAxisType, UInt32 ulDriverDiv);

        /// <summary>
        /// 获取驱动器细分数
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作的轴</param>
        /// <param name="pulDriverDiv">驱动器细分数</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_GetMotorDriveDiv(byte ucControllerAddr, AXIS_TYPE_E enAxisType, out UInt32 pulDriverDiv);

        /// <summary>
        /// 设置前进的螺距 
        /// 设置步进电机螺距，指步进电机转动一圈移动的实际距离
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作的轴</param>
        /// <param name="fPitch">螺距</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_SetMotorPitch(byte ucControllerAddr, AXIS_TYPE_E enAxisType, float fPitch);

        /// <summary>
        /// 获取前进的螺距
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作的轴</param>
        /// <param name="pfPitch">螺距</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_GetMotorPitch(byte ucControllerAddr, AXIS_TYPE_E enAxisType, out float pfPitch);

        /// <summary>
        /// 设定电机加速系数
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作的轴</param>
        /// <param name="ulAccPar">加速系数(值越大加速时间越长)</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_SetMotorAcc(byte ucControllerAddr, AXIS_TYPE_E enAxisType, UInt32 ulAccPar);

        /// <summary>
        /// 获取电机加系数
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作的轴</param>
        /// <param name="pulUserAccPar">电机加速系数</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_GetMotorAcc(byte ucControllerAddr, AXIS_TYPE_E enAxisType, out UInt32 pulUserAccPar);

        /// <summary>
        /// 设定电机减速系数
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作的轴</param>
        /// <param name="ulDecPar">减速系数(数值越大减速时间越长)</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_SetMotorDec(byte ucControllerAddr, AXIS_TYPE_E enAxisType, UInt32 ulDecPar);

        /// <summary>
        /// 获取电机减速系数
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作的轴</param>
        /// <param name="pulUserDecPar">电机减速系数</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_GetMotorDec(byte ucControllerAddr, AXIS_TYPE_E enAxisType, out UInt32 pulUserDecPar);

        /// <summary>
        /// 设置轴运行最大速度
        /// 指定步进电机运行速度(eg: 细分数为1600, 螺距是2mm, 这边的速度为10, 即10mm/s
        /// 等电机运行稳定后，电机每秒钟就运行10mm距离，也就是5圈每秒，也就是8000Hz/s的频率输出)
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作轴</param>
        /// <param name="fMaxMotorSpeed">最大速度</param>
        /// <returns></returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_SetMotorMaxSpeed(byte ucControllerAddr, AXIS_TYPE_E enAxisType, float fMaxMotorSpeed);

        /// <summary>
        /// 设置轴最小运行速度
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作轴</param>
        /// <param name="fMinMotorSpeed">最小速度</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_SetMotorMinSpeed(byte ucControllerAddr, AXIS_TYPE_E enAxisType, float fMinMotorSpeed);

        /// <summary>
        /// 获取步进电机的当前速度
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作轴</param>
        /// <param name="pfMotorSpeed">当前速度</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_GetMotorCurSpeed(byte ucControllerAddr, AXIS_TYPE_E enAxisType, out float pfMotorSpeed);

        /// <summary>
        /// 设置步进电机相对运行距离
        /// 相对移动是以当前位置为参考点，移动多少距离，如MoveDist填写10，表示正向移动10mm，如果填写-10，表示反向移动10mm。
        /// 这边不是实际移动的目的坐标，如果是目的坐标请调用SMC_MotorGoPos函数
        /// </summary>
        /// <param name="ucControllerAddr"></param>
        /// <param name="enAxisType"></param>
        /// <param name="fMoveDist"></param>
        /// <returns></returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_MotorMove(byte ucControllerAddr, AXIS_TYPE_E enAxisType, float fMoveDist);

        /// <summary>
        /// 步进电机手动左移
        /// 表示电机一直向正向运行，不需要停止
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作轴</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_ManualLeftMove(byte ucControllerAddr, AXIS_TYPE_E enAxisType);

        /// <summary>
        /// 步进电机手动右移
        /// 表示电机一直向反向运行，不需要停止
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作轴</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_ManualRightMove(byte ucControllerAddr, AXIS_TYPE_E enAxisType);

        /// <summary>
        /// 设置步进电机运行位置
        /// 将指定的轴移动到指定的位置处，移动的单位同设置的螺距单位一致
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作轴</param>
        /// <param name="fPostion">绝对坐标</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_MotorGoPos(byte ucControllerAddr, AXIS_TYPE_E enAxisType, float fPostion);

        /// <summary>
        /// 快速停止某个电机的运行
        /// 表示指定电机进行急停
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作轴</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_QuickStopMotor(byte ucControllerAddr, AXIS_TYPE_E enAxisType);

        /// <summary>
        /// 平稳停止某个电机运行
        /// 表示指定电机进行减速停止
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作轴</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_SlowStopMotor(byte ucControllerAddr, AXIS_TYPE_E enAxisType);

        /// <summary>
        /// 判断某个电机是否在运行
        /// 用于检测指定的电机是否在运行
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作轴</param>
        /// <param name="pbIsRunning">是否运行标志位</param>
        /// <returns>某个电机是否在运行</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_MotorIsRunning(byte ucControllerAddr, AXIS_TYPE_E enAxisType, out bool pbIsRunning);

        /// <summary>
        /// 将当前位置设置为零点位置
        /// 将当前电机绝对坐标进行清空，一般设备矫正完成后使用
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType">操作轴</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_ClearMotorPosition(byte ucControllerAddr, AXIS_TYPE_E enAxisType);

        /// <summary>
        /// 获取当前位置
        /// </summary>
        /// <param name="ucControllerAddr">操作轴地址</param>
        /// <param name="enAxisType">操作轴</param>
        /// <param name="pfMotorPostion">当前位置</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_GetMotorPosition(byte ucControllerAddr, AXIS_TYPE_E enAxisType, out float pfMotorPostion);

        /// <summary>
        /// 进行XY平面直线插补
        /// 使用改指令选择2轴直线插补，3轴直线插补，圆弧插补的平面
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="enAxisType1">直线插补的平面1</param>
        /// <param name="enAxisType2">直线插补的平面2</param>
        /// <param name="enAxisType3">直线插补的平面3</param>
        /// <returns></returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_SetOperateAxisPlane(byte ucControllerAddr, AXIS_TYPE_E enAxisType1, AXIS_TYPE_E enAxisType2, AXIS_TYPE_E enAxisType3);

        /// <summary>
        /// 设置直线插补与圆环插补的速度
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="fCombineSped">直线插补与圆环插补的合成速度控制</param>
        /// <returns>设置直线插补与圆环插补速度是否正确</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_SetCombineSpeed(byte ucControllerAddr, float fCombineSped);

        /// <summary>
        /// 进行XY平面直线插补
        /// 相对直线插补，表示以当前坐标为参考点，相对移动指定距离，正数表示正向移动，负数表示反向移动
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="fAxis1">X轴相对移动的X坐标</param>
        /// <param name="fAxis2">Y轴相对移动的Y坐标</param>
        /// <returns>操作是否成功，移动成功的为从当前位置再叠加后的位置值</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_Line2Move(byte ucControllerAddr, float fAxis1, float fAxis2);

        /// <summary>
        /// XY平面直线插补
        /// 绝对直线插补，表示将电机移动到指定的位置处
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="fAxis1">移动到X轴的坐标</param>
        /// <param name="fAxis2">移动到Y轴的坐标</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_Line2Goto(byte ucControllerAddr, float fAxis1, float fAxis2);

        /// <summary>
        /// XYZ平面直线插补
        /// 相对直线插补，表示以当前坐标为参考点，相对移动指定距离，正数表示正向移动，负数表示反向移动
        /// </summary>
        /// <param name=""></param>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="fAxis1">X轴相对移动的X坐标</param>
        /// <param name="fAxis2">Y轴相对移动的Y坐标</param>
        /// <param name="fAxis3">Z轴相对移动的Z坐标</param>
        /// <returns>操作是否成功，移动成功的为从当前位置再叠加后的位置值</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_Line3Move(byte ucControllerAddr, float fAxis1, float fAxis2, float fAxis3);

        /// <summary>
        /// XYZ平面直线插补
        /// 绝对直线插补，将电机移动到指定的位置处
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="fAxis1">X轴坐标</param>
        /// <param name="fAxis2">Y轴坐标</param>
        /// <param name="fAxis3">Z轴坐标</param>
        /// <returns>操作是否成功，移动成功的为从当前位置再叠加后的位置值</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_Line3Goto(byte ucControllerAddr, float fAxis1, float fAxis2, float fAxis3);

        /// <summary>
        /// XY平面两点与半径进行圆弧插补(顺时针)
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="fCircleRadius">圆弧半径</param>
        /// <param name="fAxis1Pos">目标X轴位置</param>
        /// <param name="fAxis2Pos">目标Y轴位置</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_CircleMoveG2_Pos(byte ucControllerAddr, float fCircleRadius, float fAxis1Pos, float fAxis2Pos);

        /// <summary>
        /// XY平面圆心与半径进行圆弧插补(逆时针)
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="fAngle">转动角度</param>
        /// <param name="fAxis1CenterPos">圆心X轴坐标</param>
        /// <param name="fAxis2CenterPos">圆心Y轴坐标</param>
        /// <returns></returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_CircleMoveG3_Pos(byte ucControllerAddr, float fAngle, float fAxis1CenterPos, float fAxis2CenterPos);

        /// <summary>
        /// XY平面角度与圆心进行圆弧插补(顺时针)
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="fAngle">转动角度</param>
        /// <param name="fCenterPos1">圆心轴坐标1</param>
        /// <param name="fCenterPos2">圆心轴坐标2</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_CircleMoveG2_Angle(byte ucControllerAddr, float fAngle, float fCenterPos1, float fCenterPos2);

        /// <summary>
        /// XY平面角度与圆心进行圆弧插补(逆时针)
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="fAngle">圆弧半径</param>
        /// <param name="fCenterPos1">圆心轴坐标1</param>
        /// <param name="fCenterPos2">圆心轴坐标2</param>
        /// <returns>操作是否成功</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_CircleMoveG3_Angle(byte ucControllerAddr, float fAngle, float fCenterPos1, float fCenterPos2);

        /*=======================================================
                标准外设操作指令
        ========================================================*/

        /// <summary>
        /// 设置电位器的控制方式
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="ucADNo">指定准备对那个电位器进行设置</param>
        /// <param name="enControlForType">电位器的控制方式</param>
        /// <returns>无返回</returns>
        //[DllImport("Adhon_SMC_48MT6.dll")]
        // public static extern int SMC_SetADWorlMode(byte ucControllerAddr, byte ucADNo, CONTROL_FOR_TYPE_E enControlForType);

        /// <summary>
        /// 设定电位器的范围
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="ucADNo">指定对那个电位器进行设置</param>
        /// <param name="fMinADValue">电位器对应的最小值</param>
        /// <param name="fMaxADValue">电位器对应的最大值</param>
        /// <returns>无返回</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_SetADValueScale(byte ucControllerAddr, byte ucADNo, float fMinADValue, float fMaxADValue);

        /// <summary>
        /// 读取指定电位器的值，已经根据设定的范围进行转换后的值
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="ucADNo">需要读取那个电位器的值</param>
        /// <returns>无返回</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern float SMC_ReadADValue(byte ucControllerAddr, byte ucADNo);

        /// <summary>
        /// 设置编码器线数，多少线的编码器
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="ucEncoderNo">接入的哪个编码器</param>
        /// <param name="ulEncoderLineNums">编码器线数</param>
        /// <param name="fScaleValue"></param>
        /// <returns>无返回值</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int SMC_SetEncodeLineNum(byte ucControllerAddr, UInt32 ucEncoderNo, UInt32 ulEncoderLineNums, float fScaleValue);

        /// <summary>
        /// 设置编码器的工作模式
        /// </summary>
        /// <param name="ucControllerAddr">接入的哪个编码器</param>
        /// <param name="ucEncoderNo">编码器的作用或者工作方式</param>
        /// <param name="enEncodeUseType">编码器与步进电机的比例系数</param>
        /// <returns></returns>
        //[DllImport("Adhon_SMC_48MT6.dll")]
        // public static extern int SMC_SetEncodeMode(byte ucControllerAddr, byte ucEncoderNo, CONTROL_FOR_TYPE_E enEncodeUseType);

        /*=======================================================
                Modbus相关指令定义
        =======================================================*/

        /// <summary>
        /// 使用串口编码打开一个串口同时读取控制器的地址信息
        /// </summary>
        /// <param name="ucSericalNo">串口编码</param>
        /// <returns>无返回</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int Modbus_OpenSerical(byte ucSericalNo);

        /// <summary>
        /// 关闭串口
        /// </summary>
        /// <returns>无返回</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int Modbus_CloseSerical();

        /// <summary>
        /// 使用mosbus协议进行位操作
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="usCoilAddr">位操作地址</param>
        /// <param name="bLevelValue">高低电平值</param>
        /// <returns></returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int Modbus_WriteCoil(byte ucControllerAddr, UInt16 usCoilAddr, bool bLevelValue);

        /// <summary>
        /// 使用modbus协议进行指定通道的读取
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="usChannelAddr">控制器中通道地址，参考modbus通道定义文档</param>
        /// <param name="pbValue">读取的浮点数</param>
        /// <returns>无返回</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int Modbus_ReadCoil(byte ucControllerAddr, UInt16 usChannelAddr, out bool pbValue);

        /// <summary>
        /// 使用modbus协议进行浮点数写入
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="usChannelAddr">控制器中通道地址，参考modbus通道定义文档</param>
        /// <param name="fWriteData">需要写入额浮点数</param>
        /// <returns></returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int Modbus_WriteFloat(byte ucControllerAddr, UInt16 usChannelAddr, float fWriteData);

        /// <summary>
        /// 使用modbus协议进行浮点数读取
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="usChannelAddr">控制器中通道地址，参考modbus通道定义文档</param>
        /// <param name="pfValue">读取的浮点数</param>
        /// <returns>读取的浮点数</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int Modbus_ReadFloat(byte ucControllerAddr, UInt16 usChannelAddr, out float pfValue);

        /// <summary>
        /// 使用modbus协议进行双通道整数写入
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="usChannelAddr">控制器中通道地址，参考modbus通道定义文档</param>
        /// <param name="ulWriteData">需要写入的整数</param>
        /// <returns>无返回</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int Modbus_WriteLong(byte ucControllerAddr, UInt16 usChannelAddr, UInt32 ulWriteData);

        /// <summary>
        /// 使用modbus协议进行双通道整数读取
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="usChannelAddr">控制器中通道地址，参考modbus通道定义文档</param>
        /// <param name="plValue">读取的双通道整数</param>
        /// <returns>读取的双通道整数</returns>
        [System.Runtime.InteropServices.DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int Modbus_ReadLong(byte ucControllerAddr, UInt16 usChannelAddr, out UInt32 plValue);

        /// <summary>
        /// 使用modbus协议进行单通道整数写入
        /// </summary>
        /// <param name="ucControllerAddr">控制器地址</param>
        /// <param name="usChannelAddr">控制器中通道地址</param>
        /// <param name="usWriteData">需要写入的浮点数</param>
        /// <returns>无返回</returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int Modbus_WriteShort(byte ucControllerAddr, UInt16 usChannelAddr, UInt16 usWriteData);

        /// <summary>
        /// 使用modbus协议进行浮点数读取
        /// </summary>
        /// <param name="ucControllerAddr"></param>
        /// <param name="usChannelAddr"></param>
        /// <param name="pusValue"></param>
        /// <returns></returns>
        [DllImport("Adhon_SMC_48MT6.dll")]
        public static extern int Modbus_ReadShort(byte ucControllerAddr, UInt16 usChannelAddr, out UInt16 pusValue);
    }
}
