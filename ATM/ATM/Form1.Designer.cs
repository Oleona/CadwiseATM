
namespace ATM
{
    partial class AtmForm
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
            this.lbl5000Rubbles = new System.Windows.Forms.Label();
            this.lbl2000Rubbles = new System.Windows.Forms.Label();
            this.lbl1000Rubbles = new System.Windows.Forms.Label();
            this.lbl500Rubbles = new System.Windows.Forms.Label();
            this.lbl200Rubbles = new System.Windows.Forms.Label();
            this.lbl100Rubbles = new System.Windows.Forms.Label();
            this.lbl50Rubbles = new System.Windows.Forms.Label();
            this.lbl10Rubbles = new System.Windows.Forms.Label();
            this.num5000Rubbles = new System.Windows.Forms.NumericUpDown();
            this.num2000Rubbles = new System.Windows.Forms.NumericUpDown();
            this.num1000Rubbles = new System.Windows.Forms.NumericUpDown();
            this.num500Rubbles = new System.Windows.Forms.NumericUpDown();
            this.num200Rubbles = new System.Windows.Forms.NumericUpDown();
            this.num100Rubbles = new System.Windows.Forms.NumericUpDown();
            this.num50Rubbles = new System.Windows.Forms.NumericUpDown();
            this.num10Rubbles = new System.Windows.Forms.NumericUpDown();
            this.lblPlanSumOnAccAdd = new System.Windows.Forms.Label();
            this.tbSumIntoAcc = new System.Windows.Forms.TextBox();
            this.lblAtmCapacity = new System.Windows.Forms.Label();
            this.lblAtmNumber = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.lblSumInATMNow = new System.Windows.Forms.Label();
            this.btnConfirmSum = new System.Windows.Forms.Button();
            this.lblCountBanknotesNow = new System.Windows.Forms.Label();
            this.tbSummOnAccNow = new System.Windows.Forms.TextBox();
            this.lblTitleSumOnAcc = new System.Windows.Forms.Label();
            this.tbBancnotesCountInRange = new System.Windows.Forms.TextBox();
            this.lblAllRangeBancnotesInATV = new System.Windows.Forms.Label();
            this.lblChoiceAmountWithdraw = new System.Windows.Forms.Label();
            this.numWithdrawAmount = new System.Windows.Forms.NumericUpDown();
            this.btnConfirmWithdrawalAmount = new System.Windows.Forms.Button();
            this.tbResultWithdrawn = new System.Windows.Forms.TextBox();
            this.lblWithdrawResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num5000Rubbles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2000Rubbles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1000Rubbles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num500Rubbles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num200Rubbles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num100Rubbles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num50Rubbles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num10Rubbles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWithdrawAmount)).BeginInit();
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
            this.lblMoneyDeposit.Location = new System.Drawing.Point(526, 103);
            this.lblMoneyDeposit.Name = "lblMoneyDeposit";
            this.lblMoneyDeposit.Size = new System.Drawing.Size(308, 19);
            this.lblMoneyDeposit.TabIndex = 13;
            this.lblMoneyDeposit.Text = "Выполняется операция по внесению наличных";
            // 
            // lblChooseBanknotes
            // 
            this.lblChooseBanknotes.AutoSize = true;
            this.lblChooseBanknotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChooseBanknotes.Location = new System.Drawing.Point(391, 128);
            this.lblChooseBanknotes.Name = "lblChooseBanknotes";
            this.lblChooseBanknotes.Size = new System.Drawing.Size(252, 30);
            this.lblChooseBanknotes.TabIndex = 14;
            this.lblChooseBanknotes.Text = "Выберите  достоинство купюр в левом поле\r\nи введите количество в правом";
            // 
            // lbl5000Rubbles
            // 
            this.lbl5000Rubbles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl5000Rubbles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl5000Rubbles.Location = new System.Drawing.Point(391, 437);
            this.lbl5000Rubbles.Name = "lbl5000Rubbles";
            this.lbl5000Rubbles.Size = new System.Drawing.Size(55, 25);
            this.lbl5000Rubbles.TabIndex = 22;
            this.lbl5000Rubbles.Text = "5000";
            // 
            // lbl2000Rubbles
            // 
            this.lbl2000Rubbles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl2000Rubbles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl2000Rubbles.Location = new System.Drawing.Point(391, 397);
            this.lbl2000Rubbles.Name = "lbl2000Rubbles";
            this.lbl2000Rubbles.Size = new System.Drawing.Size(55, 25);
            this.lbl2000Rubbles.TabIndex = 21;
            this.lbl2000Rubbles.Text = "2000";
            // 
            // lbl1000Rubbles
            // 
            this.lbl1000Rubbles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl1000Rubbles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1000Rubbles.Location = new System.Drawing.Point(391, 360);
            this.lbl1000Rubbles.Name = "lbl1000Rubbles";
            this.lbl1000Rubbles.Size = new System.Drawing.Size(55, 25);
            this.lbl1000Rubbles.TabIndex = 20;
            this.lbl1000Rubbles.Text = "1000";
            // 
            // lbl500Rubbles
            // 
            this.lbl500Rubbles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl500Rubbles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl500Rubbles.Location = new System.Drawing.Point(391, 323);
            this.lbl500Rubbles.Name = "lbl500Rubbles";
            this.lbl500Rubbles.Size = new System.Drawing.Size(55, 25);
            this.lbl500Rubbles.TabIndex = 19;
            this.lbl500Rubbles.Text = "500";
            // 
            // lbl200Rubbles
            // 
            this.lbl200Rubbles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl200Rubbles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl200Rubbles.Location = new System.Drawing.Point(391, 285);
            this.lbl200Rubbles.Name = "lbl200Rubbles";
            this.lbl200Rubbles.Size = new System.Drawing.Size(55, 25);
            this.lbl200Rubbles.TabIndex = 18;
            this.lbl200Rubbles.Text = "200";
            // 
            // lbl100Rubbles
            // 
            this.lbl100Rubbles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl100Rubbles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl100Rubbles.Location = new System.Drawing.Point(391, 247);
            this.lbl100Rubbles.Name = "lbl100Rubbles";
            this.lbl100Rubbles.Size = new System.Drawing.Size(55, 25);
            this.lbl100Rubbles.TabIndex = 17;
            this.lbl100Rubbles.Text = "100";
            // 
            // lbl50Rubbles
            // 
            this.lbl50Rubbles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl50Rubbles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl50Rubbles.Location = new System.Drawing.Point(391, 210);
            this.lbl50Rubbles.Name = "lbl50Rubbles";
            this.lbl50Rubbles.Size = new System.Drawing.Size(55, 25);
            this.lbl50Rubbles.TabIndex = 16;
            this.lbl50Rubbles.Text = "50";
            // 
            // lbl10Rubbles
            // 
            this.lbl10Rubbles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl10Rubbles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl10Rubbles.Location = new System.Drawing.Point(391, 171);
            this.lbl10Rubbles.Name = "lbl10Rubbles";
            this.lbl10Rubbles.Size = new System.Drawing.Size(55, 25);
            this.lbl10Rubbles.TabIndex = 15;
            this.lbl10Rubbles.Text = "10";
            // 
            // num5000Rubbles
            // 
            this.num5000Rubbles.Location = new System.Drawing.Point(529, 439);
            this.num5000Rubbles.Name = "num5000Rubbles";
            this.num5000Rubbles.Size = new System.Drawing.Size(72, 23);
            this.num5000Rubbles.TabIndex = 30;
            // 
            // num2000Rubbles
            // 
            this.num2000Rubbles.Location = new System.Drawing.Point(529, 400);
            this.num2000Rubbles.Name = "num2000Rubbles";
            this.num2000Rubbles.Size = new System.Drawing.Size(72, 23);
            this.num2000Rubbles.TabIndex = 29;
            // 
            // num1000Rubbles
            // 
            this.num1000Rubbles.Location = new System.Drawing.Point(529, 362);
            this.num1000Rubbles.Name = "num1000Rubbles";
            this.num1000Rubbles.Size = new System.Drawing.Size(72, 23);
            this.num1000Rubbles.TabIndex = 28;
            // 
            // num500Rubbles
            // 
            this.num500Rubbles.Location = new System.Drawing.Point(529, 326);
            this.num500Rubbles.Name = "num500Rubbles";
            this.num500Rubbles.Size = new System.Drawing.Size(72, 23);
            this.num500Rubbles.TabIndex = 27;
            // 
            // num200Rubbles
            // 
            this.num200Rubbles.Location = new System.Drawing.Point(529, 288);
            this.num200Rubbles.Name = "num200Rubbles";
            this.num200Rubbles.Size = new System.Drawing.Size(72, 23);
            this.num200Rubbles.TabIndex = 26;
            // 
            // num100Rubbles
            // 
            this.num100Rubbles.Location = new System.Drawing.Point(529, 250);
            this.num100Rubbles.Name = "num100Rubbles";
            this.num100Rubbles.Size = new System.Drawing.Size(72, 23);
            this.num100Rubbles.TabIndex = 25;
            // 
            // num50Rubbles
            // 
            this.num50Rubbles.Location = new System.Drawing.Point(529, 212);
            this.num50Rubbles.Name = "num50Rubbles";
            this.num50Rubbles.Size = new System.Drawing.Size(72, 23);
            this.num50Rubbles.TabIndex = 24;
            // 
            // num10Rubbles
            // 
            this.num10Rubbles.Location = new System.Drawing.Point(529, 174);
            this.num10Rubbles.Name = "num10Rubbles";
            this.num10Rubbles.Size = new System.Drawing.Size(72, 23);
            this.num10Rubbles.TabIndex = 23;
            // 
            // lblPlanSumOnAccAdd
            // 
            this.lblPlanSumOnAccAdd.Location = new System.Drawing.Point(700, 130);
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
            // lblAtmCapacity
            // 
            this.lblAtmCapacity.AutoSize = true;
            this.lblAtmCapacity.CausesValidation = false;
            this.lblAtmCapacity.Location = new System.Drawing.Point(720, 413);
            this.lblAtmCapacity.Name = "lblAtmCapacity";
            this.lblAtmCapacity.Size = new System.Drawing.Size(79, 15);
            this.lblAtmCapacity.TabIndex = 35;
            this.lblAtmCapacity.Text = "вместимость";
            // 
            // lblAtmNumber
            // 
            this.lblAtmNumber.AutoSize = true;
            this.lblAtmNumber.Location = new System.Drawing.Point(720, 395);
            this.lblAtmNumber.Name = "lblAtmNumber";
            this.lblAtmNumber.Size = new System.Drawing.Size(105, 15);
            this.lblAtmNumber.TabIndex = 34;
            this.lblAtmNumber.Text = "номер банкомата";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.CausesValidation = false;
            this.lblCurrentDate.Location = new System.Drawing.Point(720, 359);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(30, 15);
            this.lblCurrentDate.TabIndex = 33;
            this.lblCurrentDate.Text = "дата";
            // 
            // lblSumInATMNow
            // 
            this.lblSumInATMNow.AutoSize = true;
            this.lblSumInATMNow.Location = new System.Drawing.Point(720, 513);
            this.lblSumInATMNow.Name = "lblSumInATMNow";
            this.lblSumInATMNow.Size = new System.Drawing.Size(114, 15);
            this.lblSumInATMNow.TabIndex = 37;
            this.lblSumInATMNow.Text = "сумма в банкомате";
            // 
            // btnConfirmSum
            // 
            this.btnConfirmSum.Location = new System.Drawing.Point(700, 223);
            this.btnConfirmSum.Name = "btnConfirmSum";
            this.btnConfirmSum.Size = new System.Drawing.Size(258, 23);
            this.btnConfirmSum.TabIndex = 38;
            this.btnConfirmSum.Text = "Подтвердить";
            this.btnConfirmSum.UseVisualStyleBackColor = true;
            this.btnConfirmSum.Click += new System.EventHandler(this.btnConfirm_Click);
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
            // lblChoiceAmountWithdraw
            // 
            this.lblChoiceAmountWithdraw.Location = new System.Drawing.Point(391, 31);
            this.lblChoiceAmountWithdraw.Name = "lblChoiceAmountWithdraw";
            this.lblChoiceAmountWithdraw.Size = new System.Drawing.Size(233, 21);
            this.lblChoiceAmountWithdraw.TabIndex = 44;
            this.lblChoiceAmountWithdraw.Text = "Введите сумму для снятия и нажмите ОК\r\n";
            this.lblChoiceAmountWithdraw.Visible = false;
            // 
            // numWithdrawAmount
            // 
            this.numWithdrawAmount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numWithdrawAmount.Location = new System.Drawing.Point(391, 55);
            this.numWithdrawAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numWithdrawAmount.Name = "numWithdrawAmount";
            this.numWithdrawAmount.Size = new System.Drawing.Size(148, 23);
            this.numWithdrawAmount.TabIndex = 45;
            // 
            // btnConfirmWithdrawalAmount
            // 
            this.btnConfirmWithdrawalAmount.Location = new System.Drawing.Point(555, 55);
            this.btnConfirmWithdrawalAmount.Name = "btnConfirmWithdrawalAmount";
            this.btnConfirmWithdrawalAmount.Size = new System.Drawing.Size(46, 23);
            this.btnConfirmWithdrawalAmount.TabIndex = 46;
            this.btnConfirmWithdrawalAmount.Text = "OK";
            this.btnConfirmWithdrawalAmount.UseVisualStyleBackColor = true;
            this.btnConfirmWithdrawalAmount.Visible = false;
            this.btnConfirmWithdrawalAmount.Click += new System.EventHandler(this.btnConfirmWithdrawalAmount_Click);
            // 
            // tbResultWithdrawn
            // 
            this.tbResultWithdrawn.Enabled = false;
            this.tbResultWithdrawn.Location = new System.Drawing.Point(677, 54);
            this.tbResultWithdrawn.Name = "tbResultWithdrawn";
            this.tbResultWithdrawn.Size = new System.Drawing.Size(281, 23);
            this.tbResultWithdrawn.TabIndex = 47;
            this.tbResultWithdrawn.Visible = false;
            // 
            // lblWithdrawResult
            // 
            this.lblWithdrawResult.AutoSize = true;
            this.lblWithdrawResult.CausesValidation = false;
            this.lblWithdrawResult.Location = new System.Drawing.Point(677, 31);
            this.lblWithdrawResult.Name = "lblWithdrawResult";
            this.lblWithdrawResult.Size = new System.Drawing.Size(103, 15);
            this.lblWithdrawResult.TabIndex = 48;
            this.lblWithdrawResult.Text = "Результат снятия:";
            this.lblWithdrawResult.Visible = false;
            // 
            // AtmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 587);
            this.Controls.Add(this.lblWithdrawResult);
            this.Controls.Add(this.tbResultWithdrawn);
            this.Controls.Add(this.btnConfirmWithdrawalAmount);
            this.Controls.Add(this.numWithdrawAmount);
            this.Controls.Add(this.lblChoiceAmountWithdraw);
            this.Controls.Add(this.lblAllRangeBancnotesInATV);
            this.Controls.Add(this.tbBancnotesCountInRange);
            this.Controls.Add(this.lblTitleSumOnAcc);
            this.Controls.Add(this.tbSummOnAccNow);
            this.Controls.Add(this.lblCountBanknotesNow);
            this.Controls.Add(this.btnConfirmSum);
            this.Controls.Add(this.lblSumInATMNow);
            this.Controls.Add(this.lblAtmCapacity);
            this.Controls.Add(this.lblAtmNumber);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.tbSumIntoAcc);
            this.Controls.Add(this.lblPlanSumOnAccAdd);
            this.Controls.Add(this.num5000Rubbles);
            this.Controls.Add(this.num2000Rubbles);
            this.Controls.Add(this.num1000Rubbles);
            this.Controls.Add(this.num500Rubbles);
            this.Controls.Add(this.num200Rubbles);
            this.Controls.Add(this.num100Rubbles);
            this.Controls.Add(this.num50Rubbles);
            this.Controls.Add(this.num10Rubbles);
            this.Controls.Add(this.lbl5000Rubbles);
            this.Controls.Add(this.lbl2000Rubbles);
            this.Controls.Add(this.lbl1000Rubbles);
            this.Controls.Add(this.lbl500Rubbles);
            this.Controls.Add(this.lbl200Rubbles);
            this.Controls.Add(this.lbl100Rubbles);
            this.Controls.Add(this.lbl50Rubbles);
            this.Controls.Add(this.lbl10Rubbles);
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
            this.Name = "AtmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            ((System.ComponentModel.ISupportInitialize)(this.num5000Rubbles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2000Rubbles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1000Rubbles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num500Rubbles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num200Rubbles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num100Rubbles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num50Rubbles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num10Rubbles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWithdrawAmount)).EndInit();
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
        private System.Windows.Forms.Label lbl10Rubbles;
        private System.Windows.Forms.Label lbl50Rubbles;
        private System.Windows.Forms.Label lbl100Rubbles;
        private System.Windows.Forms.Label lbl200Rubbles;
        private System.Windows.Forms.Label lbl500Rubbles;
        private System.Windows.Forms.Label lbl1000Rubbles;
        private System.Windows.Forms.Label lbl2000Rubbles;
        private System.Windows.Forms.Label lbl5000Rubbles;
        private System.Windows.Forms.NumericUpDown num10Rubbles;
        private System.Windows.Forms.NumericUpDown num50Rubbles;
        private System.Windows.Forms.NumericUpDown num100Rubbles;
        private System.Windows.Forms.NumericUpDown num200Rubbles;
        private System.Windows.Forms.NumericUpDown num500Rubbles;
        private System.Windows.Forms.NumericUpDown num1000Rubbles;
        private System.Windows.Forms.NumericUpDown num2000Rubbles;
        private System.Windows.Forms.NumericUpDown num5000Rubbles;
        private System.Windows.Forms.Label lblPlanSumOnAccAdd;
        private System.Windows.Forms.TextBox tbSumIntoAcc;
        private System.Windows.Forms.Label lblAtmCapacity;
        private System.Windows.Forms.Label lblAtmNumber;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Label lblSumInATMNow;
        private System.Windows.Forms.Button btnConfirmSum;
        private System.Windows.Forms.Label lblCountBanknotesNow;
        private System.Windows.Forms.TextBox tbSummOnAccNow;
        private System.Windows.Forms.Label lblTitleSumOnAcc;
        private System.Windows.Forms.TextBox tbBancnotesCountInRange;
        private System.Windows.Forms.Label lblAllRangeBancnotesInATV;
        private System.Windows.Forms.Label lblChoiceAmountWithdraw;
        private System.Windows.Forms.NumericUpDown numWithdrawAmount;
        private System.Windows.Forms.Button btnConfirmWithdrawalAmount;
        private System.Windows.Forms.TextBox tbResultWithdrawn;
        private System.Windows.Forms.Label lblWithdrawResult;
    }
}

