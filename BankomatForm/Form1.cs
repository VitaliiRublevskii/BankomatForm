using Microsoft.VisualBasic.ApplicationServices;
using System.Text;
using System;
using System.Text.Json;
using System.IO;
using System.Reflection;

namespace BankomatForm
{
    public partial class Form1 : Form
    {
        public List<Card> cards { get; set; }


        public Form1()
        {
            InitializeComponent();

            string cardFromFile = File.ReadAllText("cards.json");
            cards = JsonSerializer.Deserialize<List<Card>>(cardFromFile);

            JsonSerializer.Deserialize<List<User>>(cardFromFile);
            bigMenuPanel.Visible = true;
            bigCardPanel.Visible = false;
            cardAddPanel.Visible = false;
            cashMenuPanel.Visible = false;
            errorCashPanel.Visible = false;
            sumCashPanel.Visible = false;
            errorSumCashPanel.Visible = false;
            menuInCardLB.Visible = false;
           
        }

        Card myCard = new Card();
       

        //  Верхняя левая кнопка:
        //  (ВЫДАТЬ КАРТУ) главного меню  (выдача новой карты)
        private void left_1_MenuBtn_Click(object sender, EventArgs e)
        {

            if (bigMenuPanel.Visible == true)
            {
                bigMenuPanel.Visible = false;
                cardAddPanel.Visible = false;
                bigCardPanel.Visible = true;
                bigCardPanel.Location = new Point(162, 31);
                Random random = new Random();
                Card newCard = new Card();
                numCardTB.Text = RndNum(4) + "-" + RndNum(4) + "-" + RndNum(4) + "-" + RndNum(4);

                newCard.Number = numCardTB.Text.ToString();
                pinCardTB.Text = RndNum(4);
                newCard.Pin = pinCardTB.Text.ToString();
                bankTB.Text = RndBank(1);
                newCard.Bank = bankTB.Text.ToString();
                balansTB.Text = random.Next(0, 100000).ToString();
                newCard.Balans = double.Parse(balansTB.Text);

            }

        }

        //  Левая нижняя кнопка:
        //  (СНЯТЬ) на панели МЕНЮ

        private void left_2_MenuBtn_Click(object sender, EventArgs e)
        {

            // если включена панель меню
            // включаем панель ввода и проверки номера карты и пин-кода
            if (bigMenuPanel.Visible = true)
            {
                menuInCardLB.Visible = true;
            }

            if (cashMenuPanel.Visible == true)
            {
                //  добавить вывод баланса
                Card my_Card = new Card();
                my_Card.Number = cashNumTB.Text.ToString();
                my_Card.Pin = cashPinTB.Text.ToString();
                for (int i = 0; i < cards.Count; i++)
                {
                    if (cards[i].Number == my_Card.Number && cards[i].Pin == my_Card.Pin)
                    {
                        // если номер карты и пин-код СОВПАДАЮТ :
                        // переходим на панель выдачи суммы
                        errorCashPanel.Visible = true;
                        errorCashPanel.Location = new Point(98, 16);
                        
                        foreach (Card card in cards)
                        {// если проверка прошла, записываем в мою карту проеренную карту
                            if (card.Number == my_Card.Number && card.Pin == my_Card.Pin)
                            {
                                myCard.Number = card.Number;
                                myCard.Pin = card.Pin;
                                myCard.Bank = card.Bank;
                                myCard.Balans = card.Balans;
                            }

                        }
                        break;
                        
                    }
                    else
                    {// если не совпали - ошибка
                        errorCashPanel.Visible = true;
                        errorCashPanel.Location = new Point(98, 16);
                        cashNumTB.Clear();
                        cashPinTB.Clear();
                    }
                }
                errorCash_1_LB.Text = "КАРТА ПРИНЯТА";
                errorCash_2_LB.Text = $"Ваш баланс : {myCard.Balans} грн.";
            }
        }




        // Правая нижняя кнопка
        // (ОТМЕНА) на панели выдачи карты
        // (ОТМЕНА) на панели выдачи наличных
        private void right_2_MenuBtn_Click(object sender, EventArgs e)
        {
            //  если включено ОСНОВНОЕ МЕНЮ
            //  кнопка БАЛАНС
            if (bigMenuPanel.Visible = true)
            {
                menuInCardLB.Visible = true;

            }




            // если включена панель выдачи карты:
            if (bigCardPanel.Visible == true)
            {
                bigMenuPanel.Visible = true; // вкл.МЕНЮ
                bigCardPanel.Visible = false; // выкл.КАРТУ
                cardAddPanel.Visible = false; // выкл. сообщ.
            }
            // если включена панель ввода номера и пина карты для проверки
            if (cashMenuPanel.Visible == true)
            {
                bigMenuPanel.Visible = true;  // вкл.МЕНЮ
                cashMenuPanel.Visible = false;  // выкл. КЕШ
                errorCashPanel.Visible = false; // выкл. ошибку

            }
            // если включена ОШИБКА на панели ввода суммы для снятия 
            if (sumCashPanel.Visible = true && errorSumCashPanel.Visible == true)
            {
                errorSumCashPanel.Visible = false;
                sumCashTB.Clear();
            }

            if (sumCashPanel.Visible = true)
            {
                sumCashPanel.Visible = false; // выкл. СУММ
                bigMenuPanel.Visible = true; // вкл.МЕНЮ
            }

        }




        // Кнопка ENTER
        private void enterMenuBtn_Click(object sender, EventArgs e)
        {
            // если включена панель выдачи карты:
            // (принимаем данные и выдаем карту)
            if (bigCardPanel.Visible == true)
            {
                Random random = new Random();
                Card newCard = new Card();
                numCardTB.Text = RndNum(4) + "-" + RndNum(4) + "-" + RndNum(4) + "-" + RndNum(4);

                newCard.Number = numCardTB.Text.ToString();
                pinCardTB.Text = RndNum(4);
                newCard.Pin = pinCardTB.Text.ToString();
                bankTB.Text = RndBank(1);
                newCard.Bank = bankTB.Text.ToString();
                balansTB.Text = random.Next(0, 100000).ToString();
                newCard.Balans = double.Parse(balansTB.Text);
                cards.Add(newCard);
                
                cardAddPanel.Visible = true;
                cardAddPanel.Location = new Point(98, 16);

            }


            // если включена панель ввода номера и пина
            else if (cashMenuPanel.Visible == true)
            {
                // СОЗДАЕМ НОВУЮ КАРТУ   И ПРОВЕРЯЕМ НАЛИЧИЕ ЕЕ В СПИСКЕ КАРТ    
                Card my_Card = new Card();
                my_Card.Number = cashNumTB.Text.ToString();
                my_Card.Pin = cashPinTB.Text.ToString();

                for (int i = 0; i < cards.Count; i++)
                {
                    if (cards[i].Number == my_Card.Number && cards[i].Pin == my_Card.Pin)
                    {
                        // если номер карты и пин-код СОВПАДАЮТ :
                        // переходим на панель выдачи суммы
                        sumCashPanel.Visible = true;
                        sumCashPanel.Location = new Point(162, 31);
                        cashMenuPanel.Visible = false;

                        foreach (Card card in cards)
                        {// если проверка прошла, записываем в мою карту проеренную карту
                            if (card.Number == my_Card.Number && card.Pin == my_Card.Pin)
                            {
                                myCard.Number = card.Number;
                                myCard.Pin = card.Pin;
                                myCard.Bank = card.Bank;
                                myCard.Balans = card.Balans;
                            }

                        }
                        break;
                    }
                    else
                    {// если не совпали - ошибка
                        errorCashPanel.Visible = true;
                        errorCashPanel.Location = new Point(98, 16);
                        cashNumTB.Clear();
                        cashPinTB.Clear();
                    }
                }
            }


            // если включена панель ввода суммы (снятие денег)
            else if (sumCashPanel.Visible = true)
            {
                double sum = double.Parse(sumCashTB.Text);
                if (myCard.Balans < sum)
                {
                    errorSumCashPanel.Visible = true;
                    errorSumCashPanel.Location = new Point(98, 16);
                    balansSumLB.Text = $"Ваш баланс {myCard.Balans - sum} грн.";
                }
                else if (myCard.Balans > sum)
                {
                    //  включить сообщение о снятии
                    errorSumCashPanel.Visible = true;
                    errorSumCashPanel.Location = new Point(98, 16);
                    errorSum_1_LB.Text = "ОПЕРАЦИЯ УСПЕШНА";
                    errorSum_2_LB.Text = $"Вы сняли {sum} грн.";
                    cashBtn.BackColor = Color.Green;

                    cards.Remove(myCard);                    
                    myCard.Balans -= sum;
                    cards.Add(myCard);
                    //string strToFile = JsonSerializer.Serialize(cards);
                    //File.WriteAllText("cards.json", strToFile);

                }
            }

        }
        //  КНОПКИ    ЦИФРЫ
        private void button_Click(object sender, EventArgs e)
        {

            if (cashMenuPanel.Visible == true)
            {
                Button button = (Button)sender;
                if (cashNumTB.Text.Length == 4 || cashNumTB.Text.Length == 9 || cashNumTB.Text.Length == 14)
                    cashNumTB.Text = cashNumTB.Text + "-";

                if (cashNumTB.Text.Length < 19)
                    cashNumTB.Text = cashNumTB.Text + button.Text;

                //if (cashNumTB.Text.Length > 19)
                else
                {
                    if (cashPinTB.Text.Length < 4)
                        cashPinTB.Text = cashPinTB.Text + button.Text;
                }
            }

            if (sumCashPanel.Visible == true)
            {
                Button button = (Button)sender;
                sumCashTB.Text = sumCashTB.Text + button.Text;
            }

        }

        //  Кнопка   DELETE
        private void delMenuBtn_Click(object sender, EventArgs e)
        {
            if (sumCashPanel.Visible == true)
            {
                sumCashTB.Clear();
            }
            if (cashMenuPanel.Visible == true)
            {
                cashNumTB.Clear();
                cashPinTB.Clear();
            }
        }


        //  Кнопка   ВЫЙТИ

        private void right_1_MenuBtn_Click(object sender, EventArgs e)
        {
            string strToFile = JsonSerializer.Serialize(cards);
            File.WriteAllText("cards.json", strToFile);
            Application.Exit();
        }


        private void menuRight_1_LB_Click(object sender, EventArgs e)
        {
            
        }



        //  Генерация номера карты при выдачи новой
        public static string RndNum(int numbers)
        {
            Random random = new Random();
            StringBuilder sNum = new StringBuilder(numbers);

            string numberSet = "0123456789";

            for (int i = 0; i < numbers; i++)
                sNum.Append(numberSet[random.Next(numberSet.Length)]);
            return sNum.ToString();
        }
        public static Random random = new Random();
        public static string RndBank(int letters)
        {
            StringBuilder sbank = new StringBuilder(letters);
            List<string> letterSet = new List<string> { "PrivatBank", "OschadBank", "UkrSibBank", "RaiffeisenBank" };

            for (int i = 0; i < 1; i++)
                sbank.Append(letterSet[random.Next(4)]);

            return sbank.ToString();
        }

        private void cardBtn_Click(object sender, EventArgs e)
        {
            bigMenuPanel.Visible = false;
            cashMenuPanel.Visible = true;
            cashMenuPanel.Location = new Point(162, 31);
            errorCashPanel.Visible = false;
        }

        private void balansSumLB_Click(object sender, EventArgs e)
        {
            balansSumLB.Text = myCard.Balans.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        
       
    }
}
