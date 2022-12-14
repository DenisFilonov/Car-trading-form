using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        private StringBuilder _b = new StringBuilder();
        public MainForm()
        {
            InitializeComponent();
        }

        private void mtbPhoneNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show($"Ошибка: {e.RejectionHint} Позиция: {e.Position}");
        }
        private int _clicksCount = 0;
        private void MainForm_Load(object sender, EventArgs e)
        {
            //cbSaler.Text = "Aasd";
            cbSaler.SelectedIndex = 0;
        }
        private void cbSaler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSaler.SelectedItem != null)
            {

            }
        }
        private void cbLeatherSalon_CheckedChanged(object sender, EventArgs e)
        {
            grbColors.Visible = cbLeatherSalon.Checked;
        }
        private void mtbPhoneNumber_Click(object sender, EventArgs e)
        {
            if (_clicksCount == 0)
            {
                mtbPhoneNumber.SelectionStart = 5;
                _clicksCount++;
            }
        }
        private void lbMarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMarks.SelectedItem != null)
            {

            }
            if (lbMarks.SelectedItems.Count > 0)
            {

            }
        }
        //==================================================================================================
        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tbFirstName.Text.Length == 0) throw new Exception("Введите имя покупателя!");
                if (tbSurname.Text.Length == 0) throw new Exception("Введите фамилию покупателя!");
                _b.Append("Имя: " + tbFirstName.Text + "\r\n");
                _b.Append("Фамилия: " + tbSurname.Text + "\r\n");
                _b.Append("Телефон: " + mtbPhoneNumber.Text + "\r\n");

                if (cbLeatherSalon.Checked)
                {
                    //if (rbRed.Checked)
                    //{
                    //    _b.Append("Цвет салона: " + rbRed.Text + "\r\n");
                    //}
                    //else if (rbBrown.Checked)
                    //{
                    //    _b.Append("Цвет салона: " + rbBrown.Text + "\r\n");
                    //}
                    //else if(rbBlack.Checked)
                    //{
                    //    _b.Append("Цвет салона: " + rbBlack.Text + "\r\n");
                    //}
                    if (cbLeatherSalon.Checked)
                    {
                        foreach (Control item in grbColors.Controls)
                        {
                            if (item is RadioButton r && r.Checked)
                            {
                                _b.Append("Цвет салона: " + r.Text + "\r\n");
                                break;
                            }
                        }
                    }
                }
                _b.Append("Марка авто: " + lbMarks.Text + "\r\n");

                if (clbOptions.Items != null)
                {
                    for (int i = 0; i <= (clbOptions.Items.Count - 1); i++)
                    {
                        if (clbOptions.GetItemChecked(i))
                        {
                            _b.Append("Дополнительные опции: " + clbOptions.Items[i] + "\r\n");
                        }
                    }
                }
                if (mcDelivery.SelectionStart >= mcDelivery.TodayDate)
                {
                    _b.Append("Диапазон доставки от: " + mcDelivery.SelectionRange.Start.ToShortDateString() + "\r\n");
                }
                else
                {
                    throw new Exception("Выставлена неверная дата!");
                }
                _b.Append("Диапазон доставки до: " + mcDelivery.SelectionEnd.ToShortDateString() + "\r\n");

                if (cbSaler.SelectedItem != null)
                {
                    _b.Append("Продавец: " + cbSaler.Text + "\r\n");
                }

                txbDelivery.Text = _b.ToString();
                //MessageBox.Show(_b.ToString());
            }
            catch (Exception ex)
            {
                txbDelivery.Text = ex.Message;
            }
            _b.Clear(); // Чтобы менять инфу, очищать от старой, и тестировать дальше
        }
    }
}