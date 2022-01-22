using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        private int atmBanknotesCount = 0;
        private int atmMoneyAmount = 0;

        private Dictionary<int, int> banknotesByDenomination = new Dictionary<int, int>
        {
            [10] = 0,
            [50] = 0,
            [100] = 0,
            [200] = 0,
            [500] = 0,
            [1000] = 0,
            [2000] = 0,
            [5000] = 0,
        };

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

        public void NumericVisibleYes() => Controls.OfType<NumericUpDown>().ToList().ForEach(c => c.Visible = true);

        public void NumericVisibleNo() => Controls.OfType<NumericUpDown>().ToList().ForEach(c => c.Visible = false);

        public void NumericValue_0() => Controls.OfType<NumericUpDown>().ToList().ForEach(c => c.Value = 0);

        public void LblNominalVisibleYes()
        {
            lbl10.Visible = true; lbl50.Visible = true; lbl100.Visible = true; lbl200.Visible = true;
            lbl500.Visible = true; lbl1000.Visible = true; lbl2000.Visible = true; lbl5000.Visible = true;
        }
        public void LblNominalVisibleNo()
        {
            lbl10.Visible = false; lbl50.Visible = false; lbl100.Visible = false; lbl200.Visible = false;
            lbl500.Visible = false; lbl1000.Visible = false; lbl2000.Visible = false; lbl5000.Visible = false;
        }


        public Form1()
        {
            InitializeComponent();
            NumericVisibleNo();
            LblNominalVisibleNo();
            lblMoneyDeposit.Visible = false;
            lblChoosBancnotes.Visible = false;
            lblPlanSumOnAccAdd.Visible = false;
            tbSumIntoAcc.Visible = false;
            lblnumber.Visible = false;
            lblDate.Visible = false;
            lblCapacity.Visible = false;
            btnConfirm.Visible = false;
            btn1inputMoney.Enabled = false;
            btn3outMoney.Enabled = false;
            btn4showATM.Enabled = false;
            lblSumInATMNow.Visible = false;
            lblCountBanknotesNow.Visible = false;
            lblTitleSumOnAcc.Visible = false;
            tbSummOnAccNow.Visible = false;
            lblAllRangeBancnotesInATV.Visible = false;
            tbBancnotesCountInRange.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn1inputMoney_Click(object sender, EventArgs e)
        {
            NumericVisibleYes();
            NumericValue_0();
            tbSumIntoAcc.Visible = true;
            lblPlanSumOnAccAdd.Visible = true;
            lblPlanSumOnAccAdd.Text = "Нажмите для проверки \r\nвносимой суммы";
            lblMoneyDeposit.Visible = true;
            lblMoneyDeposit.Text = "Выполняется операция по внесению наличных";
            tbSumIntoAcc.Text = String.Empty;
            btnConfirm.Enabled = true;
        }
        private void btn3outMoney_Click(object sender, EventArgs e)
        {
            NumericVisibleYes();
            NumericValue_0();
            tbSumIntoAcc.Visible = true;
            lblPlanSumOnAccAdd.Visible = true;
            lblPlanSumOnAccAdd.Text = "Нажмите для проверки \r\nвыводимой суммы";
            lblMoneyDeposit.Text = "Выполняется операция по снятию наличных";
            lblMoneyDeposit.Visible = true;
            tbSumIntoAcc.Text = String.Empty;
            btnConfirm.Enabled = true;
        }

        private void btn5_OK_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text.ToString();

            if (a == "Админ")
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
                lblChoosBancnotes.Visible = false;
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

            else if (!Users.users.Keys.Contains(a))
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
                lblChoosBancnotes.Visible = false;
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

            else
            {
                LblNominalVisibleYes();
                NumericVisibleNo();
                lblHello.Text = "Здравствуйте,    " + a;

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
                lblChoosBancnotes.Visible = true;
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
                tbSummOnAccNow.Text = Users.users[textBox1.Text].ToString();
                tbBancnotesCountInRange.Visible = false;
            }
        }

        private void btn4showATM_Click(object sender, EventArgs e)
        {
            ATM atm = new ATM(RublesCount10, RublesCount50, RublesCount100, RublesCount200, RublesCount500, RublesCount1000, RublesCount2000, RublesCount5000);
            lblDate.Text = atm.GetDate();
            lblnumber.Text = atm.GetATMNumber();
            lblCapacity.Text = atm.GetmaxBanknotesCapacityToString();
            var sb = new StringBuilder();
            foreach (KeyValuePair<int, int> k in banknotesByDenomination)
            {
                sb.Append(k.Value.ToString());
                sb.Append("      ");
            }
            tbBancnotesCountInRange.Text = sb.ToString();
            lblCountBanknotesNow.Text = "Количество купюр в банкомате      " + atmBanknotesCount.ToString();
            lblSumInATMNow.Text = "Сумма в банкомате      " + atmMoneyAmount.ToString();
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

        private void btnChangeUser_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Не только для добавить, но и для снять кнопка проверки планируемой суммы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblPlanSumOnAccAdd_Click(object sender, EventArgs e)
        {
            ATM atm = new ATM(RublesCount10, RublesCount50, RublesCount100, RublesCount200, RublesCount500, RublesCount1000, RublesCount2000, RublesCount5000);

            if (lblPlanSumOnAccAdd.Text == "Нажмите для проверки \r\nвносимой суммы")
            {
                if ((atm.GetPlanBancnotesCountInATM(textBox1.Text) + atmBanknotesCount) > atm.GetMaxBanknotesCapasity())
                {
                    tbSumIntoAcc.Visible = true;
                    tbSumIntoAcc.Text = "Банкомат переполнен  ";
                    btnConfirm.Visible = false;
                }
                else
                {
                    tbSumIntoAcc.Text = atm.GetPlanSummToAddIntoAcc().ToString();
                    btnConfirm.Visible = true;
                    tbSumIntoAcc.Visible = true;
                }
            }

            else
            {
                int planWithdrawnSumm = atm.GetPlanSummToAddIntoAcc();
                if (planWithdrawnSumm > Users.users[textBox1.Text])
                {
                    tbSumIntoAcc.Visible = true;
                    tbSumIntoAcc.Text = "На счете недостаточно средств ";
                }

                else if (planWithdrawnSumm > atmMoneyAmount)
                {
                    int b = atmMoneyAmount;
                    tbSumIntoAcc.Visible = true;
                    tbSumIntoAcc.Text = "В банкомате недостаточно наличных ";
                }

                else if (planWithdrawnSumm < atmMoneyAmount)
                {
                    tbSumIntoAcc.Visible = true;
                    bool flag = true;
                    Dictionary<int, int> d = atm.GetCountByDenominations();// сколько каких купюр пользователь хочет снять
                    banknotesByDenomination = banknotesByDenomination.ToDictionary(orig => orig.Key, orig => orig.Value - d[orig.Key]);//разница старого количества купюр и добавленного
                    int BancnotesCount = 0;
                    foreach (KeyValuePair<int, int> k in banknotesByDenomination)
                    {
                        BancnotesCount = k.Value;
                        if (k.Value < 0)
                        {
                            tbSumIntoAcc.Text = "Недостаточно запрашиваемых купюр ";
                            banknotesByDenomination = banknotesByDenomination.ToDictionary(orig => orig.Key, orig => orig.Value + d[orig.Key]);
                            flag = false;
                            btnConfirm.Visible = false;
                            lblPlanSumOnAccAdd.Visible = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        //восстанавливаем состояние, так как еще не нажата кнопка подтверждения
                        banknotesByDenomination = banknotesByDenomination.ToDictionary(orig => orig.Key, orig => orig.Value + d[orig.Key]);

                        tbSumIntoAcc.Visible = true;
                        tbSumIntoAcc.Text = atm.GetPlanSummToAddIntoAcc().ToString();
                        btnConfirm.Visible = true;
                    }
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ATM atm = new ATM(RublesCount10, RublesCount50, RublesCount100, RublesCount200, RublesCount500, RublesCount1000, RublesCount2000, RublesCount5000);
            Dictionary<int, int> d = atm.GetCountByDenominations();// получить количество банкнот добавляемых пользователем по номиналам

            if (lblPlanSumOnAccAdd.Text == "Нажмите для проверки \r\nвносимой суммы")
            {
                if (tbSumIntoAcc.Text == string.Empty)
                {
                    tbSumIntoAcc.Text = "0";
                }
                int summForAdd = Int32.Parse(tbSumIntoAcc.Text);
                Users.users[textBox1.Text] += summForAdd;//записали пользователю сумму на счет
                tbSummOnAccNow.Text = Users.users[textBox1.Text].ToString();
                atmBanknotesCount += atm.GetPlanBancnotesCountInATM(textBox1.Text);//АТМ увеличили количесвто банкнот 
                atmMoneyAmount += summForAdd; //АТМ увеличили сумму в банкомате
                banknotesByDenomination = banknotesByDenomination.ToDictionary(orig => orig.Key, orig => orig.Value + d[orig.Key]);// сохранить сумму старого количества банкнот по номиналам и добавленного                
            }

            else
            { 
                if(tbSumIntoAcc.Text==string.Empty)
                {
                    tbSumIntoAcc.Text = "0";
                }
                int summForWithdrawn = Int32.Parse(tbSumIntoAcc.Text);
                Users.users[textBox1.Text] -= summForWithdrawn;
                tbSummOnAccNow.Text = Users.users[textBox1.Text].ToString();
                atmBanknotesCount -= atm.GetPlanBancnotesCountInATM(textBox1.Text);//АТМ уменьшили количесвто банкнот
                atmMoneyAmount -= summForWithdrawn;// АТМ уменьшили сумму в банкомате
                banknotesByDenomination = banknotesByDenomination.ToDictionary(orig => orig.Key, orig => orig.Value - d[orig.Key]);// сохранить сумму старого количества банкнот по номиналам и снятого

            }
            tbSumIntoAcc.Visible = false;
            lblPlanSumOnAccAdd.Visible = false;
            NumericVisibleNo();
            btnConfirm.Enabled = false;
        }

    }
}
