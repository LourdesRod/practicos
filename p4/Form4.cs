namespace Practico5
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Bgenerar_Click(object sender, EventArgs e)
        {
            //if son numeros y no vacio
            var desde = Convert.ToInt32(TBdesde.Text);
            var hasta = Convert.ToInt32(TBhasta.Text);

            while (desde <= hasta)
            {
                listBox1.Items.Add(desde);
                desde++;
            }

        }

        private void Bpares_Click(object sender, EventArgs e)
        {
            var desde = Convert.ToInt32(TBdesde.Text);
            var hasta = Convert.ToInt32(TBhasta.Text);

            while (desde <= hasta)
            {
                if (desde % 2 == 0)
                {
                    listBox1.Items.Add(desde);
                }
                desde++;
            }
        }

        private void Bimpares_Click(object sender, EventArgs e)
        {
            var desde = Convert.ToInt32(TBdesde.Text);
            var hasta = Convert.ToInt32(TBhasta.Text);

            while (desde <= hasta)
            {
                if (desde % 2 != 0)
                {
                    listBox1.Items.Add(desde);
                }
                desde++;
            }
        }

        private void Bprimos_Click(object sender, EventArgs e)
        {
            var desde = Convert.ToInt32(TBdesde.Text);
            var hasta = Convert.ToInt32(TBhasta.Text);
            //var contador = 0;
            for (int i = desde; i < hasta; i++)
            {
              var  contador = 0;
                if (i > 1)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            contador = 1;
                            break;
                        }
                    }
                    if (contador == 0)
                    {
                        listBox1.Items.Add(i);
                    }
                }
            }
            
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}