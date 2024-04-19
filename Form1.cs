namespace AS2324.Russo.Antonio._3G.esBattagliaNavale
{
    public partial class Form1 : Form
    {
        int[,] tabella1 = new int[10, 10];
        int[,] tabella2 = new int[10, 10];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label1.Text = "Riga";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            
            for (int i = 0; i < 20; i++)
            {
                int x = random.Next(10); 
                int y = random.Next(10);
                if (tabella1[x, y] == 0)
                {
                    tabella1[x, y] = 1;
                }
                else
                {
                    i--; 
                }
            }

            
            for (int i = 0; i < 20; i++)
            {
                int x = random.Next(10); 
                int y = random.Next(10);
                if (tabella2[x, y] == 0)
                {
                    tabella2[x, y] = 1;
                }
                else
                {
                    i--; 
                }
            }

        }
    }
}