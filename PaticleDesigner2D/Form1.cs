using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleDesigner2D
{
    public partial class Form1 : Form
    {

        NumberParameter EmitTime_ { get; set; }     //放出間隔

        NumberParameter Speed_ { get; set; }     //初速度

        NumberParameter Accel_ { get; set; }       //加速度

        NumberParameter RotateDegSpeed_ { get; set; } //各速度

        NumberParameter LifeTime_ { get; set; }    //生存時間

        ParameterController controller;


        public Form1()
        {
            InitializeComponent();

            controller = new ParameterController(ParameterPanel_);

            EmitTime_    = controller.AddNumber("放出間隔[s]", 0, 3.5f);
            LifeTime_    = controller.AddNumber("生存時間[s]", 0, 20);
            Speed_       = controller.AddNumber("初速度[/s]", 0, 1000, 0);
            Accel_       = controller.AddNumber("加速度[/s]", 0, 100, 0);
            RotateDegSpeed_ = controller.AddNumber("角速度[deg/s]",-1000, 1000, 0);
        }

        void Loop(float deltaTime)
        {

        }

        //アップデート
        private void UpdateTimer__Tick(object sender, EventArgs e)
        {

            Loop( UpdateTimer_.Interval * 0.001f);
            CanvasPanel_.Invalidate();
        }
    }
}
