using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenClosedPrincipal
{
    public partial class PointForm : Form
    {
        private readonly string _cardNo;
        //private MyPoint _myPoint;
        //private PointPay _pointPay;
        private IPoint _point;


        public PointForm(string cardNo)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _cardNo = cardNo;
            _point = Factories.CreatePoint(_cardNo);
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            int price = 100;
            int point = _point.GetPoint(price);

            PointLabel.Text = point + "p";

        }

        private void DeadLineButton_Click(object sender, EventArgs e)
        {
            DateTime deadLine = _point.GetDeadLine();
            DeadLineLabel.Text = deadLine.ToString("yyyy/MM/dd");
        }
    }

    public static class Factories
    {
        public static IPoint CreatePoint(string cardNo)
        {
            if (cardNo.Substring(0, 1) == "P")
            {
                return new PointPay();
            }
            if (cardNo.Substring(0, 1) == "A")
            {
                return new AnaPoint();
            }
            if (cardNo.Substring(0, 1) == "J")
            {
                return new JALPoint();
            }
            return new MyPoint();
        }
    }

    public interface IPoint
    {
        int GetPoint(int price);
        DateTime GetDeadLine();
    }


    public sealed class MyPoint : IPoint
    {
        public int GetPoint(int price)
        {
            return Convert.ToInt32(price * 0.01f);
        }

        public DateTime GetDeadLine()
        {
            return DateTime.Now.AddDays(5);
        }
    }

    public sealed class PointPay : IPoint
    {
        public int GetPoint(int price)
        {
            return Convert.ToInt32(price * 0.02f);
        }
        public DateTime GetDeadLine()
        {
            return DateTime.Now.AddDays(10);
        }
    }
    public sealed class AnaPoint : IPoint
    {
        public int GetPoint(int price)
        {
            return Convert.ToInt32(price * 0.03f);
        }
        public DateTime GetDeadLine()
        {
            return DateTime.Now.AddDays(60);
        }
    }
    public sealed class JALPoint : IPoint
    {
        public int GetPoint(int price)
        {
            return Convert.ToInt32(price * 0.04f);
        }
        public DateTime GetDeadLine()
        {
            return DateTime.Now.AddDays(100);
        }
    }
}
