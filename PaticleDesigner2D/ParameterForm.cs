using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ParticleDesigner2D
{

    //パラメータのリスト
    class ParameterController
    {

        public const int NumericalHeight = 19;

        public Panel Panel_ { get; set; }

        //パラメータフォームの高さ
        const int Padding = 20;
        int Y_ = 0;

        //パラメータの数
        int NumOfParameter_ = 0;

        readonly Point padding = new Point(6, 6);
        public ParameterController(Panel panel)
        {
            Panel_ = panel;
            Panel_.AutoScroll = true;
            Y_ = padding.Y;
        }

        public NumberParameter AddNumber(String name, float min = -100, float max = 100, int decimalPlace = 1)
        {
            Point location = new Point(padding.X + 0, Y_);
            Size size = new Size(Panel_.Width - 2 * padding.X, Padding);
            var c = new NumberParameter(name, location, size, min, max, decimalPlace);
            c.Parent = Panel_;

            NumOfParameter_++;

            Y_ += c.Height + Padding;
            return c;
        }

        public PointParameter AddPoint(String name, float min = -100, float max = 100, int decimalPlace = 1)
        {
            Point location = new Point(padding.X + 0, Y_);
            Size size = new Size(Panel_.Width - 2 * padding.X, Padding);

            var c = new PointParameter(name, location, size, min, max, decimalPlace);
            c.Parent = Panel_;

            NumOfParameter_++;
            Y_ += c.Height + Padding;
            return c;
        }
    }





    //int型のパラメータ
    class NumberParameter : Panel
    {
        public float Value
        {
            get
            {
                return (float)Value_.Value;
            }
        }
       

        public Label Name_ { get; private set; }

        NumericUpDown Value_ { get; set; }

        const int ValueWidth_ = 50;
        public NumberParameter(string name, Point location, Size size, float min, float max, int decimalPlace)
        {
            Location = location;
            Size = new Size(size.Width, ParameterController.NumericalHeight);

            Value_ = new NumericUpDown();
            Name_ = new Label();


            {

                Name_.Parent = this;
                Name_.Text = name;
                Name_.Location = new Point();
                Name_.Size = new Size(Width - ValueWidth_, ParameterController.NumericalHeight);
            }

            {

                Value_.Parent = this;
                Value_.Size = new Size(ValueWidth_, ParameterController.NumericalHeight);
                Value_.Location = new Point(Width - ValueWidth_, 0);

                Value_.Minimum = (Decimal)min;
                Value_.Maximum = (Decimal)max;
                Value_.DecimalPlaces = decimalPlace;
                Value_.Increment = (Decimal)(1.0 * Math.Pow(0.1, decimalPlace));
            }

        }
    }

    //Point型のパラメータ
    class PointParameter : Panel
    {


        Label Name_ { get; set; }

        NumberParameter X_, Y_;
        public PointF Value
        {
            get
            {
                return new PointF(X_.Value, Y_.Value);
            }
        }

        public PointParameter(string name, Point location, Size size, float min, float max, int decimalPlace)
        {
            Location = location;
            Size = new Size(size.Width, ParameterController.NumericalHeight * 2);
            {
                Name_ = new Label();
                Name_.Parent = this;
                Name_.Text = name;
                Name_.Location = new Point();
                Name_.Size = new Size(Width, ParameterController.NumericalHeight);
            }

            {

                X_ = new NumberParameter("x", new Point(0, ParameterController.NumericalHeight),
                                          new Size(Width / 2, Height - ParameterController.NumericalHeight), min, max, decimalPlace);
                X_.Parent = this;
                X_.Name_.TextAlign = ContentAlignment.MiddleRight;
            }

            {
                Y_ = new NumberParameter("y", new Point(Width / 2, ParameterController.NumericalHeight),
                                           new Size(Width / 2, Height - ParameterController.NumericalHeight), min, max,decimalPlace);
                Y_.Parent = this;
                Y_.Name_.TextAlign = ContentAlignment.MiddleRight;
            }
        }
    }

}
