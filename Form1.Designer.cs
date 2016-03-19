namespace CIS4620Black_Scholes_Assignment2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStockPrice = new System.Windows.Forms.TextBox();
            this.txtVolatility = new System.Windows.Forms.TextBox();
            this.txtStrikePrice = new System.Windows.Forms.TextBox();
            this.txtRiskRate = new System.Windows.Forms.TextBox();
            this.txtCallPrice = new System.Windows.Forms.TextBox();
            this.txtPutPrice = new System.Windows.Forms.TextBox();
            this.dateNow = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.chkCall = new System.Windows.Forms.CheckBox();
            this.chkPut = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDivident = new System.Windows.Forms.TextBox();
            this.chkDividents = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgCall = new System.Windows.Forms.TextBox();
            this.volgaCall = new System.Windows.Forms.TextBox();
            this.ddCall = new System.Windows.Forms.TextBox();
            this.rCall = new System.Windows.Forms.TextBox();
            this.colorCall = new System.Windows.Forms.TextBox();
            this.tCall = new System.Windows.Forms.TextBox();
            this.charmCall = new System.Windows.Forms.TextBox();
            this.vCall = new System.Windows.Forms.TextBox();
            this.vannaCall = new System.Windows.Forms.TextBox();
            this.gCall = new System.Windows.Forms.TextBox();
            this.dCall = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgPut = new System.Windows.Forms.TextBox();
            this.volgaPut = new System.Windows.Forms.TextBox();
            this.ddPut = new System.Windows.Forms.TextBox();
            this.rPut = new System.Windows.Forms.TextBox();
            this.colorPut = new System.Windows.Forms.TextBox();
            this.tPut = new System.Windows.Forms.TextBox();
            this.charmPut = new System.Windows.Forms.TextBox();
            this.vPut = new System.Windows.Forms.TextBox();
            this.vannaPut = new System.Windows.Forms.TextBox();
            this.gPut = new System.Windows.Forms.TextBox();
            this.dPut = new System.Windows.Forms.TextBox();
            this.lblGamma = new System.Windows.Forms.Label();
            this.lblDelta = new System.Windows.Forms.Label();
            this.lblVega = new System.Windows.Forms.Label();
            this.lblTheta = new System.Windows.Forms.Label();
            this.chkGreek = new System.Windows.Forms.CheckBox();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Volatility";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Strike Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Risk-Free Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Expiration Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Call Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Put Price";
            // 
            // txtStockPrice
            // 
            this.txtStockPrice.Location = new System.Drawing.Point(195, 43);
            this.txtStockPrice.Name = "txtStockPrice";
            this.txtStockPrice.Size = new System.Drawing.Size(118, 20);
            this.txtStockPrice.TabIndex = 8;
            // 
            // txtVolatility
            // 
            this.txtVolatility.Location = new System.Drawing.Point(195, 71);
            this.txtVolatility.Name = "txtVolatility";
            this.txtVolatility.Size = new System.Drawing.Size(118, 20);
            this.txtVolatility.TabIndex = 9;
            // 
            // txtStrikePrice
            // 
            this.txtStrikePrice.Location = new System.Drawing.Point(195, 100);
            this.txtStrikePrice.Name = "txtStrikePrice";
            this.txtStrikePrice.Size = new System.Drawing.Size(118, 20);
            this.txtStrikePrice.TabIndex = 10;
            // 
            // txtRiskRate
            // 
            this.txtRiskRate.Location = new System.Drawing.Point(195, 133);
            this.txtRiskRate.Name = "txtRiskRate";
            this.txtRiskRate.Size = new System.Drawing.Size(118, 20);
            this.txtRiskRate.TabIndex = 11;
            // 
            // txtCallPrice
            // 
            this.txtCallPrice.Location = new System.Drawing.Point(195, 233);
            this.txtCallPrice.Name = "txtCallPrice";
            this.txtCallPrice.Size = new System.Drawing.Size(118, 20);
            this.txtCallPrice.TabIndex = 12;
            // 
            // txtPutPrice
            // 
            this.txtPutPrice.Location = new System.Drawing.Point(195, 270);
            this.txtPutPrice.Name = "txtPutPrice";
            this.txtPutPrice.Size = new System.Drawing.Size(118, 20);
            this.txtPutPrice.TabIndex = 13;
            // 
            // dateNow
            // 
            this.dateNow.Location = new System.Drawing.Point(156, 167);
            this.dateNow.Name = "dateNow";
            this.dateNow.Size = new System.Drawing.Size(207, 20);
            this.dateNow.TabIndex = 14;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(156, 195);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(207, 20);
            this.dateEnd.TabIndex = 15;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(66, 300);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 36);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Calculate";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(233, 300);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 36);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "%";
            // 
            // chkCall
            // 
            this.chkCall.AutoSize = true;
            this.chkCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCall.Location = new System.Drawing.Point(12, 220);
            this.chkCall.Name = "chkCall";
            this.chkCall.Size = new System.Drawing.Size(77, 17);
            this.chkCall.TabIndex = 19;
            this.chkCall.Text = "Call Option";
            this.chkCall.UseVisualStyleBackColor = true;
            // 
            // chkPut
            // 
            this.chkPut.AutoSize = true;
            this.chkPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPut.Location = new System.Drawing.Point(12, 259);
            this.chkPut.Name = "chkPut";
            this.chkPut.Size = new System.Drawing.Size(76, 17);
            this.chkPut.TabIndex = 20;
            this.chkPut.Text = "Put Option";
            this.chkPut.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(182, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "$";
            // 
            // txtDivident
            // 
            this.txtDivident.Location = new System.Drawing.Point(399, 90);
            this.txtDivident.Name = "txtDivident";
            this.txtDivident.Size = new System.Drawing.Size(100, 20);
            this.txtDivident.TabIndex = 25;
            // 
            // chkDividents
            // 
            this.chkDividents.AutoSize = true;
            this.chkDividents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDividents.Location = new System.Drawing.Point(399, 67);
            this.chkDividents.Name = "chkDividents";
            this.chkDividents.Size = new System.Drawing.Size(70, 17);
            this.chkDividents.TabIndex = 21;
            this.chkDividents.Text = "Dividents";
            this.chkDividents.UseVisualStyleBackColor = true;
            this.chkDividents.CheckedChanged += new System.EventHandler(this.chkDividents_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgCall);
            this.groupBox4.Controls.Add(this.volgaCall);
            this.groupBox4.Controls.Add(this.ddCall);
            this.groupBox4.Controls.Add(this.rCall);
            this.groupBox4.Controls.Add(this.colorCall);
            this.groupBox4.Controls.Add(this.tCall);
            this.groupBox4.Controls.Add(this.charmCall);
            this.groupBox4.Controls.Add(this.vCall);
            this.groupBox4.Controls.Add(this.vannaCall);
            this.groupBox4.Controls.Add(this.gCall);
            this.groupBox4.Controls.Add(this.dCall);
            this.groupBox4.Location = new System.Drawing.Point(452, 178);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(100, 114);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Call";
            // 
            // dgCall
            // 
            this.dgCall.BackColor = System.Drawing.SystemColors.Control;
            this.dgCall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCall.Location = new System.Drawing.Point(20, 265);
            this.dgCall.Name = "dgCall";
            this.dgCall.ReadOnly = true;
            this.dgCall.Size = new System.Drawing.Size(50, 13);
            this.dgCall.TabIndex = 33;
            this.dgCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // volgaCall
            // 
            this.volgaCall.BackColor = System.Drawing.SystemColors.Control;
            this.volgaCall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.volgaCall.Location = new System.Drawing.Point(20, 140);
            this.volgaCall.Name = "volgaCall";
            this.volgaCall.ReadOnly = true;
            this.volgaCall.Size = new System.Drawing.Size(50, 13);
            this.volgaCall.TabIndex = 24;
            this.volgaCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ddCall
            // 
            this.ddCall.BackColor = System.Drawing.SystemColors.Control;
            this.ddCall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ddCall.Location = new System.Drawing.Point(20, 240);
            this.ddCall.Name = "ddCall";
            this.ddCall.ReadOnly = true;
            this.ddCall.Size = new System.Drawing.Size(50, 13);
            this.ddCall.TabIndex = 31;
            this.ddCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rCall
            // 
            this.rCall.BackColor = System.Drawing.SystemColors.Control;
            this.rCall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rCall.Location = new System.Drawing.Point(20, 115);
            this.rCall.Name = "rCall";
            this.rCall.ReadOnly = true;
            this.rCall.Size = new System.Drawing.Size(50, 13);
            this.rCall.TabIndex = 22;
            this.rCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colorCall
            // 
            this.colorCall.BackColor = System.Drawing.SystemColors.Control;
            this.colorCall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorCall.Location = new System.Drawing.Point(20, 215);
            this.colorCall.Name = "colorCall";
            this.colorCall.ReadOnly = true;
            this.colorCall.Size = new System.Drawing.Size(50, 13);
            this.colorCall.TabIndex = 29;
            this.colorCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tCall
            // 
            this.tCall.BackColor = System.Drawing.SystemColors.Control;
            this.tCall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tCall.Location = new System.Drawing.Point(20, 90);
            this.tCall.Name = "tCall";
            this.tCall.ReadOnly = true;
            this.tCall.Size = new System.Drawing.Size(50, 13);
            this.tCall.TabIndex = 20;
            this.tCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // charmCall
            // 
            this.charmCall.BackColor = System.Drawing.SystemColors.Control;
            this.charmCall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.charmCall.Location = new System.Drawing.Point(20, 190);
            this.charmCall.Name = "charmCall";
            this.charmCall.ReadOnly = true;
            this.charmCall.Size = new System.Drawing.Size(50, 13);
            this.charmCall.TabIndex = 28;
            this.charmCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // vCall
            // 
            this.vCall.BackColor = System.Drawing.SystemColors.Control;
            this.vCall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vCall.Location = new System.Drawing.Point(20, 65);
            this.vCall.Name = "vCall";
            this.vCall.ReadOnly = true;
            this.vCall.Size = new System.Drawing.Size(50, 13);
            this.vCall.TabIndex = 18;
            this.vCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // vannaCall
            // 
            this.vannaCall.BackColor = System.Drawing.SystemColors.Control;
            this.vannaCall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vannaCall.Location = new System.Drawing.Point(20, 165);
            this.vannaCall.Name = "vannaCall";
            this.vannaCall.ReadOnly = true;
            this.vannaCall.Size = new System.Drawing.Size(50, 13);
            this.vannaCall.TabIndex = 26;
            this.vannaCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gCall
            // 
            this.gCall.BackColor = System.Drawing.SystemColors.Control;
            this.gCall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gCall.Location = new System.Drawing.Point(20, 40);
            this.gCall.Name = "gCall";
            this.gCall.ReadOnly = true;
            this.gCall.Size = new System.Drawing.Size(50, 13);
            this.gCall.TabIndex = 16;
            this.gCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dCall
            // 
            this.dCall.BackColor = System.Drawing.SystemColors.Control;
            this.dCall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dCall.Location = new System.Drawing.Point(20, 21);
            this.dCall.Name = "dCall";
            this.dCall.ReadOnly = true;
            this.dCall.Size = new System.Drawing.Size(50, 13);
            this.dCall.TabIndex = 15;
            this.dCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgPut);
            this.groupBox5.Controls.Add(this.volgaPut);
            this.groupBox5.Controls.Add(this.ddPut);
            this.groupBox5.Controls.Add(this.rPut);
            this.groupBox5.Controls.Add(this.colorPut);
            this.groupBox5.Controls.Add(this.tPut);
            this.groupBox5.Controls.Add(this.charmPut);
            this.groupBox5.Controls.Add(this.vPut);
            this.groupBox5.Controls.Add(this.vannaPut);
            this.groupBox5.Controls.Add(this.gPut);
            this.groupBox5.Controls.Add(this.dPut);
            this.groupBox5.Location = new System.Drawing.Point(558, 178);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(95, 114);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Put";
            // 
            // dgPut
            // 
            this.dgPut.BackColor = System.Drawing.SystemColors.Control;
            this.dgPut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPut.Location = new System.Drawing.Point(20, 265);
            this.dgPut.Name = "dgPut";
            this.dgPut.ReadOnly = true;
            this.dgPut.Size = new System.Drawing.Size(50, 13);
            this.dgPut.TabIndex = 34;
            this.dgPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // volgaPut
            // 
            this.volgaPut.BackColor = System.Drawing.SystemColors.Control;
            this.volgaPut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.volgaPut.Location = new System.Drawing.Point(20, 140);
            this.volgaPut.Name = "volgaPut";
            this.volgaPut.ReadOnly = true;
            this.volgaPut.Size = new System.Drawing.Size(50, 13);
            this.volgaPut.TabIndex = 25;
            this.volgaPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ddPut
            // 
            this.ddPut.BackColor = System.Drawing.SystemColors.Control;
            this.ddPut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ddPut.Location = new System.Drawing.Point(20, 240);
            this.ddPut.Name = "ddPut";
            this.ddPut.ReadOnly = true;
            this.ddPut.Size = new System.Drawing.Size(50, 13);
            this.ddPut.TabIndex = 32;
            this.ddPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rPut
            // 
            this.rPut.BackColor = System.Drawing.SystemColors.Control;
            this.rPut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rPut.Location = new System.Drawing.Point(20, 115);
            this.rPut.Name = "rPut";
            this.rPut.ReadOnly = true;
            this.rPut.Size = new System.Drawing.Size(60, 13);
            this.rPut.TabIndex = 23;
            this.rPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colorPut
            // 
            this.colorPut.BackColor = System.Drawing.SystemColors.Control;
            this.colorPut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorPut.Location = new System.Drawing.Point(20, 215);
            this.colorPut.Name = "colorPut";
            this.colorPut.ReadOnly = true;
            this.colorPut.Size = new System.Drawing.Size(50, 13);
            this.colorPut.TabIndex = 30;
            this.colorPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tPut
            // 
            this.tPut.BackColor = System.Drawing.SystemColors.Control;
            this.tPut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPut.Location = new System.Drawing.Point(20, 90);
            this.tPut.Name = "tPut";
            this.tPut.ReadOnly = true;
            this.tPut.Size = new System.Drawing.Size(60, 13);
            this.tPut.TabIndex = 21;
            this.tPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // charmPut
            // 
            this.charmPut.BackColor = System.Drawing.SystemColors.Control;
            this.charmPut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.charmPut.Location = new System.Drawing.Point(20, 190);
            this.charmPut.Name = "charmPut";
            this.charmPut.ReadOnly = true;
            this.charmPut.Size = new System.Drawing.Size(50, 13);
            this.charmPut.TabIndex = 28;
            this.charmPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // vPut
            // 
            this.vPut.BackColor = System.Drawing.SystemColors.Control;
            this.vPut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vPut.Location = new System.Drawing.Point(20, 65);
            this.vPut.Name = "vPut";
            this.vPut.ReadOnly = true;
            this.vPut.Size = new System.Drawing.Size(60, 13);
            this.vPut.TabIndex = 19;
            this.vPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // vannaPut
            // 
            this.vannaPut.BackColor = System.Drawing.SystemColors.Control;
            this.vannaPut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vannaPut.Location = new System.Drawing.Point(20, 165);
            this.vannaPut.Name = "vannaPut";
            this.vannaPut.ReadOnly = true;
            this.vannaPut.Size = new System.Drawing.Size(50, 13);
            this.vannaPut.TabIndex = 27;
            this.vannaPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gPut
            // 
            this.gPut.BackColor = System.Drawing.SystemColors.Control;
            this.gPut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gPut.Location = new System.Drawing.Point(20, 40);
            this.gPut.Name = "gPut";
            this.gPut.ReadOnly = true;
            this.gPut.Size = new System.Drawing.Size(60, 13);
            this.gPut.TabIndex = 17;
            this.gPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dPut
            // 
            this.dPut.BackColor = System.Drawing.SystemColors.Control;
            this.dPut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dPut.Location = new System.Drawing.Point(20, 15);
            this.dPut.Name = "dPut";
            this.dPut.ReadOnly = true;
            this.dPut.Size = new System.Drawing.Size(60, 13);
            this.dPut.TabIndex = 15;
            this.dPut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGamma
            // 
            this.lblGamma.AutoSize = true;
            this.lblGamma.Location = new System.Drawing.Point(406, 221);
            this.lblGamma.Name = "lblGamma";
            this.lblGamma.Size = new System.Drawing.Size(43, 13);
            this.lblGamma.TabIndex = 28;
            this.lblGamma.Text = "Gamma";
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.Location = new System.Drawing.Point(406, 198);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(32, 13);
            this.lblDelta.TabIndex = 29;
            this.lblDelta.Text = "Delta";
            // 
            // lblVega
            // 
            this.lblVega.AutoSize = true;
            this.lblVega.Location = new System.Drawing.Point(408, 243);
            this.lblVega.Name = "lblVega";
            this.lblVega.Size = new System.Drawing.Size(32, 13);
            this.lblVega.TabIndex = 30;
            this.lblVega.Text = "Vega";
            // 
            // lblTheta
            // 
            this.lblTheta.AutoSize = true;
            this.lblTheta.Location = new System.Drawing.Point(409, 267);
            this.lblTheta.Name = "lblTheta";
            this.lblTheta.Size = new System.Drawing.Size(35, 13);
            this.lblTheta.TabIndex = 31;
            this.lblTheta.Text = "Theta";
            // 
            // chkGreek
            // 
            this.chkGreek.AutoSize = true;
            this.chkGreek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreek.Location = new System.Drawing.Point(409, 155);
            this.chkGreek.Name = "chkGreek";
            this.chkGreek.Size = new System.Drawing.Size(60, 17);
            this.chkGreek.TabIndex = 32;
            this.chkGreek.Text = "Greeks";
            this.chkGreek.UseVisualStyleBackColor = true;
            this.chkGreek.CheckedChanged += new System.EventHandler(this.chkGreek_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 362);
            this.Controls.Add(this.chkGreek);
            this.Controls.Add(this.lblTheta);
            this.Controls.Add(this.lblVega);
            this.Controls.Add(this.lblDelta);
            this.Controls.Add(this.lblGamma);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.chkDividents);
            this.Controls.Add(this.txtDivident);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkPut);
            this.Controls.Add(this.chkCall);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateNow);
            this.Controls.Add(this.txtPutPrice);
            this.Controls.Add(this.txtCallPrice);
            this.Controls.Add(this.txtRiskRate);
            this.Controls.Add(this.txtStrikePrice);
            this.Controls.Add(this.txtVolatility);
            this.Controls.Add(this.txtStockPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Black Scholes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStockPrice;
        private System.Windows.Forms.TextBox txtVolatility;
        private System.Windows.Forms.TextBox txtStrikePrice;
        private System.Windows.Forms.TextBox txtRiskRate;
        private System.Windows.Forms.TextBox txtCallPrice;
        private System.Windows.Forms.TextBox txtPutPrice;
        private System.Windows.Forms.DateTimePicker dateNow;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkCall;
        private System.Windows.Forms.CheckBox chkPut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDivident;
        private System.Windows.Forms.CheckBox chkDividents;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox dgCall;
        private System.Windows.Forms.TextBox volgaCall;
        private System.Windows.Forms.TextBox ddCall;
        private System.Windows.Forms.TextBox rCall;
        private System.Windows.Forms.TextBox colorCall;
        private System.Windows.Forms.TextBox tCall;
        private System.Windows.Forms.TextBox charmCall;
        private System.Windows.Forms.TextBox vCall;
        private System.Windows.Forms.TextBox vannaCall;
        private System.Windows.Forms.TextBox gCall;
        private System.Windows.Forms.TextBox dCall;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox dgPut;
        private System.Windows.Forms.TextBox volgaPut;
        private System.Windows.Forms.TextBox ddPut;
        private System.Windows.Forms.TextBox rPut;
        private System.Windows.Forms.TextBox colorPut;
        private System.Windows.Forms.TextBox tPut;
        private System.Windows.Forms.TextBox charmPut;
        private System.Windows.Forms.TextBox vPut;
        private System.Windows.Forms.TextBox vannaPut;
        private System.Windows.Forms.TextBox gPut;
        private System.Windows.Forms.TextBox dPut;
        private System.Windows.Forms.Label lblGamma;
        private System.Windows.Forms.Label lblDelta;
        private System.Windows.Forms.Label lblVega;
        private System.Windows.Forms.Label lblTheta;
        private System.Windows.Forms.CheckBox chkGreek;
    }
}

