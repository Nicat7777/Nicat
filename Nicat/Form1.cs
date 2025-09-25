namespace Nicat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 8)
            {
                MessageBox.Show("Şifrə ən az 8 simvoldan ibarət olmalıdır");
                return;
            }

            string xususiSimvol = "!@#$%^&*()-_=+[]{}|;:'\",.<>?/`~";
            string boyukHerfler = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string kicikHerfler = "abcdefghijklmnopqrstuvwxyz";
            string reqemler = "0123456789";

            bool boyukVar = false;
            bool kicikVar = false;
            bool reqemVar = false;
            bool xususiVar = false;
            bool ardicil3EyniSimvol = false;

            char evvelkiSimvol = '\0';
            int say = 1;

            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                char simvol = textBox2.Text[i];

                if (reqemler.Contains(simvol)) reqemVar = true;
                else if (boyukHerfler.Contains(simvol)) boyukVar = true;
                else if (kicikHerfler.Contains(simvol)) kicikVar = true;
                else if (xususiSimvol.Contains(simvol)) xususiVar = true;

                if (simvol == evvelkiSimvol)
                {
                    say++;
                    if (say >= 3)
                        ardicil3EyniSimvol = true;
                }
                else
                {
                    say = 1;
                }

                evvelkiSimvol = simvol;
            }

            if (reqemVar && kicikVar && boyukVar && xususiVar && !ardicil3EyniSimvol)
            {
                MessageBox.Show("Şifrə uğurla yaradıldı");
            }
            else
            {
                if (!boyukVar) MessageBox.Show("Ən az 1 böyük hərf olmalıdır");
                if (!kicikVar) MessageBox.Show("Ən az 1 kiçik hərf olmalıdır");
                if (!reqemVar) MessageBox.Show("Ən az 1 rəqəm olmalıdır");
                if (!xususiVar) MessageBox.Show("Ən az 1 xüsusi simvol olmalıdır");
                if (ardicil3EyniSimvol) MessageBox.Show("Eyni simvol ard-arda 3 dəfə gələ bilməz");
            }


        }
    }
}
