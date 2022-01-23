
namespace ATM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1inputMoney = new System.Windows.Forms.Button();
            this.btn2endWork = new System.Windows.Forms.Button();
            this.btn3outMoney = new System.Windows.Forms.Button();
            this.btn4showATM = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn5_OK = new System.Windows.Forms.Button();
            this.btn6hideShowAtm = new System.Windows.Forms.Button();
            this.btn7moneyOutHide = new System.Windows.Forms.Button();
            this.btn8moneyInHide = new System.Windows.Forms.Button();
            this.btn9hideUserName = new System.Windows.Forms.Button();
            this.btnChangeUser = new System.Windows.Forms.Button();
            this.lblMoneyDeposit = new System.Windows.Forms.Label();
            this.lblChooseBanknotes = new System.Windows.Forms.Label();
            this.lbl5000 = new System.Windows.Forms.Label();
            this.lbl2000 = new System.Windows.Forms.Label();
            this.lbl1000 = new System.Windows.Forms.Label();
            this.lbl500 = new System.Windows.Forms.Label();
            this.lbl200 = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lbl50 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.numericUpDown5000 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2000 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1000 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown500 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown200 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown100 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown50 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.lblPlanSumOnAccAdd = new System.Windows.Forms.Label();
            this.tbSumIntoAcc = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSumInATMNow = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblCountBanknotesNow = new System.Windows.Forms.Label();
            this.tbSummOnAccNow = new System.Windows.Forms.TextBox();
            this.lblTitleSumOnAcc = new System.Windows.Forms.Label();
            this.tbBancnotesCountInRange = new System.Windows.Forms.TextBox();
            this.lblAllRangeBancnotesInATV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5000)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2000)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1000)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown200)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1inputMoney
            // 
            this.btn1inputMoney.Location = new System.Drawing.Point(76, 156);
            this.btn1inputMoney.Name = "btn1inputMoney";
            this.btn1inputMoney.Size = new System.Drawing.Size(271, 50);
            this.btn1inputMoney.TabIndex = 0;
            this.btn1inputMoney.Text = "Внести деньги";
            this.btn1inputMoney.UseVisualStyleBackColor = true;
            this.btn1inputMoney.Click += new System.EventHandler(this.btn1inputMoney_Click);
            // 
            // btn2endWork
            // 
            this.btn2endWork.Location = new System.Drawing.Point(73, 494);
            this.btn2endWork.Name = "btn2endWork";
            this.btn2endWork.Size = new System.Drawing.Size(271, 60);
            this.btn2endWork.TabIndex = 1;
            this.btn2endWork.Text = "Завершить работу\r\nбанкомата\r\n";
            this.btn2endWork.UseVisualStyleBackColor = true;
            this.btn2endWork.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn3outMoney
            // 
            this.btn3outMoney.Location = new System.Drawing.Point(76, 230);
            this.btn3outMoney.Name = "btn3outMoney";
            this.btn3outMoney.Size = new System.Drawing.Size(271, 45);
            this.btn3outMoney.TabIndex = 2;
            this.btn3outMoney.Text = "Снять деньги";
            this.btn3outMoney.UseVisualStyleBackColor = true;
            this.btn3outMoney.Click += new System.EventHandler(this.btn3outMoney_Click);
            // 
            // btn4showATM
            // 
            this.btn4showATM.Location = new System.Drawing.Point(76, 301);
            this.btn4showATM.Name = "btn4showATM";
            this.btn4showATM.Size = new System.Drawing.Size(271, 51);
            this.btn4showATM.TabIndex = 3;
            this.btn4showATM.Text = "Показать состояние ATM";
            this.btn4showATM.UseVisualStyleBackColor = true;
            this.btn4showATM.Click += new System.EventHandler(this.btn4showATM_Click);
            // 
            // lblHello
            // 
            this.lblHello.Location = new System.Drawing.Point(76, 19);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(192, 40);
            this.lblHello.TabIndex = 4;
            this.lblHello.Text = "Здравствуйте,              Гость\r\nВведите  Логин  и нажмите OK\r\n\r\n\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 50);
            this.textBox1.TabIndex = 5;
            // 
            // btn5_OK
            // 
            this.btn5_OK.Location = new System.Drawing.Point(269, 87);
            this.btn5_OK.Name = "btn5_OK";
            this.btn5_OK.Size = new System.Drawing.Size(75, 49);
            this.btn5_OK.TabIndex = 6;
            this.btn5_OK.Text = "OK";
            this.btn5_OK.UseVisualStyleBackColor = true;
            this.btn5_OK.Click += new System.EventHandler(this.btn5_OK_Click);
            // 
            // btn6hideShowAtm
            // 
            this.btn6hideShowAtm.Location = new System.Drawing.Point(76, 300);
            this.btn6hideShowAtm.Name = "btn6hideShowAtm";
            this.btn6hideShowAtm.Size = new System.Drawing.Size(271, 51);
            this.btn6hideShowAtm.TabIndex = 7;
            this.btn6hideShowAtm.Text = "Нет доступа на проверку ATM";
            this.btn6hideShowAtm.UseVisualStyleBackColor = true;
            this.btn6hideShowAtm.Visible = false;
            // 
            // btn7moneyOutHide
            // 
            this.btn7moneyOutHide.Location = new System.Drawing.Point(76, 230);
            this.btn7moneyOutHide.Name = "btn7moneyOutHide";
            this.btn7moneyOutHide.Size = new System.Drawing.Size(271, 45);
            this.btn7moneyOutHide.TabIndex = 8;
            this.btn7moneyOutHide.Text = "Недоступно";
            this.btn7moneyOutHide.UseVisualStyleBackColor = true;
            this.btn7moneyOutHide.Visible = false;
            // 
            // btn8moneyInHide
            // 
            this.btn8moneyInHide.Location = new System.Drawing.Point(76, 156);
            this.btn8moneyInHide.Name = "btn8moneyInHide";
            this.btn8moneyInHide.Size = new System.Drawing.Size(271, 50);
            this.btn8moneyInHide.TabIndex = 9;
            this.btn8moneyInHide.Text = "Недоступно";
            this.btn8moneyInHide.UseVisualStyleBackColor = true;
            this.btn8moneyInHide.Visible = false;
            // 
            // btn9hideUserName
            // 
            this.btn9hideUserName.Location = new System.Drawing.Point(76, 87);
            this.btn9hideUserName.Name = "btn9hideUserName";
            this.btn9hideUserName.Size = new System.Drawing.Size(174, 50);
            this.btn9hideUserName.TabIndex = 10;
            this.btn9hideUserName.Text = "Выберите действие";
            this.btn9hideUserName.UseVisualStyleBackColor = true;
            this.btn9hideUserName.Visible = false;
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.Location = new System.Drawing.Point(73, 395);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(271, 58);
            this.btnChangeUser.TabIndex = 11;
            this.btnChangeUser.Text = "Завершить сеанс";
            this.btnChangeUser.UseVisualStyleBackColor = true;
            this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // lblMoneyDeposit
            // 
            this.lblMoneyDeposit.AutoSize = true;
            this.lblMoneyDeposit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMoneyDeposit.Location = new System.Drawing.Point(435, 40);
            this.lblMoneyDeposit.Name = "lblMoneyDeposit";
            this.lblMoneyDeposit.Size = new System.Drawing.Size(308, 19);
            this.lblMoneyDeposit.TabIndex = 13;
            this.lblMoneyDeposit.Text = "Выполняется операция по внесению наличных";
            // 
            // lblChooseBanknotes
            // 
            this.lblChooseBanknotes.AutoSize = true;
            this.lblChooseBanknotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChooseBanknotes.Location = new System.Drawing.Point(444, 87);
            this.lblChooseBanknotes.Name = "lblChooseBanknotes";
            this.lblChooseBanknotes.Size = new System.Drawing.Size(291, 38);
            this.lblChooseBanknotes.TabIndex = 14;
            this.lblChooseBanknotes.Text = "Выберите  достоинство купюр в левом поле\r\nи введите количество в правом";
            // 
            // lbl5000
            // 
            this.lbl5000.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl5000.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl5000.Location = new System.Drawing.Point(453, 412);
            this.lbl5000.Name = "lbl5000";
            this.lbl5000.Size = new System.Drawing.Size(55, 25);
            this.lbl5000.TabIndex = 22;
            this.lbl5000.Text = "5000";
            // 
            // lbl2000
            // 
            this.lbl2000.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl2000.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2000.Location = new System.Drawing.Point(453, 372);
            this.lbl2000.Name = "lbl2000";
            this.lbl2000.Size = new System.Drawing.Size(55, 25);
            this.lbl2000.TabIndex = 21;
            this.lbl2000.Text = "2000";
            // 
            // lbl1000
            // 
            this.lbl1000.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl1000.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1000.Location = new System.Drawing.Point(453, 335);
            this.lbl1000.Name = "lbl1000";
            this.lbl1000.Size = new System.Drawing.Size(55, 25);
            this.lbl1000.TabIndex = 20;
            this.lbl1000.Text = "1000";
            // 
            // lbl500
            // 
            this.lbl500.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl500.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl500.Location = new System.Drawing.Point(453, 298);
            this.lbl500.Name = "lbl500";
            this.lbl500.Size = new System.Drawing.Size(55, 25);
            this.lbl500.TabIndex = 19;
            this.lbl500.Text = "500";
            // 
            // lbl200
            // 
            this.lbl200.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl200.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl200.Location = new System.Drawing.Point(453, 260);
            this.lbl200.Name = "lbl200";
            this.lbl200.Size = new System.Drawing.Size(55, 25);
            this.lbl200.TabIndex = 18;
            this.lbl200.Text = "200";
            // 
            // lbl100
            // 
            this.lbl100.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl100.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl100.Location = new System.Drawing.Point(453, 222);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(55, 25);
            this.lbl100.TabIndex = 17;
            this.lbl100.Text = "100";
            // 
            // lbl50
            // 
            this.lbl50.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl50.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl50.Location = new System.Drawing.Point(453, 185);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(55, 25);
            this.lbl50.TabIndex = 16;
            this.lbl50.Text = "50";
            // 
            // lbl10
            // 
            this.lbl10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl10.Location = new System.Drawing.Point(453, 146);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(55, 25);
            this.lbl10.TabIndex = 15;
            this.lbl10.Text = "10";
            // 
            // numericUpDown5000
            // 
            this.numericUpDown5000.Location = new System.Drawing.Point(572, 413);
            this.numericUpDown5000.Name = "numericUpDown5000";
            this.numericUpDown5000.Size = new System.Drawing.Size(72, 23);
            this.numericUpDown5000.TabIndex = 30;
            // 
            // numericUpDown2000
            // 
            this.numericUpDown2000.Location = new System.Drawing.Point(572, 374);
            this.numericUpDown2000.Name = "numericUpDown2000";
            this.numericUpDown2000.Size = new System.Drawing.Size(72, 23);
            this.numericUpDown2000.TabIndex = 29;
            // 
            // numericUpDown1000
            // 
            this.numericUpDown1000.Location = new System.Drawing.Point(572, 336);
            this.numericUpDown1000.Name = "numericUpDown1000";
            this.numericUpDown1000.Size = new System.Drawing.Size(72, 23);
            this.numericUpDown1000.TabIndex = 28;
            // 
            // numericUpDown500
            // 
            this.numericUpDown500.Location = new System.Drawing.Point(572, 300);
            this.numericUpDown500.Name = "numericUpDown500";
            this.numericUpDown500.Size = new System.Drawing.Size(72, 23);
            this.numericUpDown500.TabIndex = 27;
            // 
            // numericUpDown200
            // 
            this.numericUpDown200.Location = new System.Drawing.Point(572, 262);
            this.numericUpDown200.Name = "numericUpDown200";
            this.numericUpDown200.Size = new System.Drawing.Size(72, 23);
            this.numericUpDown200.TabIndex = 26;
            // 
            // numericUpDown100
            // 
            this.numericUpDown100.Location = new System.Drawing.Point(572, 224);
            this.numericUpDown100.Name = "numericUpDown100";
            this.numericUpDown100.Size = new System.Drawing.Size(72, 23);
            this.numericUpDown100.TabIndex = 25;
            // 
            // numericUpDown50
            // 
            this.numericUpDown50.Location = new System.Drawing.Point(572, 186);
            this.numericUpDown50.Name = "numericUpDown50";
            this.numericUpDown50.Size = new System.Drawing.Size(72, 23);
            this.numericUpDown50.TabIndex = 24;
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Location = new System.Drawing.Point(572, 148);
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(72, 23);
            this.numericUpDown10.TabIndex = 23;
            // 
            // lblPlanSumOnAccAdd
            // 
            this.lblPlanSumOnAccAdd.Location = new System.Drawing.Point(737, 125);
            this.lblPlanSumOnAccAdd.Name = "lblPlanSumOnAccAdd";
            this.lblPlanSumOnAccAdd.Size = new System.Drawing.Size(221, 38);
            this.lblPlanSumOnAccAdd.TabIndex = 31;
            this.lblPlanSumOnAccAdd.Text = "Нажмите на этот текст для проверки \r\nвносимой суммы\r\n";
            this.lblPlanSumOnAccAdd.Click += new System.EventHandler(this.lblPlanSumOnAccAdd_Click);
            // 
            // tbSumIntoAcc
            // 
            this.tbSumIntoAcc.Location = new System.Drawing.Point(700, 174);
            this.tbSumIntoAcc.Name = "tbSumIntoAcc";
            this.tbSumIntoAcc.ReadOnly = true;
            this.tbSumIntoAcc.Size = new System.Drawing.Size(258, 23);
            this.tbSumIntoAcc.TabIndex = 32;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.CausesValidation = false;
            this.lblCapacity.Location = new System.Drawing.Point(720, 413);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(51, 15);
            this.lblCapacity.TabIndex = 35;
            this.lblCapacity.Text = "capacity";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(720, 395);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(105, 15);
            this.lblnumber.TabIndex = 34;
            this.lblnumber.Text = "номер банкомата";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.CausesValidation = false;
            this.lblDate.Location = new System.Drawing.Point(720, 359);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 15);
            this.lblDate.TabIndex = 33;
            this.lblDate.Text = "дата";
            // 
            // lblSumInATMNow
            // 
            this.lblSumInATMNow.AutoSize = true;
            this.lblSumInATMNow.Location = new System.Drawing.Point(720, 513);
            this.lblSumInATMNow.Name = "lblSumInATMNow";
            this.lblSumInATMNow.Size = new System.Drawing.Size(155, 15);
            this.lblSumInATMNow.TabIndex = 37;
            this.lblSumInATMNow.Text = "сейчас сумма в банкомате";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(700, 223);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(258, 23);
            this.btnConfirm.TabIndex = 38;
            this.btnConfirm.Text = "Подтвердить";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblCountBanknotesNow
            // 
            this.lblCountBanknotesNow.AutoSize = true;
            this.lblCountBanknotesNow.Location = new System.Drawing.Point(720, 473);
            this.lblCountBanknotesNow.Name = "lblCountBanknotesNow";
            this.lblCountBanknotesNow.Size = new System.Drawing.Size(123, 15);
            this.lblCountBanknotesNow.TabIndex = 39;
            this.lblCountBanknotesNow.Text = "банкнот в банкомате";
            // 
            // tbSummOnAccNow
            // 
            this.tbSummOnAccNow.Location = new System.Drawing.Point(700, 293);
            this.tbSummOnAccNow.Name = "tbSummOnAccNow";
            this.tbSummOnAccNow.ReadOnly = true;
            this.tbSummOnAccNow.Size = new System.Drawing.Size(258, 23);
            this.tbSummOnAccNow.TabIndex = 40;
            // 
            // lblTitleSumOnAcc
            // 
            this.lblTitleSumOnAcc.Location = new System.Drawing.Point(700, 262);
            this.lblTitleSumOnAcc.Name = "lblTitleSumOnAcc";
            this.lblTitleSumOnAcc.Size = new System.Drawing.Size(146, 23);
            this.lblTitleSumOnAcc.TabIndex = 41;
            this.lblTitleSumOnAcc.Text = "Сумма на вашем счете";
            // 
            // tbBancnotesCountInRange
            // 
            this.tbBancnotesCountInRange.Location = new System.Drawing.Point(412, 531);
            this.tbBancnotesCountInRange.Name = "tbBancnotesCountInRange";
            this.tbBancnotesCountInRange.Size = new System.Drawing.Size(232, 23);
            this.tbBancnotesCountInRange.TabIndex = 42;
            this.tbBancnotesCountInRange.Text = "Админу кол-во банкнот каждого вида";
            // 
            // lblAllRangeBancnotesInATV
            // 
            this.lblAllRangeBancnotesInATV.Location = new System.Drawing.Point(412, 491);
            this.lblAllRangeBancnotesInATV.Name = "lblAllRangeBancnotesInATV";
            this.lblAllRangeBancnotesInATV.Size = new System.Drawing.Size(266, 37);
            this.lblAllRangeBancnotesInATV.TabIndex = 43;
            this.lblAllRangeBancnotesInATV.Text = "Количество банкнот  каждого номинала\r\n10    50    100   200   500   1000  2000  5" +
    "000  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 587);
            this.Controls.Add(this.lblAllRangeBancnotesInATV);
            this.Controls.Add(this.tbBancnotesCountInRange);
            this.Controls.Add(this.lblTitleSumOnAcc);
            this.Controls.Add(this.tbSummOnAccNow);
            this.Controls.Add(this.lblCountBanknotesNow);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblSumInATMNow);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.tbSumIntoAcc);
            this.Controls.Add(this.lblPlanSumOnAccAdd);
            this.Controls.Add(this.numericUpDown5000);
            this.Controls.Add(this.numericUpDown2000);
            this.Controls.Add(this.numericUpDown1000);
            this.Controls.Add(this.numericUpDown500);
            this.Controls.Add(this.numericUpDown200);
            this.Controls.Add(this.numericUpDown100);
            this.Controls.Add(this.numericUpDown50);
            this.Controls.Add(this.numericUpDown10);
            this.Controls.Add(this.lbl5000);
            this.Controls.Add(this.lbl2000);
            this.Controls.Add(this.lbl1000);
            this.Controls.Add(this.lbl500);
            this.Controls.Add(this.lbl200);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.lbl50);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lblChooseBanknotes);
            this.Controls.Add(this.lblMoneyDeposit);
            this.Controls.Add(this.btnChangeUser);
            this.Controls.Add(this.btn9hideUserName);
            this.Controls.Add(this.btn8moneyInHide);
            this.Controls.Add(this.btn7moneyOutHide);
            this.Controls.Add(this.btn6hideShowAtm);
            this.Controls.Add(this.btn5_OK);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btn4showATM);
            this.Controls.Add(this.btn3outMoney);
            this.Controls.Add(this.btn2endWork);
            this.Controls.Add(this.btn1inputMoney);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM_Hello_page";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5000)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2000)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1000)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown500)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown200)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1inputMoney;
        private System.Windows.Forms.Button btn2endWork;
        private System.Windows.Forms.Button btn3outMoney;
        private System.Windows.Forms.Button btn4showATM;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn5_OK;
        private System.Windows.Forms.Button btn6hideShowAtm;
        private System.Windows.Forms.Button btn7moneyOutHide;
        private System.Windows.Forms.Button btn8moneyInHide;
        private System.Windows.Forms.Button btn9hideUserName;
        private System.Windows.Forms.Button btnChangeUser;

        private System.Windows.Forms.Label lblMoneyDeposit;
        private System.Windows.Forms.Label lblChooseBanknotes;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl50;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lbl200;
        private System.Windows.Forms.Label lbl500;
        private System.Windows.Forms.Label lbl1000;
        private System.Windows.Forms.Label lbl2000;
        private System.Windows.Forms.Label lbl5000;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.NumericUpDown numericUpDown50;
        private System.Windows.Forms.NumericUpDown numericUpDown100;
        private System.Windows.Forms.NumericUpDown numericUpDown200;
        private System.Windows.Forms.NumericUpDown numericUpDown500;
        private System.Windows.Forms.NumericUpDown numericUpDown1000;
        private System.Windows.Forms.NumericUpDown numericUpDown2000;
        private System.Windows.Forms.NumericUpDown numericUpDown5000;
        private System.Windows.Forms.Label lblPlanSumOnAccAdd;
        private System.Windows.Forms.TextBox tbSumIntoAcc;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSumInATMNow;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblCountBanknotesNow;
        private System.Windows.Forms.TextBox tbSummOnAccNow;
        private System.Windows.Forms.Label lblTitleSumOnAcc;
        private System.Windows.Forms.TextBox tbBancnotesCountInRange;
        private System.Windows.Forms.Label lblAllRangeBancnotesInATV;
    }
}

