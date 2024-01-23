namespace BankomatForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //  Верхняя левая кнопка:
        //  (КАРТА) главного меню  (выдача новой карты)
        private void left_1_MenuBtn_Click(object sender, EventArgs e)
        {

            if (bigMenuPanel.Visible == true)
            {
                bigMenuPanel.Visible = false;
                //bigCardPanel.Location.X = x;
                //bigMenuPanel.Location.Y = y;
                bigCardPanel.Visible = true;              

            }

        }
        //  Левая нижняя кнопка:
        //  (ПРИНЯТЬ) на панели выдачи карты
        private void left_2_MenuBtn_Click(object sender, EventArgs e)
        {
            // если включена панель выдачи карты:
            // (принимаем данные и выдаем карту)
            if (bigCardPanel.Visible = true)
            {
                Card newCard = new Card();
                newCard.Number = numCardTB.Text; // сделать проверки
                newCard.Pin = pinCardTB.Text;
                newCard.Bank = bankTB.Text;
                newCard.Balans = double.Parse(balansTB.Text);

            }
        }
        // Правая нижняя кнопка
        // (ОТМЕНА) на панели выдачи карты
        private void right_2_MenuBtn_Click(object sender, EventArgs e)
        {
            // если включена панель выдачи карты:
            if (bigCardPanel.Visible = true)
            {
                bigMenuPanel.Visible = true; // вкл.МЕНЮ
                bigCardPanel.Visible = false; // выкл.КАРТУ
            }

        }
    }
}
