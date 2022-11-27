namespace WindowsFormsApp2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.mtbPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.cbSaler = new System.Windows.Forms.ComboBox();
            this.lblSaler = new System.Windows.Forms.Label();
            this.cbLeatherSalon = new System.Windows.Forms.CheckBox();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.rbBrown = new System.Windows.Forms.RadioButton();
            this.grbColors = new System.Windows.Forms.GroupBox();
            this.lblMade = new System.Windows.Forms.Label();
            this.lbMarks = new System.Windows.Forms.ListBox();
            this.lblOptions = new System.Windows.Forms.Label();
            this.clbOptions = new System.Windows.Forms.CheckedListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.mcDelivery = new System.Windows.Forms.MonthCalendar();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.txbDelivery = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grbColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirstName.Location = new System.Drawing.Point(49, 33);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(144, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Имя покупателя";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastName.Location = new System.Drawing.Point(48, 70);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(189, 20);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Фамилия покупателя";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(49, 102);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(162, 20);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Мобильный номер";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(244, 70);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(161, 26);
            this.tbSurname.TabIndex = 4;
            this.toolTip.SetToolTip(this.tbSurname, "Фамилия");
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(244, 33);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(161, 26);
            this.tbFirstName.TabIndex = 3;
            this.toolTip.SetToolTip(this.tbFirstName, "Имя");
            // 
            // mtbPhoneNumber
            // 
            this.mtbPhoneNumber.Location = new System.Drawing.Point(244, 102);
            this.mtbPhoneNumber.Mask = "+38(\\000)000-00-00";
            this.mtbPhoneNumber.Name = "mtbPhoneNumber";
            this.mtbPhoneNumber.RejectInputOnFirstFailure = true;
            this.mtbPhoneNumber.Size = new System.Drawing.Size(161, 26);
            this.mtbPhoneNumber.TabIndex = 6;
            this.mtbPhoneNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbPhoneNumber_MaskInputRejected);
            this.mtbPhoneNumber.Click += new System.EventHandler(this.mtbPhoneNumber_Click);
            // 
            // cbSaler
            // 
            this.cbSaler.FormattingEnabled = true;
            this.cbSaler.Items.AddRange(new object[] {
            "Ваня",
            "Саня",
            "Вася",
            "Петя",
            "Коля"});
            this.cbSaler.Location = new System.Drawing.Point(531, 33);
            this.cbSaler.Name = "cbSaler";
            this.cbSaler.Size = new System.Drawing.Size(187, 28);
            this.cbSaler.TabIndex = 7;
            this.cbSaler.SelectedIndexChanged += new System.EventHandler(this.cbSaler_SelectedIndexChanged);
            // 
            // lblSaler
            // 
            this.lblSaler.AutoSize = true;
            this.lblSaler.Location = new System.Drawing.Point(527, 9);
            this.lblSaler.Name = "lblSaler";
            this.lblSaler.Size = new System.Drawing.Size(94, 20);
            this.lblSaler.TabIndex = 8;
            this.lblSaler.Text = "Продавец";
            // 
            // cbLeatherSalon
            // 
            this.cbLeatherSalon.AutoSize = true;
            this.cbLeatherSalon.Location = new System.Drawing.Point(53, 148);
            this.cbLeatherSalon.Name = "cbLeatherSalon";
            this.cbLeatherSalon.Size = new System.Drawing.Size(160, 24);
            this.cbLeatherSalon.TabIndex = 9;
            this.cbLeatherSalon.Text = "Кожаный салон";
            this.cbLeatherSalon.UseVisualStyleBackColor = true;
            this.cbLeatherSalon.CheckedChanged += new System.EventHandler(this.cbLeatherSalon_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.ForeColor = System.Drawing.Color.Red;
            this.rbRed.Location = new System.Drawing.Point(13, 26);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(102, 24);
            this.rbRed.TabIndex = 10;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Красный";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Location = new System.Drawing.Point(121, 25);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(95, 24);
            this.rbBlack.TabIndex = 11;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Чёрный";
            this.rbBlack.UseVisualStyleBackColor = true;
            // 
            // rbBrown
            // 
            this.rbBrown.AutoSize = true;
            this.rbBrown.ForeColor = System.Drawing.Color.Brown;
            this.rbBrown.Location = new System.Drawing.Point(222, 25);
            this.rbBrown.Name = "rbBrown";
            this.rbBrown.Size = new System.Drawing.Size(133, 24);
            this.rbBrown.TabIndex = 12;
            this.rbBrown.TabStop = true;
            this.rbBrown.Text = "Коричневый";
            this.rbBrown.UseVisualStyleBackColor = true;
            // 
            // grbColors
            // 
            this.grbColors.Controls.Add(this.rbBrown);
            this.grbColors.Controls.Add(this.rbRed);
            this.grbColors.Controls.Add(this.rbBlack);
            this.grbColors.Location = new System.Drawing.Point(219, 148);
            this.grbColors.Name = "grbColors";
            this.grbColors.Size = new System.Drawing.Size(355, 58);
            this.grbColors.TabIndex = 13;
            this.grbColors.TabStop = false;
            this.grbColors.Text = "Цвет салона";
            this.grbColors.Visible = false;
            // 
            // lblMade
            // 
            this.lblMade.AutoSize = true;
            this.lblMade.Location = new System.Drawing.Point(47, 223);
            this.lblMade.Name = "lblMade";
            this.lblMade.Size = new System.Drawing.Size(107, 20);
            this.lblMade.TabIndex = 14;
            this.lblMade.Text = "Марка авто";
            // 
            // lbMarks
            // 
            this.lbMarks.FormattingEnabled = true;
            this.lbMarks.ItemHeight = 20;
            this.lbMarks.Items.AddRange(new object[] {
            "Peugeot",
            "Renault",
            "Mercedes",
            "Opel",
            "Ford",
            "Volvo",
            "Walksvagen"});
            this.lbMarks.Location = new System.Drawing.Point(46, 258);
            this.lbMarks.Name = "lbMarks";
            this.lbMarks.Size = new System.Drawing.Size(128, 84);
            this.lbMarks.TabIndex = 15;
            this.lbMarks.SelectedIndexChanged += new System.EventHandler(this.lbMarks_SelectedIndexChanged);
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(236, 223);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(209, 20);
            this.lblOptions.TabIndex = 14;
            this.lblOptions.Text = "Дополнительные опции";
            // 
            // clbOptions
            // 
            this.clbOptions.CheckOnClick = true;
            this.clbOptions.ColumnWidth = 200;
            this.clbOptions.FormattingEnabled = true;
            this.clbOptions.Items.AddRange(new object[] {
            "Климат контроль",
            "Круиз-контроль",
            "Люк",
            "Панорамная крыша",
            "Подогрев зеркал",
            "Стереосистема"});
            this.clbOptions.Location = new System.Drawing.Point(240, 258);
            this.clbOptions.MultiColumn = true;
            this.clbOptions.Name = "clbOptions";
            this.clbOptions.Size = new System.Drawing.Size(349, 109);
            this.clbOptions.Sorted = true;
            this.clbOptions.TabIndex = 16;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(42, 390);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(137, 20);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Дата доставки";
            // 
            // mcDelivery
            // 
            this.mcDelivery.Location = new System.Drawing.Point(42, 419);
            this.mcDelivery.Name = "mcDelivery";
            this.mcDelivery.TabIndex = 17;
            this.mcDelivery.TitleBackColor = System.Drawing.Color.Silver;
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(381, 390);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(208, 20);
            this.lblDelivery.TabIndex = 14;
            this.lblDelivery.Text = "Подробности доставки";
            // 
            // txbDelivery
            // 
            this.txbDelivery.Location = new System.Drawing.Point(309, 419);
            this.txbDelivery.Multiline = true;
            this.txbDelivery.Name = "txbDelivery";
            this.txbDelivery.ReadOnly = true;
            this.txbDelivery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbDelivery.Size = new System.Drawing.Size(367, 207);
            this.txbDelivery.TabIndex = 18;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(695, 570);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(169, 56);
            this.btnOrder.TabIndex = 19;
            this.btnOrder.Text = "Подтверждение \r\nзаказа";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 645);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txbDelivery);
            this.Controls.Add(this.mcDelivery);
            this.Controls.Add(this.clbOptions);
            this.Controls.Add(this.lbMarks);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblDelivery);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMade);
            this.Controls.Add(this.grbColors);
            this.Controls.Add(this.cbLeatherSalon);
            this.Controls.Add(this.lblSaler);
            this.Controls.Add(this.cbSaler);
            this.Controls.Add(this.mtbPhoneNumber);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Покупка авто";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grbColors.ResumeLayout(false);
            this.grbColors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.MaskedTextBox mtbPhoneNumber;
        private System.Windows.Forms.ComboBox cbSaler;
        private System.Windows.Forms.Label lblSaler;
        private System.Windows.Forms.CheckBox cbLeatherSalon;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.RadioButton rbBrown;
        private System.Windows.Forms.GroupBox grbColors;
        private System.Windows.Forms.Label lblMade;
        private System.Windows.Forms.ListBox lbMarks;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.CheckedListBox clbOptions;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MonthCalendar mcDelivery;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.TextBox txbDelivery;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

