using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMC.Controller;
using SMC.Model.Controller;
using System.IO;

namespace Sample
{
    public partial class MotorControl : Form
    {

        public MotorControl()
        {
            InitializeComponent();
            Size size = new Size(this.Width, this.Height);
            this.MaximumSize = size;
            this.MinimumSize = size;
            currentPos = new Pos();
        }

        //坐标值的显示
        private float posX = 0, posY = 0, posZ = 0, posU = 0;
        public float PosX
        {
            get
            {
                return posX;
            }
            set
            {
                posX = value;
                labX.Text = posX.ToString();
            //    labX.Refresh();
                currentPos.x = value;
            }
        }
        public float PosY
        {
            get
            {
                return posY;
            }
            set
            {
                posY = value;
                labY.Text = posY.ToString();
            //    labY.Refresh();
                currentPos.y = value;
            }
        }
        public float PosZ
        {
            get
            {
                return posZ;
            }
            set
            {
                posZ = value;
                labZ.Text = posZ.ToString();
             //   labZ.Refresh();
                currentPos.z = value;
            }
        }
        public float PosU
        {
            get
            {
                return posU;
            }
            set
            {
                posU = value;
                labU.Text = posU.ToString();
             //   labU.Refresh();
                currentPos.u = value;
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            model.AXIS_X.Reset();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            model.AXIS_U.StopMove();
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (cmbStatus.Text == cmbStatus.Items[0].ToString())
            {
                model.AXIS_U.MoveTo(Convert.ToInt64(steptext.Text));
                PosU += Convert.ToInt64(steptext.Text);
            }

            else
                model.AXIS_U.MoveLeft();
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            if (cmbStatus.Text == cmbStatus.Items[0].ToString())
            {
                model.AXIS_U.MoveTo(Convert.ToInt64(steptext.Text));
                PosU += Convert.ToInt64(steptext.Text);
            }
            else
                model.AXIS_U.MoveRight();

        }

        private void btnXLeft_Click(object sender, EventArgs e)
        {
            //是否是点位移动
            if (cmbStatus.Text == cmbStatus.Items[0].ToString())
            {
                model.AXIS_X.MoveTo(-(Convert.ToInt64(steptext.Text)));
                PosX -= Convert.ToInt64(steptext.Text);
            }
            else
                model.AXIS_X.MoveLeft();
        }

        private void btnXRight_Click(object sender, EventArgs e)
        {
            //是否是点位移动
            if (cmbStatus.Text == cmbStatus.Items[0].ToString())
            {
                model.AXIS_X.MoveTo(Convert.ToInt64(steptext.Text));
                PosX += Convert.ToInt64(steptext.Text);
            }
            else
                model.AXIS_X.MoveRight();
        }

        private void btnYLeft_Click(object sender, EventArgs e)
        {
            if (cmbStatus.Text == cmbStatus.Items[0].ToString())
            {
                model.AXIS_Y.MoveTo(-(Convert.ToInt64(steptext.Text)));
                PosY -= Convert.ToInt64(steptext.Text);
            }
            else
                model.AXIS_Y.MoveLeft();
        }

        private void btnYRight_Click(object sender, EventArgs e)
        {
            if (cmbStatus.Text == cmbStatus.Items[0].ToString())
            {
                model.AXIS_Y.MoveTo(Convert.ToInt64(steptext.Text));
                PosY += Convert.ToInt64(steptext.Text);
            }
            else
                model.AXIS_Y.MoveRight();
        }

        private void btnZLeft_Click(object sender, EventArgs e)
        {
            if (cmbStatus.Text == cmbStatus.Items[0].ToString())
            {
                model.AXIS_Z.MoveTo(Convert.ToInt64(steptext.Text));
                PosZ += Convert.ToInt64(steptext.Text);
            }
            else
                model.AXIS_Z.MoveLeft();
        }

        private void btnZRight_Click(object sender, EventArgs e)
        {
            if (cmbStatus.Text == cmbStatus.Items[0].ToString())
            {
                model.AXIS_Z.MoveTo(-(Convert.ToInt64(steptext.Text)));
                PosZ -= Convert.ToInt64(steptext.Text);
            }
            else
                model.AXIS_Z.MoveRight();
        }

        private void btnULeft_Click(object sender, EventArgs e)
        {
            if (cmbStatus.Text == cmbStatus.Items[0].ToString())
            {
                model.AXIS_U.MoveTo(Convert.ToInt64(steptext.Text));
                PosU += Convert.ToInt64(steptext.Text);
            }

            else
                model.AXIS_U.MoveLeft();
        }

        private void btnURight_Click(object sender, EventArgs e)
        {
            if (cmbStatus.Text == cmbStatus.Items[0].ToString())
            {
                model.AXIS_U.MoveTo(-(Convert.ToInt64(steptext.Text)));
                PosU -= Convert.ToInt64(steptext.Text);
            }
            else
                model.AXIS_U.MoveRight();
        }

        private void btnXReset_Click(object sender, EventArgs e)
        {
            model.AXIS_X.Reset();
        }

        private void btnXStop_Click(object sender, EventArgs e)
        {
            model.AXIS_X.StopMove();
        }

        private void btnYReset_Click(object sender, EventArgs e)
        {
            model.AXIS_Y.Reset();
        }

        private void btnYStop_Click(object sender, EventArgs e)
        {
            model.AXIS_Y.StopMove();
        }

        private void btnZReset_Click(object sender, EventArgs e)
        {
            model.AXIS_Z.Reset();
        }

        private void btnZStop_Click(object sender, EventArgs e)
        {
            model.AXIS_Z.StopMove();
        }

        private void btnUReset_Click(object sender, EventArgs e)
        {
            model.AXIS_U.Reset();
        }

        private void btnUStop_Click(object sender, EventArgs e)
        {
            model.AXIS_U.StopMove();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(Reset));
            thread.Start();
            PosX = 0;
            PosY = 0;
            PosZ = 0;
            PosU = 0;
        }
        public void Reset()
        {
            SMCController.Reset();
        }
        private void MotorControl_Load(object sender, EventArgs e)
        {
            cmbPorts.Items.Clear();
            string[] ports = SMCController.ScanSeraPort();
            foreach (string s in ports)
            {
                cmbPorts.Items.Add(s);
            }
        }

        SMC_Controller_Model model;
        private void FormMain_Load(object sender, EventArgs e)
        {
            cmbPorts.Items.Clear();
            string[] ports = SMCController.ScanSeraPort();
            foreach (string s in ports)
            {
                cmbPorts.Items.Add(s);
            }
        }
        private void cmbPorts_TextChanged(object sender, EventArgs e)
        {
            string port = cmbPorts.Text;
            if (!cmbPorts.Items.Contains(port)) return;
            byte comport = Convert.ToByte(port.Replace("COM", ""));
            model = new SMC_Controller_Model(comport);
            SMCController.Connect_Controller(model);
        }

        private void btnAutoMove_Click(object sender, EventArgs e)
        {
            AutoMove(350, 300);
          //   AutoMove(260,200);
            //AutoMove();
        }
        Pos currentPos;

        private void BtnGetPointcloud_Click(object sender, EventArgs e)
        {
         //   绝缘子三维扫描系统.Program.mainform
          //      .sharpgl.PointsClouds.SavePoints2Htuple("Captured");
        }


        /**位姿数据结构
         * **/
        private struct Pos
        {
            public float x, y, z,u;
        }


        List<Pos> moveData;
        public void AutoMove()
        {
            AutoMove(350, 300);
            return;
            moveData = new List<Pos>();
        
            string[] splitData;
            using (StreamReader sr = new StreamReader(File.OpenRead("moveData.txt")))
            {
                var lins = sr.ReadToEnd().Split('\r');
                for (int i = 0; i < lins.Length; i++)
                {
                    splitData = lins[i].Split(' ');
                    Pos p = new Pos()
                    {
                        x = float.Parse(splitData[0]),
                        y = float.Parse(splitData[1]),
                        z = float.Parse(splitData[2]),
                        u = float.Parse(splitData[3])
                    };           
                    moveData.Add(p);
                }
            }
         
            for (int i = 0; i < moveData.Count; i++)
            {
                Pos p = moveData[i];
                MoveToNext(p);
                System.Threading.Thread.Sleep(1000);
              //  绝缘子三维扫描系统.Program.mainform.sharpgl.PointsClouds.SavePoints2Htuple(i.ToString());
            }
        }
        public void AutoMove(float xLenght,float yLength)
        {
            moveData = new List<Pos>();
            //z=14代表水平向右

            //竖直向下进行测量
            Pos circleCenter = new Pos
            {
                x = 280,
                y = 0,
                z = 104,//相机旋转
                u = 0
            };
            moveData.Add(circleCenter);
            for (int i = 1; i < 5; i++)
            {
                Pos p = circleCenter;
                p.u += 90 * i;
                moveData.Add(p);
            }
         
            //如果圆盘直径小于350，可以在斜向下45度进行测量
            if (xLenght < 350)
            {
                Pos topLeap = new Pos
                {
                    x = (270f - xLenght / 2) / 2,
                    y = 0,
                    z = 104 - 45,//相机旋转
                    u = moveData.Last().u
                };
                moveData.Add(topLeap);
                for (int i = 1; i < 5; i++)
                {
                    Pos p = topLeap;
                    p.u += 90 * i;
                    moveData.Add(p);
                }
            }

            //水平向左进行测量
            Pos verticalCenter = new Pos
            {
                x = 0,
                y = -640,
                z = 14,//相机旋转
                u = moveData.Last().u
            };
            moveData.Add(verticalCenter);
            for (int i = 1; i < 5; i++)
            {
                Pos p = verticalCenter;
                p.u += 90 * i;
                moveData.Add(p);
            }

            //如果圆盘高度小于300，可以在斜向上45度进行测量
            if (yLength < 300)
            {
                Pos bottonLeap = new Pos
                {
                    x = 0,
                    y = moveData.Last().y - 200,//（未完成）总高度减去当前高度，除二，结果为需要多走的行程
                    z = 14-45,//相机斜向上
                    u = moveData.Last().u
                };
                moveData.Add(bottonLeap);
                for (int i = 1; i < 5; i++)
                {
                    Pos p = bottonLeap;
                    p.u += 90 * i;
                    moveData.Add(p);
                }
            }

            for (int i = 0; i < moveData.Count; i++)
            {
                Pos p = moveData[i];
                MoveToNext(p);
                System.Threading.Thread.Sleep(1000);
              //  绝缘子三维扫描系统.Program.mainform.sharpgl.PointsClouds.SavePoints2Htuple(i.ToString());
            }
        }

        /**移动到下一个位置
         * p =>下一个位置的电机运动参数
         * **/
        private void MoveToNext(Pos p)
        {
            float tempX, tempY, tempZ, tempU;
            model.AXIS_X.MoveTo(p.x - currentPos.x);
            model.AXIS_Y.MoveTo(p.y - currentPos.y);
            model.AXIS_Z.MoveTo(p.z - currentPos.z);
            model.AXIS_U.MoveTo(p.u - currentPos.u);
            bool Xzero = false;
            bool Yzero = false;
            bool Zzero = false;
            bool Uzero = false;
            while (true)
            {
                tempX = model.AXIS_X.GetCurrentPos(p.x);
                if (Math.Abs(tempX) < 1)
                {
                    Xzero = true;
                }
                tempY = model.AXIS_Y.GetCurrentPos(p.y);
                if (Math.Abs(tempY) < 1)
                {
                    Yzero = true;
                }
                tempZ = model.AXIS_Z.GetCurrentPos(p.z);
                if (Math.Abs(tempZ) < 1)
                {
                    Zzero = true;
                }
                tempU = model.AXIS_U.GetCurrentPos(p.u);
                if (Math.Abs(tempU) < 1)
                {
                    Uzero = true;
                }
               // this.Refresh();
                if (Xzero && Yzero && Zzero && Uzero)
                    break;
            }
            currentPos.x = p.x;
            currentPos.y = p.y;
            currentPos.z = p.z;
            currentPos.u = p.u;
            //posX = p.x;
            //posY = p.y;
            //posZ = p.z;
            //posU = p.u;
        }


        public void AutoCaculateMove(Point center ,float Rad)
        {
            Pos nextPos = currentPos;
            float delt = Rad - center.x - currentPos.x;
            nextPos.x = currentPos.x - delt;
            nextPos.y = currentPos.y - center.y;
            nextPos.z = 90;//摄像头从竖直向下变成水平向左
            MoveToNext(nextPos);
            //start
            //向下移动半个竖直视野的距离
            //获取点云，旋转U轴，一次旋转90度，旋转四次，
            //如果可以检测到圆柱的底部，退出循环
            //loop to start
        }
        public struct Point
        {
            public float x, y, z;
        }
    }
}