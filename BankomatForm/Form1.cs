namespace BankomatForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //  ������� ����� ������:
        //  (�����) �������� ����  (������ ����� �����)
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
        //  ����� ������ ������:
        //  (�������) �� ������ ������ �����
        private void left_2_MenuBtn_Click(object sender, EventArgs e)
        {
            // ���� �������� ������ ������ �����:
            // (��������� ������ � ������ �����)
            if (bigCardPanel.Visible = true)
            {
                Card newCard = new Card();
                newCard.Number = numCardTB.Text; // ������� ��������
                newCard.Pin = pinCardTB.Text;
                newCard.Bank = bankTB.Text;
                newCard.Balans = double.Parse(balansTB.Text);

            }
        }
        // ������ ������ ������
        // (������) �� ������ ������ �����
        private void right_2_MenuBtn_Click(object sender, EventArgs e)
        {
            // ���� �������� ������ ������ �����:
            if (bigCardPanel.Visible = true)
            {
                bigMenuPanel.Visible = true; // ���.����
                bigCardPanel.Visible = false; // ����.�����
            }

        }
    }
}
