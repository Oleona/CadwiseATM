using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ATM
{
    public partial class AtmForm : Form
    {
        public int RublesCount10
        {
            get { return (int)num10Rubbles.Value; }
            set { num10Rubbles.Value = value; }
        }
        public int RublesCount50
        {
            get { return (int)num50Rubbles.Value; }
            set { num50Rubbles.Value = value; }
        }
        public int RublesCount100
        {
            get { return (int)num100Rubbles.Value; }
            set { num100Rubbles.Value = value; }
        }
        public int RublesCount200
        {
            get { return (int)num200Rubbles.Value; }
            set { num200Rubbles.Value = value; }
        }
        public int RublesCount500
        {
            get { return (int)num500Rubbles.Value; }
            set { num500Rubbles.Value = value; }
        }
        public int RublesCount1000
        {
            get { return (int)num1000Rubbles.Value; }
            set { num1000Rubbles.Value = value; }
        }
        public int RublesCount2000
        {
            get { return (int)num2000Rubbles.Value; }
            set { num2000Rubbles.Value = value; }
        }
        public int RublesCount5000
        {
            get { return (int)num5000Rubbles.Value; }
            set { num5000Rubbles.Value = value; }
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
            lbl10Rubbles.Visible = true; lbl50Rubbles.Visible = true; lbl100Rubbles.Visible = true; lbl200Rubbles.Visible = true;
            lbl500Rubbles.Visible = true; lbl1000Rubbles.Visible = true; lbl2000Rubbles.Visible = true; lbl5000Rubbles.Visible = true;
        }
        private void LblNominalVisibleNo()
        {
            lbl10Rubbles.Visible = false; lbl50Rubbles.Visible = false; lbl100Rubbles.Visible = false; lbl200Rubbles.Visible = false;
            lbl500Rubbles.Visible = false; lbl1000Rubbles.Visible = false; lbl2000Rubbles.Visible = false; lbl5000Rubbles.Visible = false;
        }


        public AtmForm()
        {
            InitializeComponent();
            NumericVisibleNo();
            LblNominalVisibleNo();

            InitializeVisibilities();
        }

        private void btn1inputMoney_Click(object sender, EventArgs e)
        {
            NumericVisibleYes();
            ShowWithdrawSomehow(false);

            NumericValue_0();
            tbSumIntoAcc.Visible = true;
            lblChooseBanknotes.Visible = true;
            lblPlanSumOnAccAdd.Visible = true;
            lblPlanSumOnAccAdd.Text = "Нажмите на этот текст для проверки вносимой суммы";
            lblMoneyDeposit.Visible = true;
            lblMoneyDeposit.Text = "Покупюрное внесение наличных";
            tbSumIntoAcc.Text = String.Empty;
            btnConfirmSum.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn3outMoney_Click(object sender, EventArgs e)
        {
            NumericVisibleYes();
            NumericValue_0();

            ShowWithdrawSomehow(true);

            tbSumIntoAcc.Visible = true;
            lblChooseBanknotes.Visible = true;
            lblPlanSumOnAccAdd.Visible = true;
            lblPlanSumOnAccAdd.Text = "Нажмите на этот текст для проверки выводимой суммы";
            lblMoneyDeposit.Text = "Покупюрное снятие наличных";
            lblMoneyDeposit.Visible = true;
            tbSumIntoAcc.Text = string.Empty;
            btnConfirmSum.Enabled = true;
        }

        private void btn4showATM_Click(object sender, EventArgs e)
        {
            lblCurrentDate.Text = ATM.GetDate();
            lblAtmNumber.Text = ATM.SerialNumber;
            lblAtmCapacity.Text = ATM.GetMaxBanknotesCapacityToString();
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

            if (ATM.GetUserInfo(UserName).Name == "Неизвестный пользователь")
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

            tbSummOnAccNow.Text = ATM.GetUserInfo(UserName).DepositValue.ToString(); ;

            tbSumIntoAcc.Visible = false;
            lblPlanSumOnAccAdd.Visible = false;
            NumericVisibleNo();
            btnConfirmSum.Enabled = false;
        }

        private void btnConfirmWithdrawalAmount_Click(object sender, EventArgs e)
        {
            var sumToWithdraw = (int)numWithdrawAmount.Value;
            int userDepositValue = ATM.GetUserInfo(UserName).DepositValue;

            if (sumToWithdraw > userDepositValue)
            {
                tbResultWithdrawn.Text = "На счете недостаточно средств";
            }
            else if (sumToWithdraw > ATM.TotalMoney)
            {
                tbResultWithdrawn.Text = "В банкомате недостаточно наличных";
            }
            else if (sumToWithdraw % 10 != 0)
            {
                tbResultWithdrawn.Text = "В банкомате нет монет, сумма должна быть кратна 10 рублям";
            }
            else if (sumToWithdraw > 50000)
            {
                tbResultWithdrawn.Text = "Разрешено снятие не более 50 000 руб";
            }
            else if (ATM.WithdrawMoneySomehow(sumToWithdraw, UserName))
            {
                var reminder = userDepositValue - sumToWithdraw;
                tbResultWithdrawn.Text = $"На вашем счёте осталось {reminder} рублей";
                tbSummOnAccNow.Text = reminder.ToString();
            }
            else
            {
                tbResultWithdrawn.Text = "Купюр, необходимых для снятия данной суммы, нет в банкомате";
            }

        }

        private void AddOnUserAccount(BanknotesByDenominations banknotesByDenominations)
        {
            var banknotesToAddCount = banknotesByDenominations.TotalBanknotesCount;
            if (ATM.TotalBanknotesCount + banknotesToAddCount > ATM.MaxBanknotesCapacity)
            {
                tbSumIntoAcc.Visible = true;
                tbSumIntoAcc.Text = "Банкомат переполнен  ";
                btnConfirmSum.Enabled = false;
                btnConfirmSum.Visible = false;
            }
            else
            {
                tbSumIntoAcc.Text = banknotesByDenominations.PlanSumToAddOrWithdraw.ToString();
                btnConfirmSum.Visible = true;
                tbSumIntoAcc.Visible = true;
            }
        }

        private void WithdrawFromUserAccount(BanknotesByDenominations banknotesByDenominations)
        {
            var sumToWithdraw = banknotesByDenominations.PlanSumToAddOrWithdraw;
            int userDepositValue = ATM.GetUserInfo(UserName).DepositValue;

            if (sumToWithdraw > userDepositValue)
            {
                tbSumIntoAcc.Visible = true;
                tbSumIntoAcc.Text = "На счете недостаточно средств";
                btnConfirmSum.Enabled = false;
                return;
            }

            if (sumToWithdraw > ATM.TotalMoney)
            {
                tbSumIntoAcc.Visible = true;
                tbSumIntoAcc.Text = "В банкомате недостаточно наличных";
                btnConfirmSum.Enabled = false;
                return;
            }


            tbSumIntoAcc.Visible = true;

            Dictionary<int, int> banknotesByDenominationsInRequest = banknotesByDenominations.CountByDenominations;
            foreach (var banknotes in banknotesByDenominationsInRequest)
            {
                if (banknotes.Value != 0 &&
                    banknotes.Value > ATM.FindBanknotesCount(banknotes.Key))
                {
                    tbSumIntoAcc.Text = $"Недостаточно запрашиваемых купюр по {banknotes.Key} рублей";
                    btnConfirmSum.Visible = false;
                    lblPlanSumOnAccAdd.Visible = false;
                    return;
                }
            }

            tbSumIntoAcc.Visible = true;
            tbSumIntoAcc.Text = banknotesByDenominations.PlanSumToAddOrWithdraw.ToString();
            btnConfirmSum.Visible = true;
        }

        private void ShowWithdrawSomehow(bool isVisible)
        {
            numWithdrawAmount.Visible = isVisible;
            lblChoiceAmountWithdraw.Visible = isVisible;
            btnConfirmWithdrawalAmount.Visible = isVisible;
            lblWithdrawResult.Visible = isVisible;
            tbResultWithdrawn.Visible = isVisible;
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
            btnConfirmSum.Visible = false;
            lblAtmNumber.Visible = false;
            lblCurrentDate.Visible = false;
            lblAtmCapacity.Visible = false;
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
            lblAtmNumber.Visible = false;
            lblCurrentDate.Visible = false;
            lblAtmCapacity.Visible = false;
            btnConfirmSum.Visible = false;
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
            btnConfirmSum.Visible = false;
            btn3outMoney.Enabled = true;
            btn1inputMoney.Enabled = true;

            lblMoneyDeposit.Visible = false;
            lblChooseBanknotes.Visible = false;
            lblPlanSumOnAccAdd.Visible = false;
            lblAllRangeBancnotesInATV.Visible = false;
            lblAtmNumber.Visible = false;
            lblCurrentDate.Visible = false;
            lblAtmCapacity.Visible = false;
            lblSumInATMNow.Visible = false;
            lblCountBanknotesNow.Visible = false;
            lblTitleSumOnAcc.Visible = true;

            tbSumIntoAcc.Visible = false;
            tbSummOnAccNow.Visible = true;
            tbSummOnAccNow.Text = ATM.GetUserInfo(UserName).DepositValue.ToString();
            tbBancnotesCountInRange.Visible = false;
        }

        private void ShowForATMState()
        {
            lblSumInATMNow.Visible = true;
            lblAtmNumber.Visible = true;
            lblCurrentDate.Visible = true;
            lblAtmCapacity.Visible = true;
            lblCountBanknotesNow.Visible = true;
            lblPlanSumOnAccAdd.Visible = false;
            lblAllRangeBancnotesInATV.Visible = true;
            tbBancnotesCountInRange.Visible = true;
            tbSumIntoAcc.Visible = false;
            btnConfirmSum.Visible = false;
        }

        private void InitializeVisibilities()
        {
            lblMoneyDeposit.Visible = false;
            lblChooseBanknotes.Visible = false;
            lblPlanSumOnAccAdd.Visible = false;
            lblAtmNumber.Visible = false;
            lblCurrentDate.Visible = false;
            lblAtmCapacity.Visible = false;
            lblSumInATMNow.Visible = false;
            lblCountBanknotesNow.Visible = false;
            lblTitleSumOnAcc.Visible = false;
            lblAllRangeBancnotesInATV.Visible = false;

            tbSumIntoAcc.Visible = false;
            tbSummOnAccNow.Visible = false;
            tbBancnotesCountInRange.Visible = false;

            btnConfirmSum.Visible = false;
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
            btnConfirmSum.Visible = false;
            btn1inputMoney.Enabled = false;
            btn3outMoney.Enabled = false;
            btn4showATM.Enabled = false;

            lblMoneyDeposit.Visible = false;
            lblPlanSumOnAccAdd.Visible = false;
            lblAtmNumber.Visible = false;
            lblCurrentDate.Visible = false;
            lblAtmCapacity.Visible = false;
            lblSumInATMNow.Visible = false;
            lblTitleSumOnAcc.Visible = false;
            lblCountBanknotesNow.Visible = false;
            lblAllRangeBancnotesInATV.Visible = false;

            textBox1.Text = null;
            tbSumIntoAcc.Text = null;
            tbSumIntoAcc.Visible = false;
            tbSummOnAccNow.Visible = false;
            tbBancnotesCountInRange.Visible = false;

            ShowWithdrawSomehow(false);
        }

        private BanknotesByDenominations CreateBanknotesByDenominations() =>
            new(new Dictionary<int, int> {
                {Denominations.R10, RublesCount10 },
                {Denominations.R50, RublesCount50 },
                {Denominations.R100, RublesCount100 },
                {Denominations.R200, RublesCount200 },
                {Denominations.R500, RublesCount500 },
                {Denominations.R1000, RublesCount1000 },
                {Denominations.R2000, RublesCount2000 },
                {Denominations.R5000, RublesCount5000 },
            });
    }
}
