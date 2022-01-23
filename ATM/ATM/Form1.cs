using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        public int RublesCount10
        {
            get { return (int)numericUpDown10.Value; }
            set { numericUpDown10.Value = value; }
        }
        public int RublesCount50
        {
            get { return (int)numericUpDown50.Value; }
            set { numericUpDown50.Value = value; }
        }
        public int RublesCount100
        {
            get { return (int)numericUpDown100.Value; }
            set { numericUpDown100.Value = value; }
        }
        public int RublesCount200
        {
            get { return (int)numericUpDown200.Value; }
            set { numericUpDown200.Value = value; }
        }
        public int RublesCount500
        {
            get { return (int)numericUpDown500.Value; }
            set { numericUpDown500.Value = value; }
        }
        public int RublesCount1000
        {
            get { return (int)numericUpDown1000.Value; }
            set { numericUpDown1000.Value = value; }
        }
        public int RublesCount2000
        {
            get { return (int)numericUpDown2000.Value; }
            set { numericUpDown2000.Value = value; }
        }
        public int RublesCount5000
        {
            get { return (int)numericUpDown5000.Value; }
            set { numericUpDown5000.Value = value; }
        }

        public string UserName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        private void NumericVisibleYes() => Controls.OfType<NumericUpDown>().ToList().ForEach(c => c.Visible = true);

        private void NumericVisibleNo() => Controls.OfType<NumericUpDown>().ToList().ForEach(c => c.Visible = false);

        private void NumericValue_0() => Controls.OfType<NumericUpDown>().ToList().ForEach(c => c.Value = 0);

        private void LblNominalVisibleYes()
        {
            lbl10.Visible = true; lbl50.Visible = true; lbl100.Visible = true; lbl200.Visible = true;
            lbl500.Visible = true; lbl1000.Visible = true; lbl2000.Visible = true; lbl5000.Visible = true;
        }
        private void LblNominalVisibleNo()
        {
            lbl10.Visible = false; lbl50.Visible = false; lbl100.Visible = false; lbl200.Visible = false;
            lbl500.Visible = false; lbl1000.Visible = false; lbl2000.Visible = false; lbl5000.Visible = false;
        }


        public Form1()
        {
            InitializeComponent();
            NumericVisibleNo();
            LblNominalVisibleNo();

            InitializeVisibilities();
        }

        private void btn1inputMoney_Click(object sender, EventArgs e)
        {
            NumericVisibleYes();
            NumericValue_0();
            tbSumIntoAcc.Visible = true;
            lblPlanSumOnAccAdd.Visible = true;
            lblPlanSumOnAccAdd.Text = "Нажмите на этот текст для проверки вносимой суммы";
            lblMoneyDeposit.Visible = true;
            lblMoneyDeposit.Text = "Выполняется операция по внесению наличных";
            tbSumIntoAcc.Text = String.Empty;
            btnConfirm.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn3outMoney_Click(object sender, EventArgs e)
        {
            NumericVisibleYes();
            NumericValue_0();
            tbSumIntoAcc.Visible = true;
            lblPlanSumOnAccAdd.Visible = true;
            lblPlanSumOnAccAdd.Text = "Нажмите на этот текст для проверки выводимой суммы";
            lblMoneyDeposit.Text = "Выполняется операция по снятию наличных";
            lblMoneyDeposit.Visible = true;
            tbSumIntoAcc.Text = String.Empty;
            btnConfirm.Enabled = true;
        }

        private void btn4showATM_Click(object sender, EventArgs e)
        {
            lblDate.Text = ATM.GetDate();
            lblnumber.Text = ATM.GetATMNumber();
            lblCapacity.Text = ATM.GetMaxBanknotesCapacityToString();
            tbBancnotesCountInRange.Text = ATM.ShowState();
            lblCountBanknotesNow.Text = "Количество купюр в банкомате      " + ATM.TotalBanknotesCount;
            lblSumInATMNow.Text = "Сумма в банкомате      " + ATM.TotalMoney;
            ShowForATMState();
        }


        private void btn5_OK_Click(object sender, EventArgs e)
        {
            if (UserName == "Админ")
            {
                ShowForAdmin();
                return;
            }

            if (!ATM.Users.Keys.Contains(UserName))
            {
                ShowForUnknownUser();
            }
            else
            {
                ShowForLoginedUser();
            }
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            ShowForChangedUser();
        }

        /// <summary>
        /// Не только для добавить, но и для снять кнопка проверки планируемой суммы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPlanSumOnAccAdd_Click(object sender, EventArgs e)
        {
            var banknotesByDenominations = CreateBanknotesByDenominations();

            if (lblPlanSumOnAccAdd.Text == "Нажмите на этот текст для проверки вносимой суммы")
            {
                AddOnUserAccount(banknotesByDenominations);
            }
            else
            {
                WithdrawFromUserAccount(banknotesByDenominations);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var operationIsAddition = lblPlanSumOnAccAdd.Text == "Нажмите на этот текст для проверки вносимой суммы";
            var banknotesByDenominations = CreateBanknotesByDenominations();

            if (operationIsAddition)
            {
                ATM.AddMoney(UserName, banknotesByDenominations);
            }
            else
            {
                ATM.WithdrawMoney(UserName, banknotesByDenominations);
            }

            tbSummOnAccNow.Text = ATM.Users[UserName].ToString();

            tbSumIntoAcc.Visible = false;
            lblPlanSumOnAccAdd.Visible = false;
            NumericVisibleNo();
            btnConfirm.Enabled = false;
        }

        private void AddOnUserAccount(BanknotesByDenominations banknotesByDenominations)
        {
            var banknotesToAddCount = banknotesByDenominations.GetTotalBanknotesCount();
            if (ATM.TotalBanknotesCount + banknotesToAddCount > ATM.GetMaxBanknotesCapacity())
            {
                tbSumIntoAcc.Visible = true;
                tbSumIntoAcc.Text = "Банкомат переполнен  ";
                btnConfirm.Enabled = false;
                btnConfirm.Visible = false;
            }
            else
            {
                tbSumIntoAcc.Text = banknotesByDenominations.GetPlanSumToAddOrWithdraw().ToString();
                btnConfirm.Visible = true;
                tbSumIntoAcc.Visible = true;
            }
        }

        private void WithdrawFromUserAccount(BanknotesByDenominations banknotesByDenominations)
        {
            var sumToWithdraw = banknotesByDenominations.GetPlanSumToAddOrWithdraw();
            int userDepositValue = ATM.Users[UserName];

            if (sumToWithdraw > userDepositValue)
            {
                tbSumIntoAcc.Visible = true;
                tbSumIntoAcc.Text = "На счете недостаточно средств";
                btnConfirm.Enabled = false;
                return;
            }

            if (sumToWithdraw > ATM.TotalMoney)
            {
                tbSumIntoAcc.Visible = true;
                tbSumIntoAcc.Text = "В банкомате недостаточно наличных";
                btnConfirm.Enabled = false;
                return;
            }


            tbSumIntoAcc.Visible = true;

            Dictionary<int, int> banknotesByDenominationsInRequest = banknotesByDenominations.GetCountByDenominations();
            foreach (var banknotes in banknotesByDenominationsInRequest)
            {
                if (banknotes.Value != 0 &&
                    banknotes.Value > ATM.FindBanknotes(banknotes.Key))
                {
                    tbSumIntoAcc.Text = $"Недостаточно запрашиваемых купюр по {banknotes.Key} рублей";
                    btnConfirm.Visible = false;
                    lblPlanSumOnAccAdd.Visible = false;
                    return;
                }
            }

            tbSumIntoAcc.Visible = true;
            tbSumIntoAcc.Text = banknotesByDenominations.GetPlanSumToAddOrWithdraw().ToString();
            btnConfirm.Visible = true;
        }

        private void ShowForAdmin()
        {
            LblNominalVisibleNo();
            NumericVisibleNo();
            lblHello.Text = "Проверка разрешена ";
            btn1inputMoney.Visible = false;
            btn8moneyInHide.Visible = true;
            btn3outMoney.Visible = false;
            btn7moneyOutHide.Visible = true;
            btn4showATM.Visible = true;
            btn5_OK.Visible = false;
            btn6hideShowAtm.Visible = false;
            btn9hideUserName.Visible = true;
            btn4showATM.Enabled = true;
            lblMoneyDeposit.Visible = false;
            lblChooseBanknotes.Visible = false;
            lblPlanSumOnAccAdd.Visible = false;
            tbSumIntoAcc.Visible = false;
            btnConfirm.Visible = false;
            lblnumber.Visible = false;
            lblDate.Visible = false;
            lblCapacity.Visible = false;
            lblSumInATMNow.Visible = false;
            lblCountBanknotesNow.Visible = false;
            lblTitleSumOnAcc.Visible = false;
            tbSummOnAccNow.Visible = false;
            lblAllRangeBancnotesInATV.Visible = false;
            tbBancnotesCountInRange.Visible = false;
        }

        private void ShowForUnknownUser()
        {
            LblNominalVisibleNo();
            NumericVisibleNo();
            lblHello.Text = "В доступе отказано ";
            btn1inputMoney.Visible = false;
            btn8moneyInHide.Visible = true;
            btn3outMoney.Visible = false;
            btn7moneyOutHide.Visible = true;
            btn4showATM.Visible = false;
            btn6hideShowAtm.Visible = true;
            btn5_OK.Visible = true;
            btn9hideUserName.Visible = false;
            lblMoneyDeposit.Visible = false;
            lblChooseBanknotes.Visible = false;
            lblPlanSumOnAccAdd.Visible = false;
            tbSumIntoAcc.Visible = false;
            lblnumber.Visible = false;
            lblDate.Visible = false;
            lblCapacity.Visible = false;
            btnConfirm.Visible = false;
            lblSumInATMNow.Visible = false;
            lblCountBanknotesNow.Visible = false;
            lblTitleSumOnAcc.Visible = false;
            tbSummOnAccNow.Visible = false;
            lblAllRangeBancnotesInATV.Visible = false;
            tbBancnotesCountInRange.Visible = false;
        }

        private void ShowForLoginedUser()
        {
            LblNominalVisibleYes();
            NumericVisibleNo();
            lblHello.Text = "Здравствуйте,    " + UserName;

            btn1inputMoney.Visible = true;
            btn3outMoney.Visible = true;
            btn4showATM.Visible = false;
            btn5_OK.Visible = false;
            btn6hideShowAtm.Visible = true;
            btn7moneyOutHide.Visible = false;
            btn8moneyInHide.Visible = false;
            btn9hideUserName.Visible = true;
            btnConfirm.Visible = false;
            btn3outMoney.Enabled = true;
            btn1inputMoney.Enabled = true;

            lblMoneyDeposit.Visible = false;
            lblChooseBanknotes.Visible = true;
            lblPlanSumOnAccAdd.Visible = true;
            lblAllRangeBancnotesInATV.Visible = false;
            lblnumber.Visible = false;
            lblDate.Visible = false;
            lblCapacity.Visible = false;
            lblSumInATMNow.Visible = false;
            lblCountBanknotesNow.Visible = false;
            lblTitleSumOnAcc.Visible = true;

            tbSumIntoAcc.Visible = true;
            tbSummOnAccNow.Visible = true;
            tbSummOnAccNow.Text = ATM.Users[UserName].ToString();
            tbBancnotesCountInRange.Visible = false;
        }

        private void ShowForATMState()
        {
            lblSumInATMNow.Visible = true;
            lblnumber.Visible = true;
            lblDate.Visible = true;
            lblCapacity.Visible = true;
            lblCountBanknotesNow.Visible = true;
            lblPlanSumOnAccAdd.Visible = false;
            lblAllRangeBancnotesInATV.Visible = true;
            tbBancnotesCountInRange.Visible = true;
            tbSumIntoAcc.Visible = false;
            btnConfirm.Visible = false;
        }

        private void InitializeVisibilities()
        {
            lblMoneyDeposit.Visible = false;
            lblChooseBanknotes.Visible = false;
            lblPlanSumOnAccAdd.Visible = false;
            lblnumber.Visible = false;
            lblDate.Visible = false;
            lblCapacity.Visible = false;
            lblSumInATMNow.Visible = false;
            lblCountBanknotesNow.Visible = false;
            lblTitleSumOnAcc.Visible = false;
            lblAllRangeBancnotesInATV.Visible = false;

            tbSumIntoAcc.Visible = false;
            tbSummOnAccNow.Visible = false;
            tbBancnotesCountInRange.Visible = false;

            btnConfirm.Visible = false;
            btn1inputMoney.Enabled = false;
            btn3outMoney.Enabled = false;
            btn4showATM.Enabled = false;
        }

        private void ShowForChangedUser()
        {
            lblHello.Text = String.Concat("Здравствуйте,              Гость", "\n", "Введите Логин  и нажмите OK");
            NumericVisibleNo();
            NumericValue_0();
            btn1inputMoney.Visible = true;
            btn3outMoney.Visible = true;
            btn4showATM.Visible = true;
            btn5_OK.Visible = true;
            btn6hideShowAtm.Visible = false;
            btn7moneyOutHide.Visible = false;
            btn8moneyInHide.Visible = false;
            btn9hideUserName.Visible = false;
            btnConfirm.Visible = false;
            btn1inputMoney.Enabled = false;
            btn3outMoney.Enabled = false;
            btn4showATM.Enabled = false;

            lblMoneyDeposit.Visible = false;
            lblPlanSumOnAccAdd.Visible = false;
            lblnumber.Visible = false;
            lblDate.Visible = false;
            lblCapacity.Visible = false;
            lblSumInATMNow.Visible = false;
            lblTitleSumOnAcc.Visible = false;
            lblCountBanknotesNow.Visible = false;
            lblAllRangeBancnotesInATV.Visible = false;

            textBox1.Text = null;
            tbSumIntoAcc.Text = null;
            tbSumIntoAcc.Visible = false;
            tbSummOnAccNow.Visible = false;
            tbBancnotesCountInRange.Visible = false;
        }

        private BanknotesByDenominations CreateBanknotesByDenominations() => new(
                RublesCount10,
                RublesCount50,
                RublesCount100,
                RublesCount200,
                RublesCount500,
                RublesCount1000,
                RublesCount2000,
                RublesCount5000
                );
    }
}
